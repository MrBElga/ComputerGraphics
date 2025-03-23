using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessamentoImagens
{
    class Paint
    {
        public static Bitmap Draw(Bitmap img, int x, int y, Color cor)
        {
            if (x >= 0 && x < img.Width && y >= 0 && y < img.Height)
            {
                img.SetPixel(x, y, cor);
                /*
                if (x > 0 && y > 0)
                    img.SetPixel(x - 1, y - 1, cor);
                if (y > 0)
                    img.SetPixel(x, y - 1, cor);
                if (x < img.Width - 1 && y > 0)
                    img.SetPixel(x + 1, y - 1, cor);
                if (x > 0)
                    img.SetPixel(x - 1, y, cor);
                if (x < img.Width - 1)
                    img.SetPixel(x + 1, y, cor);
                if (x > 0 && y < img.Height - 1)
                    img.SetPixel(x - 1, y + 1, cor);
                if (y < img.Height - 1)
                    img.SetPixel(x, y + 1, cor);
                if (x < img.Width - 1 && y < img.Height - 1)
                    img.SetPixel(x + 1, y + 1, cor);*/
            }
            
            return img;
        }
    }
}
