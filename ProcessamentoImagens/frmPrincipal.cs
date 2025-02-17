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
                hsi = Filtros.rgbToHsi(imageBitmap);
                //updatePictures(imageBitmap);
            }
        }

        private void updatePictures(Bitmap imageBitmap)
        {
            if (imageBitmap != null)
            {
                try
                {
                    Bitmap imgRed = new Bitmap(image.Width, image.Height);
                    Bitmap imgGreen = new Bitmap(image.Width, image.Height);
                    Bitmap imgBlue = new Bitmap(image.Width, image.Height);

                    Bitmap imgH = new Bitmap(image.Width, image.Height);
                    Bitmap imgS = new Bitmap(image.Width, image.Height);
                    Bitmap imgI = new Bitmap(image.Width, image.Height);

                    // Converter para tons de cinza
                    Filtros.convert_to_grayDMA(imageBitmap, imgRed, 'R');
                    Filtros.convert_to_grayDMA(imageBitmap, imgGreen, 'G');
                    Filtros.convert_to_grayDMA(imageBitmap, imgBlue, 'B');
                    Filtros.convert_to_grayDMA(imageBitmap, imgH, 'H');
                    Filtros.convert_to_grayDMA(imageBitmap, imgS, 'S');
                    Filtros.convert_to_grayDMA(imageBitmap, imgI, 'I');

                    // Criar a imagem HSI em tons de cinza
                    for (int y = 0; y < image.Height; y++)
                    {
                        for (int x = 0; x < image.Width; x++)
                        {
                            int h = (int)hsi[x, y].Hue;
                            h = Math.Min(255, Math.Max(0, h * 255 / 360)); 
                            imgH.SetPixel(x, y, Color.FromArgb(h, h, h));

                            int s = (int)(hsi[x, y].Saturation * 255); 
                            s = Math.Min(100, Math.Max(0, s*255/100)); 
                            imgS.SetPixel(x, y, Color.FromArgb(s, s, s));

                            int i = (int)(hsi[x, y].Intensity * 255);  
                            i = Math.Min(255, Math.Max(0, i));  
                            imgI.SetPixel(x, y, Color.FromArgb(i, i, i));
                        }
                    }

                    pictBoxRed.Image = new Bitmap(imgRed, pictBoxRed.Size);
                    pictBoxGreen.Image = new Bitmap(imgGreen, pictBoxGreen.Size);
                    pictBoxBlue.Image = new Bitmap(imgBlue, pictBoxBlue.Size);
                    pictBoxH.Image = new Bitmap(imgH, pictBoxH.Size);
                    pictBoxS.Image = new Bitmap(imgS, pictBoxS.Size);
                    pictBoxI.Image = new Bitmap(imgI, pictBoxI.Size);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao processar a imagem: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private int normaliza(int valor)
        {
            if (valor > 255)
            {
                valor = 255; 
            }
            if (valor < 0)
            {
                valor = 0;
            }

            return valor;
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

        private void btnProcessarCanais_Click(object sender, EventArgs e)
        {
           
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
            label3.Text = porc + "%";
            trackBar2.Value = 0;
            label4.Text = "0°";
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.SetBrightness(imageBitmap, imgDest, porc);
            pictBoxImg.Image = imgDest;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            int hue = trackBar2.Value;
            label4.Text = hue + "°";
            trackBar1.Value = 0;
            label3.Text = "0%";
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = new Bitmap(image);
            Filtros.SetHue(imageBitmap, imgDest, hue);
            pictBoxImg.Image = imgDest;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updatePictures(imageBitmap);
        }
    }
}
