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
    class Poligono
    {
        private List<Point> vertices;

        public Poligono()
        {
            this.vertices = new List<Point>();
        }

        public List<Point> Vertices { get => this.vertices; set => this.vertices = value; }

        public void AdicionarVértice(int x, int y)
        {
            this.vertices.Add(new Point(x, y));
        }

        public void DefinirPixel(int x, int y, Color cor, BitmapData dados)
        {
            int stride = dados.Stride;
            unsafe
            {
                byte* ponteiro = (byte*)dados.Scan0.ToPointer();
                byte* início = ponteiro;
                ponteiro = (byte*)(início + (y * stride) + (x * 3));
                *(ponteiro++) = cor.B;
                *(ponteiro++) = cor.G;
                *(ponteiro++) = cor.R;
            }
        }

        public Color ObterPixel(int x, int y, BitmapData dados)
        {
            int stride = dados.Stride;
            int[] p = new int[3];
            unsafe
            {
                byte* ponteiro = (byte*)dados.Scan0.ToPointer();
                byte* início = ponteiro;
                ponteiro = (byte*)(início + (y * stride) + (x * 3));
                p[0] = *(ponteiro++);
                p[1] = *(ponteiro++);
                p[2] = *(ponteiro++);
            }
            return Color.FromArgb(p[0], p[1], p[2]);
        }

        public Bitmap Apagar(Bitmap img)
        {
            return this.ReDesenhar(img, Color.White);
        }

        public Bitmap PolígonoTerminado(Bitmap img, Color cor)
        {
            img = Desenhos.DesenharLinha.DDA(img,
                this.vertices[this.vertices.Count - 1].X,
                this.vertices[this.vertices.Count - 1].Y,
                this.vertices[0].X,
                this.vertices[0].Y,
                cor);
            return img;
        }

        public Bitmap ReDesenhar(Bitmap img, Color cor, bool terminado = true)
        {
            for (int i = 0; i < this.vertices.Count - 1; i++)
                img = Desenhos.DesenharLinha.DDA(img,
                    this.vertices[i].X,
                    this.vertices[i].Y,
                    this.vertices[i + 1].X,
                    this.vertices[i + 1].Y,
                    cor);
            return (terminado) ? this.PolígonoTerminado(img, cor) : img;
        }

        public Point ObterSemente()
        {
            double xmed = 0;
            double ymed = 0;
            int contagem = 0;

            for (int i = 0; i < this.vertices.Count - 1; i++)
            {
                Point p = new Point(
                    (this.vertices[i].X + this.vertices[i + 1].X) / 2,
                    (this.vertices[i].Y + this.vertices[i + 1].Y) / 2
                );
                xmed += p.X;
                ymed += p.Y;
                contagem++;
            }
            xmed += (this.vertices[this.vertices.Count - 1].X + this.vertices[0].X) / 2;
            ymed += (this.vertices[this.vertices.Count - 1].Y + this.vertices[0].Y) / 2;
            contagem++;
            xmed /= contagem;
            ymed /= contagem;
            return new Point((int)xmed, (int)ymed);
        }

        public Bitmap Rotação(Bitmap img, Color cor, int angle)
        {
            img = this.Apagar(img);
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
                double[] M = Matriz.Homogenar(M1, M2);
                this.vertices[i] = new Point((int)M[0], (int)M[1]);
            }
            return this.ReDesenhar(img, cor);
        }

        public Bitmap Preenchimento(Bitmap img, Color dentro)
        {
            int largura = img.Width;
            int altura = img.Height;
            BitmapData dados = img.LockBits(new Rectangle(0, 0, img.Width, img.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                Stack<Point> pilha = new Stack<Point>();
                Color fundo = this.ObterPixel(this.ObterSemente().X, this.ObterSemente().Y, dados);
                pilha.Push(this.ObterSemente());
                while (pilha.Count > 0)
                {
                    Point p = pilha.Pop();
                    if (p.X < largura && p.X > 0 && p.Y < altura && p.Y > 0)
                    {
                        Color cor = this.ObterPixel(p.X, p.Y, dados);
                        if (cor == fundo)
                        {
                            this.DefinirPixel(p.X, p.Y, dentro, dados);
                            pilha.Push(new Point(p.X + 1, p.Y));
                            pilha.Push(new Point(p.X, p.Y + 1));
                            pilha.Push(new Point(p.X - 1, p.Y));
                            pilha.Push(new Point(p.X, p.Y - 1));
                        }
                    }
                }
            }
            img.UnlockBits(dados);
            return img;
        }

        public Bitmap Translação(Bitmap img, Color cor, Point p)
        {
            img = this.Apagar(img);
            double[][] M1 = new double[3][];
            M1[0] = new double[3];
            M1[1] = new double[3];
            M1[2] = new double[3];
            M1[0][0] = 1; M1[0][1] = 0; M1[0][2] = p.X;
            M1[1][0] = 0; M1[1][1] = 1; M1[1][2] = p.Y;
            M1[2][0] = 0; M1[2][1] = 0; M1[2][2] = 1;
            
            for (int i = 0; i < this.vertices.Count; i++)
            {
                double[] M2 = new double[3];
                M2[0] = this.vertices[i].X;
                M2[1] = this.vertices[i].Y;
                M2[2] = 1;
                double[] M = Matriz.Homogenar(M1, M2);
                this.vertices[i] = new Point((int)M[0], (int)M[1]);
            }
            return this.ReDesenhar(img, cor);
        }

        public Bitmap Translação(Bitmap img, Color cor, int desloc)
        {
            img = this.Apagar(img);
            double[][] M1 = new double[3][];
            M1[0] = new double[3];
            M1[1] = new double[3];
            M1[2] = new double[3];
            M1[0][0] = 1; M1[0][1] = 0; M1[0][2] = desloc;
            M1[1][0] = 0; M1[1][1] = 1; M1[1][2] = desloc;
            M1[2][0] = 0; M1[2][1] = 0; M1[2][2] = 1;
            
            for (int i = 0; i < this.vertices.Count; i++)
            {
                double[] M2 = new double[3];
                M2[0] = this.vertices[i].X;
                M2[1] = this.vertices[i].Y;
                M2[2] = 1;
                double[] M = Matriz.Homogenar(M1, M2);
                this.vertices[i] = new Point((int)M[0], (int)M[1]);
            }
            return this.ReDesenhar(img, cor);
        }

        public Bitmap Cisalharmento(Bitmap img, Color cor, int alfa, int beta)
        {
            img = this.Apagar(img);
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
                double[] M = Matriz.Homogenar(M1, M2);
                this.vertices[i] = new Point((int)M[0], (int)M[1]);
            }
            return this.ReDesenhar(img, cor);
        }

        public Bitmap Escalar(Bitmap img, Color cor, double scala)
        {
            img = this.Apagar(img);
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
                double[] M = Matriz.Homogenar(M1, M2);
                this.vertices[i] = new Point((int)M[0], (int)M[1]);
            }
            return this.ReDesenhar(img, cor);
        }

        public Bitmap Escalar(Bitmap img, Color cor, double x, double y)
        {
            img = this.Apagar(img);
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
                double[] M = Matriz.Homogenar(M1, M2);
                this.vertices[i] = new Point((int)M[0], (int)M[1]);
            }
            return this.ReDesenhar(img, cor);
        }

        public Bitmap Espelhar(Bitmap img, Color cor, int flipx = 1, int flipy = 1)
        {
            img = this.Apagar(img);
            double[][] M1 = new double[3][];
            M1[0] = new double[3];
            M1[1] = new double[3];
            M1[2] = new double[3];
            M1[0][0] = flipx; M1[0][1] = 0; M1[0][2] = 0;
            M1[1][0] = 0; M1[1][1] = flipy; M1[1][2] = 0;
            M1[2][0] = 0; M1[2][1] = 0; M1[2][2] = 1;
            
            for (int i = 0; i < this.vertices.Count; i++)
            {
                double[] M2 = new double[3];
                M2[0] = this.vertices[i].X;
                M2[1] = this.vertices[i].Y;
                M2[2] = 1;
                double[] M = Matriz.Homogenar(M1, M2);
                this.vertices[i] = new Point((int)M[0], (int)M[1]);
            }
            return this.ReDesenhar(img, cor);
        }

        public Bitmap ViewPort(Bitmap img, Color cor, int largura, int altura, int _largura, int _altura)
        {
            img = this.Apagar(img);
            double[][] M1 = new double[3][];
            M1[0] = new double[3];
            M1[1] = new double[3];
            M1[2] = new double[3];
            M1[0][0] = (double)_largura / largura; M1[0][1] = 0; M1[0][2] = 0;
            M1[1][0] = 0; M1[1][1] = (double)_altura / altura; M1[1][2] = 0;
            M1[2][0] = 0; M1[2][1] = 0; M1[2][2] = 1;
            
            for (int i = 0; i < this.vertices.Count; i++)
            {
                double[] M2 = new double[3];
                M2[0] = this.vertices[i].X;
                M2[1] = this.vertices[i].Y;
                M2[2] = 1;
                double[] M = Matriz.Homogenar(M1, M2);
                this.vertices[i] = new Point((int)M[0], (int)M[1]);
            }
            return this.ReDesenhar(img, cor);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Point p in this.vertices)
            {
                sb.Append($"({p.X}, {p.Y}) ");
            }
            return sb.ToString();
        }

        public Poligono ObterClone()
        {
            Poligono clone = new Poligono();
            foreach (Point p in this.vertices)
            {
                clone.AdicionarVértice(p.X, p.Y);
            }
            return clone;
        }
    }
}
