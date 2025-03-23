using ProcessamentoImagens.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace ProcessamentoImagens._2D
{
    class Polygon
    {
        private List<Point> vertices;

        public Polygon()
        {
            this.vertices = new List<Point>();
        }

        public List<Point> Vertices { get => this.vertices; set => this.vertices = value; }

        public void AddVertice(int x, int y)
        {
            this.vertices.Add(new Point(x, y));
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

        public Bitmap Erase(Bitmap img)
        {
            return this.ReDraw(img, Color.White);
        }

        public Bitmap TerminatedPolygon(Bitmap img, Color cor)
        {
            img = Draws.DrawLine.DDA(img,
                this.vertices[this.vertices.Count - 1].X,
                this.vertices[this.vertices.Count - 1].Y,
                this.vertices[0].X,
                this.vertices[0].Y,
                cor);
            return img;
        }

        public Bitmap ReDraw(Bitmap img, Color cor, bool terminated = true)
        {
            for (int i = 0; i < this.vertices.Count - 1; i++)
                img = Draws.DrawLine.DDA(img,
                    this.vertices[i].X,
                    this.vertices[i].Y,
                    this.vertices[i + 1].X,
                    this.vertices[i + 1].Y,
                    cor);
            return (terminated) ? this.TerminatedPolygon(img, cor) : img;
        }

        public Point GetSeed()
        {
            double xmed = 0;
            double ymed = 0;
            int count = 0;

            for (int i = 0; i < this.vertices.Count - 1; i++)
            {
                Point p = new Point(
                    (this.vertices[i].X + this.vertices[i + 1].X) / 2,
                    (this.vertices[i].Y + this.vertices[i + 1].Y) / 2
                );
                xmed += p.X;
                ymed += p.Y;
                count++;
            }
            xmed += (this.vertices[this.vertices.Count - 1].X + this.vertices[0].X) / 2;
            ymed += (this.vertices[this.vertices.Count - 1].Y + this.vertices[0].Y) / 2;
            count++;
            xmed /= count;
            ymed /= count;
            return new Point((int)xmed, (int)ymed);
        }

        public Bitmap FloodFill(Bitmap img, Color inside)
        {
            int width = img.Width;
            int height = img.Height;
            BitmapData data = img.LockBits(new Rectangle(0, 0, img.Width, img.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                Stack<Point> stack = new Stack<Point>();
                Color back = this.GetPixel(this.GetSeed().X, this.GetSeed().Y, data);
                stack.Push(this.GetSeed());
                while (stack.Count > 0)
                {
                    Point p = stack.Pop();
                    if (p.X < width && p.X > 0 && p.Y < height && p.Y > 0)
                    {
                        Color cor = this.GetPixel(p.X, p.Y, data);
                        if (cor == back)
                        {
                            this.SetPixel(p.X, p.Y, inside, data);
                            stack.Push(new Point(p.X + 1, p.Y));
                            stack.Push(new Point(p.X, p.Y + 1));
                            stack.Push(new Point(p.X - 1, p.Y));
                            stack.Push(new Point(p.X, p.Y - 1));
                        }
                    }
                }
            }
            img.UnlockBits(data);
            return img;
        }

        public Bitmap Translation(Bitmap img, Color cor, Point p)
        {
            img = this.Erase(img);
            double[][] M1 = new double[3][];
            M1[0] = new double[3];
            M1[1] = new double[3];
            M1[2] = new double[3];
            M1[0][0] = 1; M1[0][1] = 0; M1[0][2] = p.X;
            M1[1][0] = 0; M1[1][1] = 1; M1[1][2] = p.Y;
            M1[2][0] = 0; M1[2][1] = 0; M1[2][2] = 1;
            //
            for (int i = 0; i < this.vertices.Count; i++)
            {
                double[] M2 = new double[3];
                M2[0] = this.vertices[i].X;
                M2[1] = this.vertices[i].Y;
                M2[2] = 1;
                double[] M = Matrix.Homogenar(M1, M2);
                this.vertices[i] = new Point((int)M[0], (int)M[1]);
            }
            return this.ReDraw(img, cor);
        }

        public Bitmap Translation(Bitmap img, Color cor, int desloc)
        {
            img = this.Erase(img);
            double[][] M1 = new double[3][];
            M1[0] = new double[3];
            M1[1] = new double[3];
            M1[2] = new double[3];
            M1[0][0] = 1; M1[0][1] = 0; M1[0][2] = desloc;
            M1[1][0] = 0; M1[1][1] = 1; M1[1][2] = desloc;
            M1[2][0] = 0; M1[2][1] = 0; M1[2][2] = 1;
            //
            for (int i = 0; i < this.vertices.Count; i++)
            {
                double[] M2 = new double[3];
                M2[0] = this.vertices[i].X;
                M2[1] = this.vertices[i].Y;
                M2[2] = 1;
                double[] M = Matrix.Homogenar(M1, M2);
                this.vertices[i] = new Point((int)M[0], (int)M[1]);
            }
            return this.ReDraw(img, cor);
        }

        public Bitmap Scala(Bitmap img, Color cor, double scala)
        {
            img = this.Erase(img);
            double[][] M1 = new double[3][];
            M1[0] = new double[3];
            M1[1] = new double[3];
            M1[2] = new double[3];
            M1[0][0] = scala; M1[0][1] = 0; M1[0][2] = 0;
            M1[1][0] = 0; M1[1][1] = scala; M1[1][2] = 0;
            M1[2][0] = 0; M1[2][1] = 0; M1[2][2] = 1;
            //
            for (int i = 0; i < this.vertices.Count; i++)
            {
                double[] M2 = new double[3];
                M2[0] = this.vertices[i].X;
                M2[1] = this.vertices[i].Y;
                M2[2] = 1;
                double[] M = Matrix.Homogenar(M1, M2);
                this.vertices[i] = new Point((int)M[0], (int)M[1]);
            }
            return this.ReDraw(img, cor);
        }

        public Bitmap Scala(Bitmap img, Color cor, double x, double y)
        {
            img = this.Erase(img);
            double[][] M1 = new double[3][];
            M1[0] = new double[3];
            M1[1] = new double[3];
            M1[2] = new double[3];
            M1[0][0] = x; M1[0][1] = 0; M1[0][2] = 0;
            M1[1][0] = 0; M1[1][1] = y; M1[1][2] = 0;
            M1[2][0] = 0; M1[2][1] = 0; M1[2][2] = 1;
            //
            for (int i = 0; i < this.vertices.Count; i++)
            {
                double[] M2 = new double[3];
                M2[0] = this.vertices[i].X;
                M2[1] = this.vertices[i].Y;
                M2[2] = 1;
                double[] M = Matrix.Homogenar(M1, M2);
                this.vertices[i] = new Point((int)M[0], (int)M[1]);
            }
            return this.ReDraw(img, cor);
        }

        public Bitmap Rotation(Bitmap img, Color cor, int angle)
        {
            img = this.Erase(img);
            double[][] M1 = new double[3][];
            M1[0] = new double[3];
            M1[1] = new double[3];
            M1[2] = new double[3];
            M1[0][0] = Math.Cos(angle); M1[0][1] = -Math.Sin(angle); M1[0][2] = 0;
            M1[1][0] = Math.Sin(angle); M1[1][1] = Math.Cos(angle); M1[1][2] = 0;
            M1[2][0] = 0; M1[2][1] = 0; M1[2][2] = 1;
            //
            for (int i = 0; i < this.vertices.Count; i++)
            {
                double[] M2 = new double[3];
                M2[0] = this.vertices[i].X;
                M2[1] = this.vertices[i].Y;
                M2[2] = 1;
                double[] M = Matrix.Homogenar(M1, M2);
                this.vertices[i] = new Point((int)M[0], (int)M[1]);
            }
            return this.ReDraw(img, cor);
        }

        public Bitmap Shear(Bitmap img, Color cor, int alfa, int beta)
        {
            img = this.Erase(img);
            double[][] M1 = new double[3][];
            M1[0] = new double[3];
            M1[1] = new double[3];
            M1[2] = new double[3];
            M1[0][0] = 1; M1[0][1] = beta; M1[0][2] = 0;
            M1[1][0] = alfa; M1[1][1] = 1; M1[1][2] = 0;
            M1[2][0] = 0; M1[2][1] = 0; M1[2][2] = 1;
            //
            for (int i = 0; i < this.vertices.Count; i++)
            {
                double[] M2 = new double[3];
                M2[0] = this.vertices[i].X;
                M2[1] = this.vertices[i].Y;
                M2[2] = 1;
                double[] M = Matrix.Homogenar(M1, M2);
                this.vertices[i] = new Point((int)M[0], (int)M[1]);
            }
            return this.ReDraw(img, cor);
        }

        public Bitmap Mirror(Bitmap img, Color cor, int flipx = 1, int flipy = 1)
        {
            img = this.Erase(img);
            double[][] M1 = new double[3][];
            M1[0] = new double[3];
            M1[1] = new double[3];
            M1[2] = new double[3];
            M1[0][0] = flipy; M1[0][1] = 0; M1[0][2] = 0;
            M1[1][0] = 0; M1[1][1] = flipx; M1[1][2] = 0;
            M1[2][0] = 0; M1[2][1] = 0; M1[2][2] = 1;
            //
            for (int i = 0; i < this.vertices.Count; i++)
            {
                double[] M2 = new double[3];
                M2[0] = this.vertices[i].X;
                M2[1] = this.vertices[i].Y;
                M2[2] = 1;
                double[] M = Matrix.Homogenar(M1, M2);
                this.vertices[i] = new Point((int)M[0], (int)M[1]);
            }
            return this.ReDraw(img, cor);
        }

        public Bitmap ViewPort(Bitmap img, Color cor, int width, int height, int _width, int _height)
        {
            double porcx = Convert.ToDouble((double)_width / width);
            double porcy = Convert.ToDouble((double)_height / height);
            Point centro = this.GetSeed();
            double X = (double)centro.X / width;
            double Y = (double)centro.Y / height;
            int centrox = (int)X * _width;
            int centroy = (int)Y * _height;
            img = this.Translation(img, cor, new Point(-centrox, -centroy));
            img = this.Scala(img, cor, porcx, porcy);
            img = this.Translation(img, cor, new Point(centrox, centroy));
            return this.ReDraw(img, cor);
        }

        public override string ToString()
        {
            return this.GetHashCode() + " - " + this.vertices.Count + " vértices";
        }

        public Polygon GetClone()
        {
            Polygon p = new Polygon();
            foreach (Point point in this.vertices)
            {
                p.AddVertice(point.X, point.Y);
            }
            return p;
        }
    }
}
