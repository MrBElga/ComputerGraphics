using System;
using System.Drawing;

namespace ProcessamentoImagens.Draws
{
    class DrawEllipse
    {
        public static Bitmap Midpoint(Bitmap img, int x1, int y1, int x2, int y2, Color cor)
        {
            Bitmap btm = new Bitmap(img);

            double cx = x1;
            double cy = y1;

            double rx = Math.Abs(x2 - x1);
            double ry = Math.Abs(y2 - y1);

            double x = 0;
            double y = ry;

            double d1 = Math.Pow(ry, 2) - Math.Pow(rx, 2) * ry + Math.Pow(rx, 2) / 4;
            double dx = 2 * Math.Pow(ry, 2) * x;
            double dy = 2 * Math.Pow(rx, 2) * y;

            while (dx < dy)
            {
                DrawEllipse.Draw(btm, (int)Math.Round(x), (int)Math.Round(y), (int)Math.Round(cx), (int)Math.Round(cy), cor);
                if (d1 < 0)
                {
                    x++;
                    dx += 2 * Math.Pow(ry, 2);
                    d1 += dx + Math.Pow(ry, 2);
                }
                else
                {
                    x++;
                    y--;
                    dx += 2 * Math.Pow(ry, 2);
                    dy -= 2 * Math.Pow(rx, 2);
                    d1 += dx - dy + Math.Pow(ry, 2);
                }
            }

            double d2 = (Math.Pow(ry, 2) * ((x + 0.5) * (x + 0.5))) 
                + (Math.Pow(rx, 2) * ((y - 1) * (y - 1))) 
                - Math.Pow(rx, 2) * Math.Pow(ry, 2);

            while (y >= 0)
            {
                DrawEllipse.Draw(btm, (int)Math.Round(x), (int)Math.Round(y), (int)Math.Round(cx), (int)Math.Round(cy), cor);
                if (d2 > 0)
                {
                    y--;
                    dy -= 2 * Math.Pow(rx, 2);
                    d2 += Math.Pow(rx, 2) - dy;
                }
                else
                {
                    y--;
                    x++;
                    dx += 2 * Math.Pow(ry, 2);
                    dy -= 2 * Math.Pow(rx, 2);
                    d2 += dx - dy + Math.Pow(rx, 2);
                }
            }
            return btm;
        }

        public static Bitmap Draw(Bitmap img, int x, int y, int cx, int cy, Color cor)
        {
            if (x + cx > 0 && x + cx < img.Width && y + cy > 0 && y + cy < img.Height)
                Paint.Draw(img, x + cx, y + cy, cor);
            if (NEG(x) + cx > 0 && NEG(x) + cx < img.Width && y + cy > 0 && y + cy < img.Height)
                Paint.Draw(img, NEG(x) + cx, y + cy, cor);
            if (x + cx > 0 && x + cx < img.Width && NEG(y) + cy > 0 && NEG(y) + cy < img.Height)
                Paint.Draw(img, x + cx, NEG(y) + cy, cor);
            if (NEG(x) + cx > 0 && NEG(x) + cx < img.Width && NEG(y) + cy > 0 && NEG(y) + cy < img.Height)
                Paint.Draw(img, NEG(x) + cx, NEG(y) + cy, cor);
            return img;
        }

        public static int NEG(int n)
        {
            return n * -1;
        }
    }
}
