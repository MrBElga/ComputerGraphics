using System;
using System.Drawing;
using System.Reflection;

namespace ProcessamentoImagens.Desenhos
{
    class DesenharLinha
    {
        public static Bitmap DDA(Bitmap img, int x1, int y1, int x2, int y2, Color cor)
        {
            Bitmap btm = new Bitmap(img);
            int comprimento = Math.Max(Math.Abs(x2 - x1), Math.Abs(y2 - y1));
            double xInc = (double)(x2 - x1) / comprimento;
            double yInc = (double)(y2 - y1) / comprimento;
            double x = x1;
            double y = y1;

            for (int i = 0; i <= comprimento; i++)
            {
                Pintar.Desenhar(btm, (int)Math.Round(x), (int)Math.Round(y), cor);
                x += xInc;
                y += yInc;
            }
            return btm;
        }

        public static Bitmap Bresenham(Bitmap img, int x1, int y1, int x2, int y2, Color cor)
        {
            Bitmap btm = new Bitmap(img);
            int dx = Math.Abs(x2 - x1), dy = Math.Abs(y2 - y1);
            int sx = x1 < x2 ? 1 : -1, sy = y1 < y2 ? 1 : -1;
            int err = dx - dy, x = x1, y = y1;

            while (true)
            {
                Pintar.Desenhar(btm, x, y, cor);
                if (x == x2 && y == y2) break;
                int e2 = 2 * err;
                if (e2 > -dy) { err -= dy; x += sx; }
                if (e2 < dx) { err += dx; y += sy; }
            }
            return btm;
        }

        public static Bitmap LinhaReal(Bitmap img, int x1, int y1, int x2, int y2, Color cor)
        {
            Bitmap btm = new Bitmap(img);
            double dx = x2 - x1;
            double dy = y2 - y1;
            double m = dy / dx;
            int inc = Math.Sign(dx);

            if (double.IsInfinity(m) || double.IsNaN(m)) // Linha vertical
            {
                inc = Math.Sign(dy);
                for (int y = Math.Min(y1, y2); y <= Math.Max(y1, y2); y++)
                    Pintar.Desenhar(btm, x1, y, cor);
            }
            else if (Math.Abs(dx) > Math.Abs(dy))
            {
                for (int x = x1; x != x2; x += inc)
                {
                    double y = y1 + m * (x - x1);
                    Pintar.Desenhar(btm, x, (int)Math.Round(y), cor);
                }
            }
            else
            {
                inc = Math.Sign(dy);
                for (int y = y1; y != y2; y += inc)
                {
                    double x = x1 + (y - y1) / m;
                    Pintar.Desenhar(btm, (int)Math.Round(x), y, cor);
                }
            }
            return btm;
        }
    }
}
