using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessamentoImagens.Tools
{
    class Aresta
    {
        private double maxY;
        private double minX;
        private double incX;

        public double MaxY { get => this.maxY; set => this.maxY = value; }
        public double MinX { get => this.minX; set => this.minX = value; }
        public double IncX { get => this.incX; set => this.incX = value; }

        public Aresta(double maxY, double minX, double incX)
        {
            this.maxY = maxY;
            this.minX = minX;
            this.incX = incX;
        }

        public void Adicionar()
        {
            this.minX = Convert.ToDouble(this.minX + this.incX);
        }
    }
}
