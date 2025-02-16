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
                hsi = Filtros.rgbToHsiDMA(imageBitmap);
            }
        }

        //sem DMA
        private HSI[,] rgbToHsiSemDMA()
        {
            int height = image.Height;
            int width = image.Width;
            HSI[,] hsi = new HSI[width, height];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int r = imageBitmap.GetPixel(x, y).R;
                    int g = imageBitmap.GetPixel(x, y).G;
                    int b = imageBitmap.GetPixel(x, y).B;

                    float Rnormalizado = (float)r / (r + g + b);
                    float Gnormalizado = (float)g / (r + g + b);
                    float Bnormalizado = (float)b / (r + g + b);

                    float h = (float)Math.Acos((0.5 * ((r - g) + (r - b))) / Math.Sqrt((r - g) * (r - g) + (r - b) * (g - b)));
                    if (b > g)
                    {
                        h = (float)(2 * Math.PI - h);
                    }

                    float s = 1 - 3 * Math.Min(Math.Min(Rnormalizado, Gnormalizado), Bnormalizado);

                    float i = (float)(r + g + b) / (3 * 255);

                    int H = (int)(h * 180 / Math.PI);
                    int S = (int)(s * 100);
                    int I = (int)(i * 255);

                    hsi[x, y] = new HSI(H, S, I);
                }
            }
            return hsi;
        }

        //com DMA
        public static HSI[,] rgbToHsi(Bitmap imageBitmap)
        {
            int width = imageBitmap.Width;
            int height = imageBitmap.Height;
            HSI[,] hsi = new HSI[width, height];
            int pixelSize = 3;

            // bloqueia os bits da imagem para acesso direto à memória
            BitmapData bitmapData = imageBitmap.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.ReadOnly,
                PixelFormat.Format24bppRgb
            );

            int stride = bitmapData.Stride;// linha em bytes
            int padding = stride - (width * pixelSize); // pad no final da linha (cada linha x 4)

            unsafe
            {
                // inicio da imagem 
                byte* src = (byte*)bitmapData.Scan0.ToPointer();

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        int b = *(src++);
                        int g = *(src++);
                        int r = *(src++);

                        // normaliza os valores de R, G, B para o intervalo [0, 1]
                        float Rnormalizado = (float)r / (r + g + b);
                        float Gnormalizado = (float)g / (r + g + b);
                        float Bnormalizado = (float)b / (r + g + b);

                        //calculo do hue
                        float h = (float)Math.Acos(
                            (0.5f * ((Rnormalizado - Gnormalizado) + (Rnormalizado - Bnormalizado)) /
                            Math.Sqrt((Rnormalizado - Gnormalizado) * (Rnormalizado - Gnormalizado) + (Rnormalizado - Bnormalizado) * (Gnormalizado - Bnormalizado))
                        ));


                        // se b<g valor correto ([0, pi])
                        // se b>g o valor deve ser ajustado para 2*PI -h ([pi, 2pi])
                        // fiz isso pq a funcao acos retorna valores entre 0 e pi (0 a 180) ent nao cobre o resto de 180 a 360
                        if (b > g)
                        {
                            h = (float)(2 * Math.PI - h); // ajuste de hue se precisar
                        }

                        // calcula a saturacao
                        float s = 1 - 3 * Math.Min(Math.Min(Rnormalizado, Gnormalizado), Bnormalizado);

                        // calcula a intensidade 
                        float i = (float)(r + g + b) / (3 * 255);

                        // convertendo os valores para o formato HSI
                        int H = (int)(h * 180 / Math.PI); // hue em graus [0, 360]
                        int S = (int)(s * 100);           // saturacao em porcentagem [0, 100]
                        int I = (int)(i * 255);           // intensidade em [0, 255]

                        hsi[x, y] = new HSI(H, S, I);
                    }
                    src += padding;
                }
            }

            // Desbloqueia os bits da imagem
            imageBitmap.UnlockBits(bitmapData);

            return hsi;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            pictBoxImg.Image = null;
        }

        private void btnLuminanciaComDMA_Click(object sender, EventArgs e)
        {
            // Verifica se a imagem foi carregada
            if (image == null)
            {
                MessageBox.Show("Por favor, abra uma imagem primeiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Cria uma cópia da imagem original
                Bitmap imgDest = new Bitmap(image);

                // Converte a imagem para Bitmap (se necessário)
                imageBitmap = (Bitmap)image;

                // Aplica o filtro de luminância com DMA
                Filtros.convert_to_grayDMA(imageBitmap, imgDest);

                // Exibe a imagem processada no PictureBox
                pictBoxImg.Image = imgDest;
            }
            catch (Exception ex)
            {
                // Exibe uma mensagem de erro se algo der errado
                MessageBox.Show("Ocorreu um erro ao processar a imagem: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNegativoComDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.negativoDMA(imageBitmap, imgDest);
            pictBoxImg.Image = imgDest;
        }
        private void btnAjustarBrilho_Click(object sender, EventArgs e)
        {
            //implementar 
        }

        private void btnAjustarHue_Click(object sender, EventArgs e)
        {
            //implementar 
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; // Define a janela como maximizada
        }

        private void pictBoxImg_MouseMove(object sender, MouseEventArgs e)
        {
            if (image != null && e.X >= 0 && e.X < image.Width && e.Y >= 0 && e.Y < image.Height)
            {
                tbCoordinates.Text = $"X: {e.X}, Y: {e.Y}";
                Color pixel = imageBitmap.GetPixel(e.X, e.Y);
                tbRGB.Text = $"R: {pixel.R}, G: {pixel.G}, B: {pixel.B}";

                float c = 1 - (pixel.R / 255f);
                float m = 1 - (pixel.G / 255f);
                float y = 1 - (pixel.B / 255f);

                tbCMY.Text = $"C: {c:F2}, M: {m:F2}, Y: {y:F2}";

                tbHSI.Text = $"H: {hsi[e.X, e.Y].Hue}, S: {hsi[e.X, e.Y].Saturation}, I: {hsi[e.X, e.Y].Intensity}";
            }
            else
            {
                tbCoordinates.Text = string.Empty;
                tbRGB.Text = string.Empty;
                tbCMY.Text = string.Empty;
                tbHSI.Text = string.Empty;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int porc = trackBar1.Value;
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.SetBrightness(imageBitmap, imgDest, porc);
            pictBoxImg.Image = imgDest;
        }
    }
}
