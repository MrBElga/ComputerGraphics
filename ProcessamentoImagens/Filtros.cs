using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace ProcessamentoImagens
{
    class Filtros
    {
        //com acesso direto a memória
        public static void convert_to_grayDMA(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
        {
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;
            int pixelSize = 3;
            Int32 gs;

            //lock dados bitmap origem
            BitmapData bitmapDataSrc = imageBitmapSrc.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            //lock dados bitmap destino
            BitmapData bitmapDataDst = imageBitmapDest.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int padding = bitmapDataSrc.Stride - (width * pixelSize);

            unsafe
            {
                byte* src = (byte*)bitmapDataSrc.Scan0.ToPointer();
                byte* dst = (byte*)bitmapDataDst.Scan0.ToPointer();

                int r, g, b;
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        b = *(src++); //está armazenado dessa forma: b g r 
                        g = *(src++);
                        r = *(src++);
                        gs = (Int32)(r * 0.2990 + g * 0.5870 + b * 0.1140);
                        *(dst++) = (byte)gs;
                        *(dst++) = (byte)gs;
                        *(dst++) = (byte)gs;
                    }
                    src += padding;
                    dst += padding;
                }
            }
            //unlock imagem origem
            imageBitmapSrc.UnlockBits(bitmapDataSrc);
            //unlock imagem destino
            imageBitmapDest.UnlockBits(bitmapDataDst);
        }

        //com acesso direito a memoria
        public static void negativoDMA(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
        {
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;
            int pixelSize = 3;

            //lock dados bitmap origem 
            BitmapData bitmapDataSrc = imageBitmapSrc.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            //lock dados bitmap destino
            BitmapData bitmapDataDst = imageBitmapDest.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int padding = bitmapDataSrc.Stride - (width * pixelSize);

            unsafe
            {
                byte* src1 = (byte*)bitmapDataSrc.Scan0.ToPointer();
                byte* dst = (byte*)bitmapDataDst.Scan0.ToPointer();

                int r, g, b;
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        b = *(src1++); //está armazenado dessa forma: b g r 
                        g = *(src1++);
                        r = *(src1++);

                        *(dst++) = (byte)(255 - b);
                        *(dst++) = (byte)(255 - g);
                        *(dst++) = (byte)(255 - r);
                    }
                    src1 += padding;
                    dst += padding;
                }
            }
            //unlock imagem origem 
            imageBitmapSrc.UnlockBits(bitmapDataSrc);
            //unlock imagem destino
            imageBitmapDest.UnlockBits(bitmapDataDst);
        }
        public static HSI[,] rgbToHsiDMA(Bitmap imageBitmap)
        {
            int width = imageBitmap.Width;
            int height = imageBitmap.Height;
            HSI[,] hsi = new HSI[width, height];
            int pixelSize = 3;

            BitmapData bitmapData = imageBitmap.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            int padding = bitmapData.Stride - (width * pixelSize);

            unsafe
            {
                byte* src = (byte*)bitmapData.Scan0.ToPointer();

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        int b = *(src++);
                        int g = *(src++);
                        int r = *(src++);

                        float normR = (float)r / (r + g + b);
                        float normG = (float)g / (r + g + b);
                        float normB = (float)b / (r + g + b);

                        float h = (float)Math.Acos((0.5 * ((r - g) + (r - b))) / Math.Sqrt((r - g) * (r - g) + (r - b) * (g - b)));
                        if (b > g)
                        {
                            h = (float)(2 * Math.PI - h);
                        }

                        float s = 1 - 3 * Math.Min(Math.Min(normR, normG), normB);
                        float i = (float)(r + g + b) / (3 * 255);

                        int H = (int)(h * 180 / Math.PI);
                        int S = (int)(s * 100);
                        int I = (int)(i * 255);

                        hsi[x, y] = new HSI(H, S, I);
                    }
                    src += padding;
                }
            }

            imageBitmap.UnlockBits(bitmapData);
            return hsi;
        }

        public static void SetBrightness(Bitmap imageBitmap, Bitmap imgDest, int porc)
        {
            if (imageBitmap == null || imgDest == null)
                throw new ArgumentNullException("Bitmaps não podem ser nulos.");

            int width = imageBitmap.Width;
            int height = imageBitmap.Height;

            Rectangle rect = new Rectangle(0, 0, width, height);
            BitmapData srcData = imageBitmap.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            BitmapData destData = imgDest.LockBits(rect, ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            int bytesPerPixel = 3;
            int stride = srcData.Stride;
            IntPtr srcPtr = srcData.Scan0;
            IntPtr destPtr = destData.Scan0;

            unsafe
            {
                byte* src = (byte*)srcPtr;
                byte* dest = (byte*)destPtr;

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width * bytesPerPixel; x++)
                    {
                        int pixelValue = src[x] + (src[x] * porc / 100);
                        dest[x] = (byte)Math.Max(0, Math.Min(255, pixelValue));
                    }
                    src += stride;
                    dest += stride;
                }
            }

            imageBitmap.UnlockBits(srcData);
            imgDest.UnlockBits(destData);
        }

        public static void SetHue(Bitmap imageBitmap, Bitmap imgDest, int hue)
        {
            if (imageBitmap == null || imgDest == null)
                throw new ArgumentNullException("Bitmaps não podem ser nulos.");

            int width = imageBitmap.Width;
            int height = imageBitmap.Height;

            Rectangle rect = new Rectangle(0, 0, width, height);
            BitmapData srcData = imageBitmap.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            BitmapData destData = imgDest.LockBits(rect, ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            int bytesPerPixel = 3;
            int stride = srcData.Stride;
            IntPtr srcPtr = srcData.Scan0;
            IntPtr destPtr = destData.Scan0;

            unsafe
            {
                byte* src = (byte*)srcPtr;
                byte* dest = (byte*)destPtr;

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width * bytesPerPixel; x += 3)
                    {
                        Color pixelColor = Color.FromArgb(src[x + 2], src[x + 1], src[x]);
                        float h, s, v;
                        RgbToHsv(pixelColor, out h, out s, out v);
                        h = (h + hue) % 360;
                        if (h < 0) h += 360;
                        Color newColor = HsvToRgb(h, s, v);
                        dest[x] = newColor.B;
                        dest[x + 1] = newColor.G;
                        dest[x + 2] = newColor.R;
                    }
                    src += stride;
                    dest += stride;
                }
            }

            imageBitmap.UnlockBits(srcData);
            imgDest.UnlockBits(destData);
        }

        private static void RgbToHsv(Color color, out float hue, out float saturation, out float value)
        {
            float r = color.R / 255f;
            float g = color.G / 255f;
            float b = color.B / 255f;

            float max = Math.Max(r, Math.Max(g, b));
            float min = Math.Min(r, Math.Min(g, b));

            hue = color.GetHue();
            saturation = max == 0 ? 0 : (max - min) / max;
            value = max;
        }

        private static Color HsvToRgb(float hue, float saturation, float value)
        {
            int hi = (int)(hue / 60) % 6;
            float f = (hue / 60) - (int)(hue / 60);
            float p = value * (1 - saturation);
            float q = value * (1 - f * saturation);
            float t = value * (1 - (1 - f) * saturation);

            float r = 0, g = 0, b = 0;
            switch (hi)
            {
                case 0: r = value; g = t; b = p; break;
                case 1: r = q; g = value; b = p; break;
                case 2: r = p; g = value; b = t; break;
                case 3: r = p; g = q; b = value; break;
                case 4: r = t; g = p; b = value; break;
                case 5: r = value; g = p; b = q; break;
            }

            return Color.FromArgb((int)(r * 255), (int)(g * 255), (int)(b * 255));
        }
    }
}
