using System;
using System.Drawing;

namespace ProcessamentoImagens.Draws
{
    class DrawCircle
    {
        public static int Raio(int x1, int y1, int x2, int y2)
        {
            return (int)Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
        }

        public static Bitmap RealCircle(Bitmap img, int x1, int y1, int x2, int y2, Color cor)
        {
            Bitmap btm = new Bitmap(img);
            int raio = (int)Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
            int cx = x1;
            int cy = y1;

            for (int x = 0; x < raio; x++) {
                int y = (int)Math.Round(Math.Sqrt(Math.Pow(raio, 2) - Math.Pow(x, 2)));
                btm = DrawCircle.Draw(btm, x, y, cx, cy, cor);
            }
            return btm;
        }

        public static Bitmap Trigonometry(Bitmap img, int x1, int y1, int x2, int y2, Color cor)
        {
            Bitmap btm = new Bitmap(img);
            double angle = 45;
            int R = (int)Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
            double perimeter = 2 * Math.PI * R;
            double inc = 360 / perimeter;

            for (; angle <= 90; angle += inc)
            {
                double g = angle * Math.PI / 180;
                int x = (int)Math.Round(R * Math.Cos(g));
                int y = (int)Math.Round(R * Math.Sin(g));
                Console.WriteLine(x + " | " + y);
                btm = DrawCircle.Draw(btm, x, y, x1, y1, cor);
            }
            return btm;
        }

        public static Bitmap Midpoint(Bitmap img, int x1, int y1, int x2, int y2, Color cor)
        {
            Bitmap btm = new Bitmap(img);
            int R = (int)Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
            int x = 0;
            int y = R;
            int d = 1 - R;

            btm = DrawCircle.Draw(btm, x, y, x1, y2, cor);
            while (y > x)
            {
                if (d < 0)
                    d += 2 * x + 3;
                else
                {
                    d += 2 * (x - y) + 5;
                    y--;
                }
                x++;
                btm = DrawCircle.Draw(btm, x, y, x1, y2, cor);
            }
            return btm;
        }

        public static Bitmap Draw(Bitmap img, int x, int y, int cx, int cy, Color cor)
        {
            if (x + cx >= 0 && x + cx < img.Width && y + cy >= 0 && y + cy < img.Height)
                img = Paint.Draw(img, x + cx, y + cy, cor);             // (x, y)
            if (y + cx >= 0 && y + cx < img.Width && x + cy >= 0 && x + cy < img.Height)
                img = Paint.Draw(img, y + cx, x + cy, cor);             // (y, x)
            if (NEG(x) + cx >= 0 && NEG(x) + cx < img.Width && y + cy >= 0 && y + cy < img.Height)
                img = Paint.Draw(img, NEG(x) + cx, y + cy, cor);        // (-x, y)
            if (NEG(y) + cx >= 0 && NEG(y) + cx < img.Width && x + cy >= 0 && x + cy < img.Height)
                img = Paint.Draw(img, NEG(y) + cx, x + cy, cor);        // (-y, x)
            if (x + cx >= 0 && x + cx < img.Width && NEG(y) + cy >= 0 && NEG(y) + cy < img.Height)
                img = Paint.Draw(img, x + cx, NEG(y) + cy, cor);        // (x, -y)
            if (y + cx >= 0 && y + cx < img.Width && NEG(x) + cy >= 0 && NEG(x) + cy < img.Height)
                img = Paint.Draw(img, y + cx, NEG(x) + cy, cor);        // (y, -x)
            if (NEG(x) + cx >= 0 && NEG(x) + cx < img.Width && NEG(y) + cy >= 0 && NEG(y) + cy < img.Height)
                img = Paint.Draw(img, NEG(x) + cx, NEG(y) + cy, cor);   // (-x, -y)
            if (NEG(y) + cx >= 0 && NEG(y) + cx < img.Width && NEG(x) + cy >= 0 && NEG(x) + cy < img.Height)
                img = Paint.Draw(img, NEG(y) + cx, NEG(x) + cy, cor);   // (-y, -x)
            return img;
        }

        public static int NEG(int n)
        {
            return n * -1;
        }
    }
}
