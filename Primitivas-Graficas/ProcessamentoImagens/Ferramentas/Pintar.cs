using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessamentoImagens
{
    class Pintar
    {
        public static Bitmap Desenhar(Bitmap img, int x, int y, Color cor)
        {
            if (x >= 0 && x < img.Width && y >= 0 && y < img.Height)
                img.SetPixel(x, y, cor);
                        
            return img;
        }
    }
}
