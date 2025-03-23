using ProcessamentoImagens;
using ProcessamentoImagens._2D;
using ProcessamentoImagens.Draws;
using ProcessamentoImagens.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RawLine
{
    public partial class frmPrincipal : Form
    {
        private string Active;
        private Point point;
        private Image img;
        private bool flag;
        private List<Graph> List;
        private List<Polygon> polys;
        private List<Polygon> VPs;
        private bool polyflag;
        private bool polyfirst;
        private Polygon poly;
        private Point centro;
        private Point centroVP;
        private Bitmap VP;

        public frmPrincipal()
        {
            InitializeComponent();
            Bitmap b = new Bitmap(picBox.Width, picBox.Height);
            Graphics g = Graphics.FromImage(b);
            g.Clear(Color.White);
            img = b;
            picBox.Image = img;
            picBox.SizeMode = PictureBoxSizeMode.Normal;
            VP = new Bitmap(ViewPort.Width, ViewPort.Height);
            Graphics.FromImage(VP).Clear(Color.White);
            ViewPort.Image = VP;
            //
            flag = false;
            polyflag = false;
            polyfirst = true;
            point = new Point(-1, -1);
            List = new List<Graph>();
            polys = new List<Polygon>();
            VPs = new List<Polygon>();
            this.KeyPreview = true;
            pnScroll.Location = new Point(pnScroll.Location.X, 155);
        }

        private void RebuilPointsList(Polygon poly)
        {
            polysPoints.Items.Clear();
            foreach (Point p in poly.Vertices)
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
            this.Active = rd.Text;
        }

        private void picBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (picBox.Image != null)
                toolTip.SetToolTip(picBox, "X:" + e.X + " Y:" + e.Y);
            if (polyflag == true && polyfirst == false)
            {
                picBox.Image = DrawLine.DDA((Bitmap)img, point.X, point.Y, e.X, e.Y, Color.Black);
            }
            else
            {
                if (flag == true && picBox.Image != null && polyflag == false)
                {
                    switch (this.Active)
                    {
                        case "Equação Real da Reta":
                            picBox.Image = DrawLine.RealLine((Bitmap)img, point.X, point.Y, e.X, e.Y, Color.Black);
                            break;

                        case "DDA":
                            picBox.Image = DrawLine.DDA((Bitmap)img, point.X, point.Y, e.X, e.Y, Color.Black);
                            break;

                        case "Bresenham":
                            picBox.Image = DrawLine.Bresenham((Bitmap)img, point.X, point.Y, e.X, e.Y, Color.Black);
                            break;

                        case "Trigonometria":
                            picBox.Image = DrawCircle.Trigonometry((Bitmap)img, point.X, point.Y, e.X, e.Y, Color.Black);
                            break;

                        case "Ponto Médio":
                            picBox.Image = DrawCircle.Midpoint((Bitmap)img, point.X, point.Y, e.X, e.Y, Color.Black);
                            break;

                        case "Ponto Médio Elipse":
                            picBox.Image = DrawEllipse.Midpoint((Bitmap)img, point.X, point.Y, e.X, e.Y, Color.Black);
                            break;

                        default:
                            picBox.Image = DrawCircle.RealCircle((Bitmap)img, point.X, point.Y, e.X, e.Y, Color.Black);
                            break;
                    }
                }
            }
        }

        private void picBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                img = poly.ReDraw((Bitmap)img, Color.Black);
                picBox.Image = img;
                polys.Add(poly);
                polist.Items.Add(poly);
                Polygon p = poly.GetClone();
                VP = p.ViewPort(VP, Color.Black, img.Width, img.Height, VP.Width, VP.Height);
                ViewPort.Image = VP;
                VPs.Add(p);
                polyflag = false;
                polyfirst = true;
            }
            else
            {
                if (polyflag)
                {
                    if (polyfirst)
                    {
                        polyfirst = !polyfirst;
                        poly = new Polygon();
                        poly.AddVertice(e.X, e.Y);
                        point = new Point(e.X, e.Y);
                    }
                    else
                    {
                        img = DrawLine.DDA((Bitmap)img, point.X, point.Y, e.X, e.Y, Color.Black);
                        picBox.Image = img;
                        poly.AddVertice(e.X, e.Y);
                        point = new Point(e.X, e.Y);
                    }
                }
                else
                {
                    if (flag == false && polyflag == false)
                    {
                        point = new Point(e.X, e.Y);
                        flag = true;
                    }
                }
            }
        }

        private void picBox_MouseUp(object sender, MouseEventArgs e)
        {
            Graph g;
            if (flag == true && polyflag == false)
            {
                switch (this.Active)
                {
                    case "Equação Real da Reta":
                        g = new Graph(point.X, point.Y, e.X, e.Y, "Reta", "Real");
                        img = g.ReDraw((Bitmap)img, Color.Black);
                        Graphs.Items.Add(g);
                        List.Add(g);
                        break;

                    case "DDA":
                        g = new Graph(point.X, point.Y, e.X, e.Y, "Reta", "DDA");
                        img = g.ReDraw((Bitmap)img, Color.Black);
                        Graphs.Items.Add(g);
                        List.Add(g);
                        break;

                    case "Bresenham":
                        g = new Graph(point.X, point.Y, e.X, e.Y, "Reta", "Bresenham");
                        img = g.ReDraw((Bitmap)img, Color.Black);
                        Graphs.Items.Add(g);
                        List.Add(g);
                        break;

                    case "Trigonometria":
                        g = new Graph(point.X, point.Y, e.X, e.Y, "Circunferência", "Trigonometria");
                        img = g.ReDraw((Bitmap)img, Color.Black);
                        Graphs.Items.Add(g);
                        List.Add(g);
                        break;

                    case "Ponto Médio":
                        g = new Graph(point.X, point.Y, e.X, e.Y, "Circunferência", "Ponto Médio");
                        img = g.ReDraw((Bitmap)img, Color.Black);
                        Graphs.Items.Add(g);
                        List.Add(g);
                        break;

                    case "Ponto Médio Elipse":
                        g = new Graph(point.X, point.Y, e.X, e.Y, "Elipse", "Ponto Médio");
                        img = g.ReDraw((Bitmap)img, Color.Black);
                        Graphs.Items.Add(g);
                        List.Add(g);
                        break;

                    default:
                        g = new Graph(point.X, point.Y, e.X, e.Y, "Circunferência", "Real");
                        img = g.ReDraw((Bitmap)img, Color.Black);
                        Graphs.Items.Add(g);
                        List.Add(g);
                        break;
                }
                picBox.Image = img;
                flag = false;
            }
        }

        private void Graphs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Graphs.SelectedIndex >= 0)
            {
                foreach (Graph g in List)
                    img = g.ReDraw((Bitmap)img, Color.Black);
                img = List[Graphs.SelectedIndex].ReDraw((Bitmap)img, Color.Blue);
                picBox.Image = img;
            }
        }

        private void MenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (Graphs.SelectedItem != null)
            {
                img = List[Graphs.SelectedIndex].ReDraw((Bitmap)img, Color.White);
                picBox.Image = img;
                List.RemoveAt(Graphs.SelectedIndex);
                Graphs.Items.Clear();
                foreach (Graph g in List)
                {
                    img = g.ReDraw((Bitmap)img, Color.Black);
                    picBox.Image = img;
                    Graphs.Items.Add(g);
                }
            }
        }

        private void FMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z && List.Count > 0)
            {
                img = List[List.Count - 1].ReDraw((Bitmap)img, Color.White);
                List.RemoveAt(List.Count - 1);
                Graphs.Items.Clear();
                foreach (Graph g in List)
                {
                    img = g.ReDraw((Bitmap)img, Color.Black);
                    Graphs.Items.Add(g);
                }
                picBox.Image = img;
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
            polyflag = true;
            polyfirst = true;
        }

        private void polist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (polist.SelectedItems.Count == 1)
            {
                foreach (var item in polys)
                    img = item.ReDraw((Bitmap)img, Color.Black);
                foreach (var item in VPs)
                    VP = item.ReDraw(VP, Color.Black);
                img = polys[polist.SelectedIndex].ReDraw((Bitmap)img, Color.Blue);
                VP = VPs[polist.SelectedIndex].ReDraw(VP, Color.Blue);
                centro = polys[polist.SelectedIndex].GetSeed();
                centroVP = VPs[polist.SelectedIndex].GetSeed();
                RebuilPointsList(polys[polist.SelectedIndex]);
                picBox.Image = img;
                ViewPort.Image = VP;
            }
        }

        private void btApagaPoly_Click(object sender, EventArgs e)
        {
            if (polist.SelectedItems.Count == 1)
            {
                try
                {
                    img = polys[polist.SelectedIndex].ReDraw((Bitmap)img, Color.White);
                    VP = VPs[polist.SelectedIndex].ReDraw(VP, Color.White);
                    polys.RemoveAt(polist.SelectedIndex);
                    VPs.RemoveAt(polist.SelectedIndex);
                    polist.Items.Clear();
                    polysPoints.Items.Clear();
                    foreach (var item in polys)
                    {
                        img = item.ReDraw((Bitmap)img, Color.Black);
                        polist.Items.Add(item);
                    }
                    foreach (var item in VPs)
                    {
                        VP = item.ReDraw(VP, Color.Black);
                    }
                    picBox.Image = img;
                    ViewPort.Image = VP;
                }
                catch
                {
                    polys.RemoveRange(0, polys.Count - 1);
                    Graphics.FromImage(img).Clear(Color.White);
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
                img = polys[polist.SelectedIndex].FloodFill((Bitmap)img, Color.Orange);
                VP = VPs[polist.SelectedIndex].FloodFill(VP, Color.Orange);
                picBox.Image = img;
                ViewPort.Image = VP;
            }
        }

        private void btEscala_Click(object sender, EventArgs e)
        {
            if (polist.SelectedItems.Count > 0)
            {
                double value = (double)slideEscala.Value / 10;
                img = polys[polist.SelectedIndex].Translation((Bitmap)img, Color.Blue, new Point(-centro.X, -centro.Y));
                img = polys[polist.SelectedIndex].Scala((Bitmap)img, Color.Blue, value);
                img = polys[polist.SelectedIndex].Translation((Bitmap)img, Color.Blue, new Point(centro.X, centro.Y));
                //
                VP = VPs[polist.SelectedIndex].Translation(VP, Color.Blue, new Point(-centroVP.X, -centroVP.Y));
                VP = VPs[polist.SelectedIndex].Scala(VP, Color.Blue, value);
                VP = VPs[polist.SelectedIndex].Translation(VP, Color.Blue, new Point(centroVP.X, centroVP.Y));
                RebuilPointsList(polys[polist.SelectedIndex]);
                picBox.Image = img;
                ViewPort.Image = VP;
            }
        }

        private void btTranslacao_Click(object sender, EventArgs e)
        {
            if (polist.SelectedItems.Count > 0)
            {
                int value = slideTransalacao.Value - 100;
                img = polys[polist.SelectedIndex].Translation((Bitmap)img, Color.Blue, value);
                centro = polys[polist.SelectedIndex].GetSeed();
                RebuilPointsList(polys[polist.SelectedIndex]);
                VP = VPs[polist.SelectedIndex].Translation(VP, Color.Blue, value);
                picBox.Image = img;
                ViewPort.Image = VP;
            }
        }

        private void btRotation_Click(object sender, EventArgs e)
        {
            if (polist.SelectedItems.Count > 0)
            {
                int value = Convert.ToInt32(numAngle.Value);
                img = polys[polist.SelectedIndex].Translation((Bitmap)img, Color.Blue, new Point(-centro.X, -centro.Y));
                img = polys[polist.SelectedIndex].Rotation((Bitmap)img, Color.Blue, value);
                img = polys[polist.SelectedIndex].Translation((Bitmap)img, Color.Blue, new Point(centro.X, centro.Y));
                //
                VP = VPs[polist.SelectedIndex].Translation(VP, Color.Blue, new Point(-centroVP.X, -centroVP.Y));
                VP = VPs[polist.SelectedIndex].Rotation(VP, Color.Blue, value);
                VP = VPs[polist.SelectedIndex].Translation(VP, Color.Blue, new Point(centroVP.X, centroVP.Y));
                RebuilPointsList(polys[polist.SelectedIndex]);
                ViewPort.Image = VP;
                picBox.Image = img;
            }
        }

        private void btShearX_Click(object sender, EventArgs e)
        {
            if (polist.SelectedItems.Count > 0)
            {
                int x = Convert.ToInt32(numX.Value);
                img = polys[polist.SelectedIndex].Translation((Bitmap)img, Color.Blue, new Point(-centro.X, -centro.Y));
                img = polys[polist.SelectedIndex].Shear((Bitmap)img, Color.Blue, x, 0);
                img = polys[polist.SelectedIndex].Translation((Bitmap)img, Color.Blue, new Point(centro.X, centro.Y));
                RebuilPointsList(polys[polist.SelectedIndex]);
                //
                VP = VPs[polist.SelectedIndex].Translation(VP, Color.Blue, new Point(-centroVP.X, -centroVP.Y));
                VP = VPs[polist.SelectedIndex].Shear(VP, Color.Blue, x, 0);
                VP = VPs[polist.SelectedIndex].Translation(VP, Color.Blue, new Point(centroVP.X, centroVP.Y));
                ViewPort.Image = VP;
                picBox.Image = img;
            }
        }

        private void btShearY_Click(object sender, EventArgs e)
        {
            if (polist.SelectedItems.Count > 0)
            {
                int y = Convert.ToInt32(numY.Value);
                img = polys[polist.SelectedIndex].Translation((Bitmap)img, Color.Blue, new Point(-centro.X, -centro.Y));
                img = polys[polist.SelectedIndex].Shear((Bitmap)img, Color.Blue, 0, y);
                img = polys[polist.SelectedIndex].Translation((Bitmap)img, Color.Blue, new Point(centro.X, centro.Y));
                RebuilPointsList(polys[polist.SelectedIndex]);
                //
                VP = VPs[polist.SelectedIndex].Translation(VP, Color.Blue, new Point(-centroVP.X, -centroVP.Y));
                VP = VPs[polist.SelectedIndex].Shear(VP, Color.Blue, 0, y);
                VP = VPs[polist.SelectedIndex].Translation(VP, Color.Blue, new Point(centroVP.X, centroVP.Y));
                ViewPort.Image = VP;
                picBox.Image = img;
            }
        }

        private void btShearXY_Click(object sender, EventArgs e)
        {
            if (polist.SelectedItems.Count > 0)
            {
                int x = Convert.ToInt32(numX.Value);
                int y = Convert.ToInt32(numY.Value);
                img = polys[polist.SelectedIndex].Translation((Bitmap)img, Color.Blue, new Point(-centro.X, -centro.Y));
                img = polys[polist.SelectedIndex].Shear((Bitmap)img, Color.Blue, x, y);
                img = polys[polist.SelectedIndex].Translation((Bitmap)img, Color.Blue, new Point(centro.X, centro.Y));
                RebuilPointsList(polys[polist.SelectedIndex]);
                //
                VP = VPs[polist.SelectedIndex].Translation(VP, Color.Blue, new Point(-centroVP.X, -centroVP.Y));
                VP = VPs[polist.SelectedIndex].Shear(VP, Color.Blue, x, y);
                VP = VPs[polist.SelectedIndex].Translation(VP, Color.Blue, new Point(centroVP.X, centroVP.Y));
                ViewPort.Image = VP;
                picBox.Image = img;
            }
        }

        private void btHoriz_Click(object sender, EventArgs e)
        {
            if (polist.SelectedItems.Count > 0)
            {
                img = polys[polist.SelectedIndex].Translation((Bitmap)img, Color.Blue, new Point(-centro.X, -centro.Y));
                img = polys[polist.SelectedIndex].Mirror((Bitmap)img, Color.Blue, -1, 1);
                img = polys[polist.SelectedIndex].Translation((Bitmap)img, Color.Blue, new Point(centro.X, centro.Y));
                RebuilPointsList(polys[polist.SelectedIndex]);
                //
                VP = VPs[polist.SelectedIndex].Translation(VP, Color.Blue, new Point(-centroVP.X, -centroVP.Y));
                VP = VPs[polist.SelectedIndex].Mirror(VP, Color.Blue, -1, 1);
                VP = VPs[polist.SelectedIndex].Translation(VP, Color.Blue, new Point(centroVP.X, centroVP.Y));
                ViewPort.Image = VP;
                picBox.Image = img;
            }
        }

        private void btVert_Click(object sender, EventArgs e)
        {
            if (polist.SelectedItems.Count > 0)
            {
                img = polys[polist.SelectedIndex].Translation((Bitmap)img, Color.Blue, new Point(-centro.X, -centro.Y));
                img = polys[polist.SelectedIndex].Mirror((Bitmap)img, Color.Blue, 1, -1);
                img = polys[polist.SelectedIndex].Translation((Bitmap)img, Color.Blue, new Point(centro.X, centro.Y));
                RebuilPointsList(polys[polist.SelectedIndex]);
                //
                VP = VPs[polist.SelectedIndex].Translation(VP, Color.Blue, new Point(-centroVP.X, -centroVP.Y));
                VP = VPs[polist.SelectedIndex].Mirror(VP, Color.Blue, 1, -1);
                VP = VPs[polist.SelectedIndex].Translation(VP, Color.Blue, new Point(centroVP.X, centroVP.Y));
                ViewPort.Image = VP;
                picBox.Image = img;
            }
        }

        private void btDiag_Click(object sender, EventArgs e)
        {
            if (polist.SelectedItems.Count > 0)
            {
                img = polys[polist.SelectedIndex].Translation((Bitmap)img, Color.Blue, new Point(-centro.X, -centro.Y));
                img = polys[polist.SelectedIndex].Mirror((Bitmap)img, Color.Blue, -1, -1);
                img = polys[polist.SelectedIndex].Translation((Bitmap)img, Color.Blue, new Point(centro.X, centro.Y));
                RebuilPointsList(polys[polist.SelectedIndex]);
                //
                VP = VPs[polist.SelectedIndex].Translation(VP, Color.Blue, new Point(-centroVP.X, -centroVP.Y));
                VP = VPs[polist.SelectedIndex].Mirror(VP, Color.Blue, -1, -1);
                VP = VPs[polist.SelectedIndex].Translation(VP, Color.Blue, new Point(centroVP.X, centroVP.Y));
                ViewPort.Image = VP;
                picBox.Image = img;
            }
        }

        private void btScan_Click(object sender, EventArgs e)
        {
            if (polist.SelectedItems.Count > 0)
            {
                ScanLine scan = new ScanLine(polys[polist.SelectedIndex]);
                img = scan.Fill(Color.DarkGreen, (Bitmap)img);
                picBox.Image = img;
                ScanLine scanVP = new ScanLine(VPs[polist.SelectedIndex]);
                VP = scanVP.Fill(Color.DarkGreen, VP);
                ViewPort.Image = VP;
            }
        }
    }
}
