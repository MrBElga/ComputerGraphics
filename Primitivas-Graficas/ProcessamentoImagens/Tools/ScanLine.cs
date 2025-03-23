using ProcessamentoImagens._2D;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessamentoImagens.Tools
{
    class ScanLine
    {
        private Polygon poly;
        private List<List<Aresta>> ET;
        private List<Aresta> AET;

        public ScanLine(Polygon p)
        {
            this.poly = p;
        }

        private int GetMaxY()
        {
            int m = 0;
            for (int i = 0; i < poly.Vertices.Count; i++)
                m = Math.Max(m, poly.Vertices[i].Y);
            return m;
        }

        private void InitET(int maxY)
        {
            for(int i = 0; i < maxY + 1; i++)
                this.ET.Add(new List<Aresta>());
        }

        private int GetFirtsNotEmpty()
        {
            bool flag = true;
            int i;
            for (i = 0; i < ET.Count && flag; i++)
                flag = ET[i].Count == 0;
            return i - 1;
        }

        private void RemoveMaxEqualY(int y)
        {
            ArrayList remove = new ArrayList();
            foreach (Aresta arr in this.AET)
                if (arr.MaxY == y)
                    remove.Add(arr);
            foreach (Aresta arr in remove)
                this.AET.Remove(arr);
        }

        private void AttX()
        {
            foreach (Aresta arr in this.AET)
                arr.Add();
        }

        private void AddAET(int index)
        {
            List<Aresta> list = ET[index];
            foreach (Aresta arr in list)
                this.AET.Add(arr);
        }

        private void BuildET()
        {
            this.ET = new List<List<Aresta>>();
            this.InitET(this.GetMaxY());
            int maxY, minY, maxX, minX;
            double inc, dx, dy;
            for(int i = 0; i < this.poly.Vertices.Count - 1; i++)
            {
                if(this.poly.Vertices[i].Y > this.poly.Vertices[i + 1].Y)
                {
                    maxX = this.poly.Vertices[i].X;
                    minX = this.poly.Vertices[i + 1].X;
                    maxY = this.poly.Vertices[i].Y;
                    minY = this.poly.Vertices[i + 1].Y;
                }
                else
                {
                    maxX = this.poly.Vertices[i + 1].X;
                    minX = this.poly.Vertices[i].X;
                    maxY = this.poly.Vertices[i + 1].Y;
                    minY = this.poly.Vertices[i].Y;
                }
                //
                dx = maxX - minX;
                dy = maxY - minY;
                inc = dx / dy;
                //
                if(double.IsInfinity(inc))
                {
                    inc = 1;
                }
                Aresta arr = new Aresta(maxY, minX, inc);
                this.ET[minY].Add(arr);
            }
            if(this.poly.Vertices.Count > 2)
            {
                if (this.poly.Vertices[0].Y > this.poly.Vertices[this.poly.Vertices.Count - 1].Y)
                {
                    maxX = this.poly.Vertices[0].X;
                    minX = this.poly.Vertices[this.poly.Vertices.Count - 1].X;
                    maxY = this.poly.Vertices[0].Y;
                    minY = this.poly.Vertices[this.poly.Vertices.Count - 1].Y;
                }
                else
                {
                    maxX = this.poly.Vertices[this.poly.Vertices.Count - 1].X;
                    minX = this.poly.Vertices[0].X;
                    maxY = this.poly.Vertices[this.poly.Vertices.Count - 1].Y;
                    minY = this.poly.Vertices[0].Y;
                }
                //
                dx = maxX - minX;
                dy = maxY - minY;
                inc = dx / dy;
                //
                if (double.IsInfinity(inc))
                {
                    inc = 1;
                }
                Aresta arr = new Aresta(maxY, minX, inc);
                this.ET[minY].Add(arr);
            }
        }

        private void Fill(Color cor, BitmapData data)
        {
            int y;
            this.BuildET();
            Aresta arr1, arr2;
            this.AET = new List<Aresta>();
            int pc = this.GetFirtsNotEmpty();
            this.AddAET(pc);
            y = pc;
            try
            {
                while(y < this.ET.Count - 1 || this.AET.Count > 0)
                {
                    this.RemoveMaxEqualY(y);
                    AET.Sort((o1, o2) => 
                        (o1.MinX == o2.MinX) ? 
                        (o1.IncX.CompareTo(o2.IncX)) : 
                        (o1.MinX.CompareTo(o2.MinX)));
                    for(int i = 0; i < this.AET.Count - 1; i += 2)
                    {
                        arr1 = this.AET[i];
                        arr2 = this.AET[i + 1];
                        for (double x = arr1.MinX; x < arr2.MinX; x++)
                            this.SetPixel((int)x, y, cor, data);
                    }
                    this.AttX();
                    y++;
                    AET.Sort((o1, o2) =>
                        (o1.MinX == o2.MinX) ?
                        (o1.IncX.CompareTo(o2.IncX)) :
                        (o1.MinX.CompareTo(o2.MinX)));
                    this.AddAET(y);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void SetPixel(int x, int y, Color cor, BitmapData data)
        {
            int stride = data.Stride;
            unsafe
            {
                byte* pointer = (byte*)data.Scan0.ToPointer();
                byte* init = pointer;
                pointer = (byte*)(init + (y * stride) + (x * 3));
                *(pointer++) = cor.B;
                *(pointer++) = cor.G;
                *(pointer++) = cor.R;
            }
        }

        public Color GetPixel(int x, int y, BitmapData data)
        {
            int stride = data.Stride;
            int[] p = new int[3];
            unsafe
            {
                byte* pointer = (byte*)data.Scan0.ToPointer();
                byte* init = pointer;
                pointer = (byte*)(init + (y * stride) + (x * 3));
                p[0] = *(pointer++);
                p[1] = *(pointer++);
                p[2] = *(pointer++);
            }
            return Color.FromArgb(p[0], p[1], p[2]);
        }

        public Bitmap Fill(Color cor, Bitmap img)
        {
            int width = img.Width;
            int height = img.Height;
            BitmapData data = img.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                this.Fill(cor, data);
            }
            img.UnlockBits(data);
            return img;
        }
    }
}
