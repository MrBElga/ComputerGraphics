using ProcessamentoImagens._2D;
using ProcessamentoImagens.Tools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessamentoImagens.Ferramentas
{
    class ScanLine
    {
        private Poligono polígono;
        private List<List<Aresta>> ET;
        private List<Aresta> AET;

        public ScanLine(Poligono p)
        {
            this.polígono = p;
        }

        private int ObterMaxY()
        {
            int m = 0;
            for (int i = 0; i < polígono.Vertices.Count; i++)
                m = Math.Max(m, polígono.Vertices[i].Y);
            return m;
        }

        private void InitET(int maxY)
        {
            for (int i = 0; i < maxY + 1; i++)
                this.ET.Add(new List<Aresta>());
        }

        private int ObterPrimeiroNãoVazio()
        {
            bool flag = true;
            int i;
            for (i = 0; i < ET.Count && flag; i++)
                flag = ET[i].Count == 0;
            return i - 1;
        }

        private void RemoverMaxEqualY(int y)
        {
            ArrayList remover = new ArrayList();
            foreach (Aresta arr in this.AET)
                if (arr.MaxY == y)
                    remover.Add(arr);
            foreach (Aresta arr in remover)
                this.AET.Remove(arr);
        }

        private void AtualizarX()
        {
            foreach (Aresta arr in this.AET)
                arr.Adicionar();
        }

        private void AdicionarAET(int index)
        {
            List<Aresta> lista = ET[index];
            foreach (Aresta arr in lista)
                this.AET.Add(arr);
        }

        private void ConstruirET()
        {
            this.ET = new List<List<Aresta>>();
            this.InitET(this.ObterMaxY());
            int maxY, minY, maxX, minX;
            double inc, dx, dy;
            for (int i = 0; i < this.polígono.Vertices.Count - 1; i++)
            {
                if (this.polígono.Vertices[i].Y > this.polígono.Vertices[i + 1].Y)
                {
                    maxX = this.polígono.Vertices[i].X;
                    minX = this.polígono.Vertices[i + 1].X;
                    maxY = this.polígono.Vertices[i].Y;
                    minY = this.polígono.Vertices[i + 1].Y;
                }
                else
                {
                    maxX = this.polígono.Vertices[i + 1].X;
                    minX = this.polígono.Vertices[i].X;
                    maxY = this.polígono.Vertices[i + 1].Y;
                    minY = this.polígono.Vertices[i].Y;
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
            if (this.polígono.Vertices.Count > 2)
            {
                if (this.polígono.Vertices[0].Y > this.polígono.Vertices[this.polígono.Vertices.Count - 1].Y)
                {
                    maxX = this.polígono.Vertices[0].X;
                    minX = this.polígono.Vertices[this.polígono.Vertices.Count - 1].X;
                    maxY = this.polígono.Vertices[0].Y;
                    minY = this.polígono.Vertices[this.polígono.Vertices.Count - 1].Y;
                }
                else
                {
                    maxX = this.polígono.Vertices[this.polígono.Vertices.Count - 1].X;
                    minX = this.polígono.Vertices[0].X;
                    maxY = this.polígono.Vertices[this.polígono.Vertices.Count - 1].Y;
                    minY = this.polígono.Vertices[0].Y;
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

        private void Preencher(Color cor, BitmapData data)
        {
            int y;
            this.ConstruirET();
            Aresta arr1, arr2;
            this.AET = new List<Aresta>();
            int pc = this.ObterPrimeiroNãoVazio();
            this.AdicionarAET(pc);
            y = pc;
            try
            {
                while (y < this.ET.Count - 1 || this.AET.Count > 0)
                {
                    this.RemoverMaxEqualY(y);
                    AET.Sort((o1, o2) =>
                        (o1.MinX == o2.MinX) ?
                        (o1.IncX.CompareTo(o2.IncX)) :
                        (o1.MinX.CompareTo(o2.MinX)));
                    for (int i = 0; i < this.AET.Count - 1; i += 2)
                    {
                        arr1 = this.AET[i];
                        arr2 = this.AET[i + 1];
                        for (double x = arr1.MinX; x < arr2.MinX; x++)
                            this.SetPixel((int)x, y, cor, data);
                    }
                    this.AtualizarX();
                    y++;
                    AET.Sort((o1, o2) =>
                        (o1.MinX == o2.MinX) ?
                        (o1.IncX.CompareTo(o2.IncX)) :
                        (o1.MinX.CompareTo(o2.MinX)));
                    this.AdicionarAET(y);
                }
            }
            catch (Exception ex)
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

        public Bitmap Preencher(Color cor, Bitmap img)
        {
            int largura = img.Width;
            int altura = img.Height;
            BitmapData data = img.LockBits(new Rectangle(0, 0, largura, altura),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                this.Preencher(cor, data);
            }
            img.UnlockBits(data);
            return img;
        }
    }
}

