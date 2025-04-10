using ProcessamentoImagens.Draws;
using System;
using System.Drawing;

namespace ProcessamentoImagens._2D
{
    class Graph
    {
        private Point _source;
        private Point _destination;
        private string _description;
        private string _name;
        private string _algorithm;

        public Graph(int x1, int y1, int x2, int y2, string name, string algorithm)
        {
            Source = new Point(x1, y1);
            Destination = new Point(x2, y2);
            Name = name;
            Algorithm = algorithm;
            Description = $"{Name}: ({x1},{y1})({x2},{y2}) - {Algorithm}";
        }

        public void SetSource(int x, int y)
        {
            Source = new Point(x, y);
        }

        public void SetDestination(int x, int y)
        {
            Destination = new Point(x, y);
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Algorithm
        {
            get => _algorithm;
            set => _algorithm = value;
        }

        public Point Source
        {
            get => _source;
            set => _source = value;
        }

        public Point Destination
        {
            get => _destination;
            set => _destination = value;
        }

        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public Bitmap ReDraw(Bitmap img, Color color)
        {
            Bitmap bitmap = new Bitmap(img);
            switch (Name)
            {
                case "Reta":
                    switch (Algorithm)
                    {
                        case "Real":
                            bitmap = DrawLine.RealLine(bitmap, Source.X, Source.Y, Destination.X, Destination.Y, color);
                            break;

                        case "DDA":
                            bitmap = DrawLine.DDA(bitmap, Source.X, Source.Y, Destination.X, Destination.Y, color);
                            break;

                        case "Bresenham":
                            bitmap = DrawLine.Bresenham(bitmap, Source.X, Source.Y, Destination.X, Destination.Y, color);
                            break;
                    }
                    break;

                case "Circunferência":
                    switch (Algorithm)
                    {
                        case "Real":
                            bitmap = DrawCircle.RealCircle(bitmap, Source.X, Source.Y, Destination.X, Destination.Y, color);
                            break;

                        case "Trigonometria":
                            bitmap = DrawCircle.Trigonometry(bitmap, Source.X, Source.Y, Destination.X, Destination.Y, color);
                            break;

                        case "Ponto Médio":
                            bitmap = DrawCircle.Midpoint(bitmap, Source.X, Source.Y, Destination.X, Destination.Y, color);
                            break;
                    }
                    break;

                case "Elipse":
                    bitmap = DrawEllipse.Midpoint(bitmap, Source.X, Source.Y, Destination.X, Destination.Y, color);
                    break;
            }
            return bitmap;
        }

        public override string ToString()
        {
            return Description;
        }
    }
}