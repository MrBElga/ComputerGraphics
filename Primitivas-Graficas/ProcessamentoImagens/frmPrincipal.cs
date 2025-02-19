using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace ProcessamentoImagens
{
    public partial class frmPrincipal : Form
    {
        private Image image;
        private Bitmap imageBitmap;
        private HSI[,] hsi;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAbrirImagem_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            openFileDialog.Filter = "Arquivos de Imagem (*.jpg;*.gif;*.bmp;*.png)|*.jpg;*.gif;*.bmp;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(openFileDialog.FileName);
                pictBoxImg.Image = image;
                pictBoxImg.SizeMode = PictureBoxSizeMode.Normal;
                imageBitmap = (Bitmap)image;
                hsi = rgbToHsi();
            }
        }

        private HSI[,] rgbToHsi()
        {
            int height = image.Height;
            int width = image.Width;
            HSI[,] hsi = new HSI[width, height];
            for (int y = 0; y < height; y++) {
                for (int x = 0; x < width; x++)
                {
                    int r = imageBitmap.GetPixel(x, y).R;
                    int g = imageBitmap.GetPixel(x, y).G;
                    int b = imageBitmap.GetPixel(x, y).B;

                    float normR = (float)r / (r + g + b);
                    float normG = (float)g / (r + g + b);
                    float normB = (float)b / (r + g + b);

                    float h = (float)Math.Acos((0.5 * ((r - g) + (r - b))) / Math.Sqrt((r - g) * (r - g) + (r - b) * (g - b)));
                    if(b>g)
                    {
                        h = (float)(2 * Math.PI - h);
                    }

                    float s = 1 - 3 * Math.Min(Math.Min(normR, normG), normB);

                    float i = (float)(r + g + b) / (3*255);

                    int H = (int)(h * 180 / Math.PI);
                    int S = (int)(s * 100);
                    int I = (int)(i * 255);

                    hsi[x, y] = new HSI(H, S, I);
                }
            }
            return hsi;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            pictBoxImg.Image = null;
        }

        private void btnLuminanciaComDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.convert_to_grayDMA(imageBitmap, imgDest);
            pictBoxImg.Image = imgDest;
        }

        private void btnNegativoComDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.negativoDMA(imageBitmap, imgDest);
            pictBoxImg.Image = imgDest;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; // Define a janela como maximizada
        }


    }
}
