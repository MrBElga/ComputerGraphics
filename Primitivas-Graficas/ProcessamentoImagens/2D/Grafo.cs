using ProcessamentoImagens.Desenhos;
using System.Drawing;

namespace ProcessamentoImagens._2D
{
    class Grafo
    {
        private Point _origem;
        private Point _destino;
        private string _descricao;
        private string _nome;
        private string _algoritmo;

        public Grafo(int x1, int y1, int x2, int y2, string nome, string algoritmo)
        {
            Origem = new Point(x1, y1);
            Destino = new Point(x2, x2);
            Nome = nome;
            Algoritmo = algoritmo;
            Descricao = $"{Nome}: ({x1},{y1})({x2},{y2}) - {Algoritmo}";
        }

        public Point Origem
        {
            get => _origem;
            set => _origem = value;
        }

        public Point Destino
        {
            get => _destino;
            set => _destino = value;
        }

        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }

        public string Algoritmo
        {
            get => _algoritmo;
            set => _algoritmo = value;
        }

        public string Descricao
        {
            get => _descricao;
            set => _descricao = value;
        }

        public void DefinirOrigem(int x, int y)
        {
            Origem = new Point(x, y);
        }

        public void DefinirDestino(int x, int y)
        {
            Destino = new Point(x, y);
        }

        public Bitmap Redesenhar(Bitmap img, Color cor)
        {
            Bitmap bitmap = new Bitmap(img);
            switch (Nome)
            {
                case "Reta":
                    switch (Algoritmo)
                    {
                        case "Real":
                            bitmap = DesenharLinha.LinhaReal(bitmap, Origem.X, Origem.Y, Destino.X, Destino.Y, cor);
                            break;

                        case "DDA":
                            bitmap = DesenharLinha.DDA(bitmap, Origem.X, Origem.Y, Destino.X, Destino.Y, cor);
                            break;

                        case "Bresenham":
                            bitmap = DesenharLinha.Bresenham(bitmap, Origem.X, Origem.Y, Destino.X, Destino.Y, cor);
                            break;
                    }
                    break;

                case "Circunferência":
                    switch (Algoritmo)
                    {
                        case "Real":
                            bitmap = DesenharCirculo.CírculoReal(bitmap, Origem.X, Origem.Y, Destino.X, Destino.Y, cor);
                            break;

                        case "Trigonometria":
                            bitmap = DesenharCirculo.Trigonometria(bitmap, Origem.X, Origem.Y, Destino.X, Destino.Y, cor);
                            break;

                        case "Ponto Médio":
                            bitmap = DesenharCirculo.PontoMedio(bitmap, Origem.X, Origem.Y, Destino.X, Destino.Y, cor);
                            break;
                    }
                    break;

                case "Elipse":
                    bitmap = DesenharElipse.PontoMedio(bitmap, Origem.X, Origem.Y, Destino.X, Destino.Y, cor);
                    break;
            }
            return bitmap;
        }

        public override string ToString()
        {
            return Descricao;
        }
    }
}
