using ProcessamentoImagens;
using ProcessamentoImagens._2D;
using ProcessamentoImagens.Desenhos;
using ProcessamentoImagens.Ferramentas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RawLine
{
    public partial class frmPrincipal : Form
    {
        private string Ativo;
        private Point ponto;
        private Image imagem;
        private bool flag;
        private List<Grafo> lista;
        private List<Poligono> poligonos;
        private List<Poligono> VPs;
        private bool flagPoligono;
        private bool primeiroPoligono;
        private Poligono poligono;
        private Point centro;
        private Point centroVP;
        private Bitmap VP;

        public frmPrincipal()
        {
            InitializeComponent();
            Bitmap b = new Bitmap(picBox.Width, picBox.Height);
            Graphics g = Graphics.FromImage(b);
            g.Clear(Color.White);
            imagem = b;
            picBox.Image = imagem;
            picBox.SizeMode = PictureBoxSizeMode.Normal;
            VP = new Bitmap(ViewPort.Width, ViewPort.Height);
            Graphics.FromImage(VP).Clear(Color.White);
            ViewPort.Image = VP;
            //
            flag = false;
            flagPoligono = false;
            primeiroPoligono = true;
            ponto = new Point(-1, -1);
            lista = new List<Grafo>();
            poligonos = new List<Poligono>();
            VPs = new List<Poligono>();
            this.KeyPreview = true;
            pnScroll.Location = new Point(pnScroll.Location.X, 155);
        }

        private void ReconstruirPontosLista(Poligono poligono)
        {
            polysPoints.Items.Clear();
            foreach (Point p in poligono.Vertices)
                polysPoints.Items.Add("(" + p.X + ", " + p.Y + ")");
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rd = (RadioButton)sender;
            foreach (var control in Controls)
            {
                if (control.GetType() == typeof(GroupBox))
                {
                    GroupBox g = (GroupBox)control;
                    foreach (var inside in g.Controls)
                    {
                        RadioButton radio = (RadioButton)inside;
                        if (radio.Name != rd.Name)
                            radio.Checked = false;
                    }
                }
            }
            this.Ativo = rd.Text;
        }

        private void picBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (picBox.Image != null)
                toolTip.SetToolTip(picBox, "X:" + e.X + " Y:" + e.Y);
            if (flagPoligono == true && primeiroPoligono == false)
            {
                picBox.Image = DesenharLinha.DDA((Bitmap)imagem, ponto.X, ponto.Y, e.X, e.Y, Color.Black);
            }
            else
            {
                if (flag == true && picBox.Image != null && flagPoligono == false)
                {
                    switch (this.Ativo)
                    {
                        case "Equação Real da Reta":
                            picBox.Image = DesenharLinha.LinhaReal((Bitmap)imagem, ponto.X, ponto.Y, e.X, e.Y, Color.Black);
                            break;

                        case "DDA":
                            picBox.Image = DesenharLinha.DDA((Bitmap)imagem, ponto.X, ponto.Y, e.X, e.Y, Color.Black);
                            break;

                        case "Bresenham":
                            picBox.Image = DesenharLinha.Bresenham((Bitmap)imagem, ponto.X, ponto.Y, e.X, e.Y, Color.Black);
                            break;

                        case "Trigonometria":
                            picBox.Image = DesenharCirculo.Trigonometria((Bitmap)imagem, ponto.X, ponto.Y, e.X, e.Y, Color.Black);
                            break;

                        case "Ponto Médio":
                            picBox.Image = DesenharCirculo.PontoMedio((Bitmap)imagem, ponto.X, ponto.Y, e.X, e.Y, Color.Black);
                            break;

                        case "Ponto Médio Elipse":
                            picBox.Image = DesenharElipse.PontoMedio((Bitmap)imagem, ponto.X, ponto.Y, e.X, e.Y, Color.Black);
                            break;

                        default:
                            picBox.Image = DesenharCirculo.CírculoReal((Bitmap)imagem, ponto.X, ponto.Y, e.X, e.Y, Color.Black);
                            break;
                    }
                }
            }
        }

        private void picBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                imagem = poligono.ReDesenhar((Bitmap)imagem, Color.Black);
                picBox.Image = imagem;
                poligonos.Add(poligono);
                polist.Items.Add(poligono);
                Poligono p = poligono.ObterClone();
                VP = p.ViewPort(VP, Color.Black, imagem.Width, imagem.Height, VP.Width, VP.Height);
                ViewPort.Image = VP;
                VPs.Add(p);
                flagPoligono = false;
                primeiroPoligono = true;
            }
            else
            {
                if (flagPoligono)
                {
                    if (primeiroPoligono)
                    {
                        primeiroPoligono = !primeiroPoligono;
                        poligono = new Poligono();
                        poligono.AdicionarVértice(e.X, e.Y);
                        ponto = new Point(e.X, e.Y);
                    }
                    else
                    {
                        imagem = DesenharLinha.DDA((Bitmap)imagem, ponto.X, ponto.Y, e.X, e.Y, Color.Black);
                        picBox.Image = imagem;
                        poligono.AdicionarVértice(e.X, e.Y);
                        ponto = new Point(e.X, e.Y);
                    }
                }
                else
                {
                    if (flag == false && flagPoligono == false)
                    {
                        ponto = new Point(e.X, e.Y);
                        flag = true;
                    }
                }
            }
        }

        private void picBox_MouseUp(object sender, MouseEventArgs e)
        {
            Grafo grafo;
            if (flag == true && flagPoligono == false)
            {
                switch (this.Ativo)
                {
                    case "Equação Real da Reta":
                        grafo = new Grafo(ponto.X, ponto.Y, e.X, e.Y, "Reta", "Real");
                        imagem = grafo.Redesenhar((Bitmap)imagem, Color.Black);
                        Graphs.Items.Add(grafo);
                        lista.Add(grafo);
                        break;

                    case "DDA":
                        grafo = new Grafo(ponto.X, ponto.Y, e.X, e.Y, "Reta", "DDA");
                        imagem = grafo.Redesenhar((Bitmap)imagem, Color.Black);
                        Graphs.Items.Add(grafo);
                        lista.Add(grafo);
                        break;

                    case "Bresenham":
                        grafo = new Grafo(ponto.X, ponto.Y, e.X, e.Y, "Reta", "Bresenham");
                        imagem = grafo.Redesenhar((Bitmap)imagem, Color.Black);
                        Graphs.Items.Add(grafo);
                        lista.Add(grafo);
                        break;

                    case "Trigonometria":
                        grafo = new Grafo(ponto.X, ponto.Y, e.X, e.Y, "Circunferência", "Trigonometria");
                        imagem = grafo.Redesenhar((Bitmap)imagem, Color.Black);
                        Graphs.Items.Add(grafo);
                        lista.Add(grafo);
                        break;

                    case "Ponto Médio":
                        grafo = new Grafo(ponto.X, ponto.Y, e.X, e.Y, "Circunferência", "Ponto Médio");
                        imagem = grafo.Redesenhar((Bitmap)imagem, Color.Black);
                        Graphs.Items.Add(grafo);
                        lista.Add(grafo);
                        break;

                    case "Ponto Médio Elipse":
                        grafo = new Grafo(ponto.X, ponto.Y, e.X, e.Y, "Elipse", "Ponto Médio");
                        imagem = grafo.Redesenhar((Bitmap)imagem, Color.Black);
                        Graphs.Items.Add(grafo);
                        lista.Add(grafo);
                        break;

                    default:
                        grafo = new Grafo(ponto.X, ponto.Y, e.X, e.Y, "Circunferência", "Real");
                        imagem = grafo.Redesenhar((Bitmap)imagem, Color.Black);
                        Graphs.Items.Add(grafo);
                        lista.Add(grafo);
                        break;
                }
                picBox.Image = imagem;
                flag = false;
            }
        }


        private void Graphs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Graphs.SelectedIndex >= 0)
            {
                foreach (Grafo g in lista)
                    imagem = g.Redesenhar((Bitmap)imagem, Color.Black);
                imagem = lista[Graphs.SelectedIndex].Redesenhar((Bitmap)imagem, Color.Blue);
                picBox.Image = imagem;
            }
        }

        private void MenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (Graphs.SelectedItem != null)
            {
                imagem = lista[Graphs.SelectedIndex].Redesenhar((Bitmap)imagem, Color.White);
                picBox.Image = imagem;
                lista.RemoveAt(Graphs.SelectedIndex);
                Graphs.Items.Clear();
                foreach (Grafo g in lista)
                {
                    imagem = g.Redesenhar((Bitmap)imagem, Color.Black);
                    picBox.Image = imagem;
                    Graphs.Items.Add(g);
                }
            }
        }

        private void FMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z && lista.Count > 0)
            {
                imagem = lista[lista.Count - 1].Redesenhar((Bitmap)imagem, Color.White);
                lista.RemoveAt(lista.Count - 1);
                Graphs.Items.Clear();
                foreach (Grafo g in lista)
                {
                    imagem = g.Redesenhar((Bitmap)imagem, Color.Black);
                    Graphs.Items.Add(g);
                }
                picBox.Image = imagem;
            }
        }

        private void slideEscala_Scroll(object sender, EventArgs e)
        {
            double value = (double)slideEscala.Value / 10;
            int mov = slideEscala.Value - 10;
            Point loc = new Point(54, 19);
            loc.X += Convert.ToInt32(mov * 4);
            if (value == 3.0 || value == 4.0 || value == 5.0)
                loc.X += 5;
            loc.X = (loc.X > 219) ? 219 : loc.X;
            txtValueEscala.Location = loc;
            txtValueEscala.Text = value.ToString();
        }

        private void slideTransalacao_Scroll(object sender, EventArgs e)
        {
            int value = slideTransalacao.Value - 100;
            int sig = 0;
            if (value < 0)
            {
                if (Math.Abs(value) >= 10)
                {
                    if (Math.Abs(value) >= 100)
                    {
                        sig = 12;
                    }
                    else
                        sig = 8;
                }
                else
                    sig = 4;
            }

            Point loc = new Point(116 - sig, 19);
            loc.X += value;
            loc.X = (loc.X > 217) ? 217 : loc.X;
            txtValueTranslacao.Location = loc;
            txtValueTranslacao.Text = value.ToString();
        }

        private void scrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            pnScroll.Location = new Point(pnScroll.Location.X, 155 - scrollBar.Value);
        }

        private void btCriaPoly_Click(object sender, EventArgs e)
        {
            flagPoligono = true;
            primeiroPoligono = true;
        }

        private void polist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (polist.SelectedItems.Count == 1)
            {
                foreach (var item in poligonos)
                    imagem = item.ReDesenhar((Bitmap)imagem, Color.Black);
                foreach (var item in VPs)
                    VP = item.ReDesenhar(VP, Color.Black);
                imagem = poligonos[polist.SelectedIndex].ReDesenhar((Bitmap)imagem, Color.Blue);
                VP = VPs[polist.SelectedIndex].ReDesenhar(VP, Color.Blue);
                centro = poligonos[polist.SelectedIndex].ObterSemente();
                centroVP = VPs[polist.SelectedIndex].ObterSemente();
                ReconstruirPontosLista(poligonos[polist.SelectedIndex]);
                picBox.Image = imagem;
                ViewPort.Image = VP;
            }
        }

        private void btApagaPoly_Click(object sender, EventArgs e)
        {
            if (polist.SelectedItems.Count == 1)
            {
                try
                {
                    imagem = poligonos[polist.SelectedIndex].ReDesenhar((Bitmap)imagem, Color.White);
                    VP = VPs[polist.SelectedIndex].ReDesenhar(VP, Color.White);
                    poligonos.RemoveAt(polist.SelectedIndex);
                    VPs.RemoveAt(polist.SelectedIndex);
                    polist.Items.Clear();
                    polysPoints.Items.Clear();
                    foreach (var item in poligonos)
                    {
                        imagem = item.ReDesenhar((Bitmap)imagem, Color.Black);
                        polist.Items.Add(item);
                    }
                    foreach (var item in VPs)
                    {
                        VP = item.ReDesenhar(VP, Color.Black);
                    }
                    picBox.Image = imagem;
                    ViewPort.Image = VP;
                }
                catch
                {
                    poligonos.RemoveRange(0, poligonos.Count - 1);
                    Graphics.FromImage(imagem).Clear(Color.White);
                    VPs.RemoveRange(0, VPs.Count - 1);
                    Graphics.FromImage(VP).Clear(Color.White);
                    ViewPort.Image = VP;
                }
            }
        }

        private void btFlood_Click(object sender, EventArgs e)
        {
            if (polist.SelectedItems.Count > 0)
            {
                imagem = poligonos[polist.SelectedIndex].Preenchimento((Bitmap)imagem, Color.Orange);
                VP = VPs[polist.SelectedIndex].Preenchimento(VP, Color.Orange);
                picBox.Image = imagem;
                ViewPort.Image = VP;
            }
        }

        private void btEscala_Click(object sender, EventArgs e)
        {
            if (polist.SelectedItems.Count > 0)
            {
                double value = (double)slideEscala.Value / 10;
                imagem = poligonos[polist.SelectedIndex].Translação((Bitmap)imagem, Color.Blue, new Point(-centro.X, -centro.Y));
                imagem = poligonos[polist.SelectedIndex].Escalar((Bitmap)imagem, Color.Blue, value);
                imagem = poligonos[polist.SelectedIndex].Translação((Bitmap)imagem, Color.Blue, new Point(centro.X, centro.Y));
                //
                VP = VPs[polist.SelectedIndex].Translação(VP, Color.Blue, new Point(-centroVP.X, -centroVP.Y));
                VP = VPs[polist.SelectedIndex].Escalar(VP, Color.Blue, value);
                VP = VPs[polist.SelectedIndex].Translação(VP, Color.Blue, new Point(centroVP.X, centroVP.Y));
                ReconstruirPontosLista(poligonos[polist.SelectedIndex]);
                picBox.Image = imagem;
                ViewPort.Image = VP;
            }
        }

        private void btTranslacao_Click(object sender, EventArgs e)
        {
            if (polist.SelectedItems.Count > 0)
            {
                int value = slideTransalacao.Value - 100;
                imagem = poligonos[polist.SelectedIndex].Translação((Bitmap)imagem, Color.Blue, value);
                centro = poligonos[polist.SelectedIndex].ObterSemente();
                ReconstruirPontosLista(poligonos[polist.SelectedIndex]);
                VP = VPs[polist.SelectedIndex].Translação(VP, Color.Blue, value);
                picBox.Image = imagem;
                ViewPort.Image = VP;
            }
        }

        private void btRotation_Click(object sender, EventArgs e)
        {
            if (polist.SelectedItems.Count > 0)
            {
                int value = Convert.ToInt32(numAngle.Value);
                imagem = poligonos[polist.SelectedIndex].Translação((Bitmap)imagem, Color.Blue, new Point(-centro.X, -centro.Y));
                imagem = poligonos[polist.SelectedIndex].Rotação((Bitmap)imagem, Color.Blue, value);
                imagem = poligonos[polist.SelectedIndex].Translação((Bitmap)imagem, Color.Blue, new Point(centro.X, centro.Y));
                //
                VP = VPs[polist.SelectedIndex].Translação(VP, Color.Blue, new Point(-centroVP.X, -centroVP.Y));
                VP = VPs[polist.SelectedIndex].Rotação(VP, Color.Blue, value);
                VP = VPs[polist.SelectedIndex].Translação(VP, Color.Blue, new Point(centroVP.X, centroVP.Y));
                ReconstruirPontosLista(poligonos[polist.SelectedIndex]);
                ViewPort.Image = VP;
                picBox.Image = imagem;
            }
        }

        private void btCisalharmentoX_Click(object sender, EventArgs e)
        {
            if (polist.SelectedItems.Count > 0)
            {
                int x = Convert.ToInt32(numX.Value);
                imagem = poligonos[polist.SelectedIndex].Translação((Bitmap)imagem, Color.Blue, new Point(-centro.X, -centro.Y));
                imagem = poligonos[polist.SelectedIndex].Cisalharmento((Bitmap)imagem, Color.Blue, x, 0);
                imagem = poligonos[polist.SelectedIndex].Translação((Bitmap)imagem, Color.Blue, new Point(centro.X, centro.Y));
                ReconstruirPontosLista(poligonos[polist.SelectedIndex]);
                //
                VP = VPs[polist.SelectedIndex].Translação(VP, Color.Blue, new Point(-centroVP.X, -centroVP.Y));
                VP = VPs[polist.SelectedIndex].Cisalharmento(VP, Color.Blue, x, 0);
                VP = VPs[polist.SelectedIndex].Translação(VP, Color.Blue, new Point(centroVP.X, centroVP.Y));
                ViewPort.Image = VP;
                picBox.Image = imagem;
            }
        }

        private void btCisalharmentoY_Click(object sender, EventArgs e)
        {
            if (polist.SelectedItems.Count > 0)
            {
                int y = Convert.ToInt32(numY.Value);
                imagem = poligonos[polist.SelectedIndex].Translação((Bitmap)imagem, Color.Blue, new Point(-centro.X, -centro.Y));
                imagem = poligonos[polist.SelectedIndex].Cisalharmento((Bitmap)imagem, Color.Blue, 0, y);
                imagem = poligonos[polist.SelectedIndex].Translação((Bitmap)imagem, Color.Blue, new Point(centro.X, centro.Y));
                ReconstruirPontosLista(poligonos[polist.SelectedIndex]);
                //
                VP = VPs[polist.SelectedIndex].Translação(VP, Color.Blue, new Point(-centroVP.X, -centroVP.Y));
                VP = VPs[polist.SelectedIndex].Cisalharmento(VP, Color.Blue, 0, y);
                VP = VPs[polist.SelectedIndex].Translação(VP, Color.Blue, new Point(centroVP.X, centroVP.Y));
                ViewPort.Image = VP;
                picBox.Image = imagem;
            }
        }

        private void btCisalharmentoXY_Click(object sender, EventArgs e)
        {
            if (polist.SelectedItems.Count > 0)
            {
                int x = Convert.ToInt32(numX.Value);
                int y = Convert.ToInt32(numY.Value);
                imagem = poligonos[polist.SelectedIndex].Translação((Bitmap)imagem, Color.Blue, new Point(-centro.X, -centro.Y));
                imagem = poligonos[polist.SelectedIndex].Cisalharmento((Bitmap)imagem, Color.Blue, x, y);
                imagem = poligonos[polist.SelectedIndex].Translação((Bitmap)imagem, Color.Blue, new Point(centro.X, centro.Y));
                ReconstruirPontosLista(poligonos[polist.SelectedIndex]);
                //
                VP = VPs[polist.SelectedIndex].Translação(VP, Color.Blue, new Point(-centroVP.X, -centroVP.Y));
                VP = VPs[polist.SelectedIndex].Cisalharmento(VP, Color.Blue, x, y);
                VP = VPs[polist.SelectedIndex].Translação(VP, Color.Blue, new Point(centroVP.X, centroVP.Y));
                ViewPort.Image = VP;
                picBox.Image = imagem;
            }
        }

        private void btHoriz_Click(object sender, EventArgs e)
        {
            if (polist.SelectedItems.Count > 0)
            {
                imagem = poligonos[polist.SelectedIndex].Translação((Bitmap)imagem, Color.Blue, new Point(-centro.X, -centro.Y));
                imagem = poligonos[polist.SelectedIndex].Espelhar((Bitmap)imagem, Color.Blue, -1, 1);
                imagem = poligonos[polist.SelectedIndex].Translação((Bitmap)imagem, Color.Blue, new Point(centro.X, centro.Y));
                ReconstruirPontosLista(poligonos[polist.SelectedIndex]);
                //
                VP = VPs[polist.SelectedIndex].Translação(VP, Color.Blue, new Point(-centroVP.X, -centroVP.Y));
                VP = VPs[polist.SelectedIndex].Espelhar(VP, Color.Blue, -1, 1);
                VP = VPs[polist.SelectedIndex].Translação(VP, Color.Blue, new Point(centroVP.X, centroVP.Y));
                ViewPort.Image = VP;
                picBox.Image = imagem;
            }
        }

        private void btVert_Click(object sender, EventArgs e)
        {
            if (polist.SelectedItems.Count > 0)
            {
                imagem = poligonos[polist.SelectedIndex].Translação((Bitmap)imagem, Color.Blue, new Point(-centro.X, -centro.Y));
                imagem = poligonos[polist.SelectedIndex].Espelhar((Bitmap)imagem, Color.Blue, 1, -1);
                imagem = poligonos[polist.SelectedIndex].Translação((Bitmap)imagem, Color.Blue, new Point(centro.X, centro.Y));
                ReconstruirPontosLista(poligonos[polist.SelectedIndex]);
                //
                VP = VPs[polist.SelectedIndex].Translação(VP, Color.Blue, new Point(-centroVP.X, -centroVP.Y));
                VP = VPs[polist.SelectedIndex].Espelhar(VP, Color.Blue, 1, -1);
                VP = VPs[polist.SelectedIndex].Translação(VP, Color.Blue, new Point(centroVP.X, centroVP.Y));
                ViewPort.Image = VP;
                picBox.Image = imagem;
            }
        }

        private void btDiag_Click(object sender, EventArgs e)
        {
            if (polist.SelectedItems.Count > 0)
            {
                imagem = poligonos[polist.SelectedIndex].Translação((Bitmap)imagem, Color.Blue, new Point(-centro.X, -centro.Y));
                imagem = poligonos[polist.SelectedIndex].Espelhar((Bitmap)imagem, Color.Blue, -1, -1);
                imagem = poligonos[polist.SelectedIndex].Translação((Bitmap)imagem, Color.Blue, new Point(centro.X, centro.Y));
                ReconstruirPontosLista(poligonos[polist.SelectedIndex]);
                //
                VP = VPs[polist.SelectedIndex].Translação(VP, Color.Blue, new Point(-centroVP.X, -centroVP.Y));
                VP = VPs[polist.SelectedIndex].Espelhar(VP, Color.Blue, -1, -1);
                VP = VPs[polist.SelectedIndex].Translação(VP, Color.Blue, new Point(centroVP.X, centroVP.Y));
                ViewPort.Image = VP;
                picBox.Image = imagem;
            }
        }

        private void btScan_Click(object sender, EventArgs e)
        {
            if (polist.SelectedItems.Count > 0)
            {
                ScanLine scan = new ScanLine(poligonos[polist.SelectedIndex]);
                imagem = scan.Preencher(Color.DarkGreen, (Bitmap)imagem);
                picBox.Image = imagem;
                ScanLine scanVP = new ScanLine(VPs[polist.SelectedIndex]);
                VP = scanVP.Preencher(Color.DarkGreen, VP);
                ViewPort.Image = VP;
            }
        }
    }
}
