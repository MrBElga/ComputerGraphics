using ProcessamentoImagens.Draws;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessamentoImagens._2D
{
    class Graph
    {
        private Point source;
        private Point destiny;
        private string description;
        private string name;
        private string algorithm;

        public Graph(int x1, int y1, int x2, int y2, string name, string algorithm)
        {
            this.Source = new Point(x1, y1);
            this.Destiny = new Point(x2, y2);
            this.Name = name;
            this.Algorithm = algorithm;
            this.Description = this.Name + ": (" + x1 + "," + y1 + ")(" + x2 + "," + y2 + ") - " + this.Algorithm;
        }

        public void setSource(int x, int y)
        {
            this.source = new Point(x, y);
        }

        public void setDestiny(int x, int y)
        {
            this.destiny = new Point(x, y);
        }

        public string Name { get => this.name; set => this.name = value; }
        public string Algorithm { get => this.algorithm; set => this.algorithm = value; }
        public Point Source { get => this.source; set => this.source = value; }
        public Point Destiny { get => this.destiny; set => this.destiny = value; }
        public string Description { get => this.description; set => this.description = value; }

        public Bitmap ReDraw(Bitmap img, Color cor)
        {
            Bitmap btm = new Bitmap(img);
            switch (this.name)
            {
                case "Reta":
                    switch (this.algorithm)
                    {
                        case "Real":
                            btm = DrawLine.RealLine(btm, source.X, source.Y, destiny.X, destiny.Y, cor);
                            break;

                        case "DDA":
                            btm = DrawLine.DDA(btm, source.X, source.Y, destiny.X, destiny.Y, cor);
                            break;

                        case "Bresenham":
                            btm = DrawLine.Bresenham(btm, source.X, source.Y, destiny.X, destiny.Y, cor);
                            break;
                    }
                    break;

                case "Circunferência":
                    switch (this.algorithm)
                    {
                        case "Real":
                            btm = DrawCircle.RealCircle(btm, source.X, source.Y, destiny.X, destiny.Y, cor);
                            break;

                        case "Trigonometria":
                            btm = DrawCircle.Trigonometry(btm, source.X, source.Y, destiny.X, destiny.Y, cor);
                            break;

                        case "Ponto Médio":
                            btm = DrawCircle.Midpoint(btm, source.X, source.Y, destiny.X, destiny.Y, cor);
                            break;
                    }
                    break;

                case "Elipse":
                    btm = DrawEllipse.Midpoint(btm, source.X, source.Y, destiny.X, destiny.Y, cor);
                    break;
            }
            return btm;
        }

        public override string ToString()
        {
            return this.description;
        }
    }
}
