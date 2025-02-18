using System.Drawing;
using System.Windows.Forms;

namespace ProcessamentoImagens
{
    partial class frmPrincipal
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }



        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.menuSuperiorPanel = new System.Windows.Forms.Panel();
            this.minHue = new System.Windows.Forms.TextBox();
            this.maxHue = new System.Windows.Forms.TextBox();
            this.btnAbrirImagem = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.menuLateralPanel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lblRGB = new System.Windows.Forms.Label();
            this.tbRGB = new System.Windows.Forms.TextBox();
            this.lblCMY = new System.Windows.Forms.Label();
            this.tbCMY = new System.Windows.Forms.TextBox();
            this.lblHSI = new System.Windows.Forms.Label();
            this.tbHSI = new System.Windows.Forms.TextBox();
            this.lblCoordinates = new System.Windows.Forms.Label();
            this.tbCoordinates = new System.Windows.Forms.TextBox();
            this.btnLuminanciaComDMA = new System.Windows.Forms.Button();
            this.btnNegativoComDMA = new System.Windows.Forms.Button();
            this.pictBoxRed = new System.Windows.Forms.PictureBox();
            this.pictBoxGreen = new System.Windows.Forms.PictureBox();
            this.pictBoxBlue = new System.Windows.Forms.PictureBox();
            this.pictBoxH = new System.Windows.Forms.PictureBox();
            this.pictBoxS = new System.Windows.Forms.PictureBox();
            this.pictBoxI = new System.Windows.Forms.PictureBox();
            this.pictureBoxPanel = new System.Windows.Forms.Panel();
            this.pictBoxImg = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.menuSuperiorPanel.SuspendLayout();
            this.menuLateralPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxI)).BeginInit();
            this.pictureBoxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg)).BeginInit();
            this.SuspendLayout();
            // 
            // menuSuperiorPanel
            // 
            this.menuSuperiorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuSuperiorPanel.Controls.Add(this.label13);
            this.menuSuperiorPanel.Controls.Add(this.label12);
            this.menuSuperiorPanel.Controls.Add(this.label11);
            this.menuSuperiorPanel.Controls.Add(this.minHue);
            this.menuSuperiorPanel.Controls.Add(this.maxHue);
            this.menuSuperiorPanel.Controls.Add(this.btnAbrirImagem);
            this.menuSuperiorPanel.Controls.Add(this.btnLimpar);
            this.menuSuperiorPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuSuperiorPanel.Location = new System.Drawing.Point(0, 0);
            this.menuSuperiorPanel.Margin = new System.Windows.Forms.Padding(4);
            this.menuSuperiorPanel.Name = "menuSuperiorPanel";
            this.menuSuperiorPanel.Size = new System.Drawing.Size(1768, 74);
            this.menuSuperiorPanel.TabIndex = 2;
            // 
            // minHue
            // 
            this.minHue.Location = new System.Drawing.Point(1523, 48);
            this.minHue.Name = "minHue";
            this.minHue.Size = new System.Drawing.Size(100, 22);
            this.minHue.TabIndex = 109;
            this.minHue.Text = "0";
            this.minHue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.minHue_KeyDown);
            // 
            // maxHue
            // 
            this.maxHue.Location = new System.Drawing.Point(1629, 48);
            this.maxHue.Name = "maxHue";
            this.maxHue.Size = new System.Drawing.Size(100, 22);
            this.maxHue.TabIndex = 108;
            this.maxHue.Text = "360";
            this.maxHue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maxHue_KeyDown);
            // 
            // btnAbrirImagem
            // 
            this.btnAbrirImagem.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAbrirImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirImagem.ForeColor = System.Drawing.Color.White;
            this.btnAbrirImagem.Location = new System.Drawing.Point(13, 12);
            this.btnAbrirImagem.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbrirImagem.Name = "btnAbrirImagem";
            this.btnAbrirImagem.Size = new System.Drawing.Size(160, 49);
            this.btnAbrirImagem.TabIndex = 106;
            this.btnAbrirImagem.Text = "Abrir Imagem";
            this.btnAbrirImagem.UseVisualStyleBackColor = false;
            this.btnAbrirImagem.Click += new System.EventHandler(this.btnAbrirImagem_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(187, 12);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(160, 49);
            this.btnLimpar.TabIndex = 107;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // menuLateralPanel
            // 
            this.menuLateralPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuLateralPanel.Controls.Add(this.label10);
            this.menuLateralPanel.Controls.Add(this.label9);
            this.menuLateralPanel.Controls.Add(this.label8);
            this.menuLateralPanel.Controls.Add(this.label7);
            this.menuLateralPanel.Controls.Add(this.button1);
            this.menuLateralPanel.Controls.Add(this.label6);
            this.menuLateralPanel.Controls.Add(this.label5);
            this.menuLateralPanel.Controls.Add(this.label4);
            this.menuLateralPanel.Controls.Add(this.label3);
            this.menuLateralPanel.Controls.Add(this.label2);
            this.menuLateralPanel.Controls.Add(this.trackBar2);
            this.menuLateralPanel.Controls.Add(this.label1);
            this.menuLateralPanel.Controls.Add(this.trackBar1);
            this.menuLateralPanel.Controls.Add(this.lblRGB);
            this.menuLateralPanel.Controls.Add(this.tbRGB);
            this.menuLateralPanel.Controls.Add(this.lblCMY);
            this.menuLateralPanel.Controls.Add(this.tbCMY);
            this.menuLateralPanel.Controls.Add(this.lblHSI);
            this.menuLateralPanel.Controls.Add(this.tbHSI);
            this.menuLateralPanel.Controls.Add(this.lblCoordinates);
            this.menuLateralPanel.Controls.Add(this.tbCoordinates);
            this.menuLateralPanel.Controls.Add(this.btnLuminanciaComDMA);
            this.menuLateralPanel.Controls.Add(this.btnNegativoComDMA);
            this.menuLateralPanel.Controls.Add(this.pictBoxRed);
            this.menuLateralPanel.Controls.Add(this.pictBoxGreen);
            this.menuLateralPanel.Controls.Add(this.pictBoxBlue);
            this.menuLateralPanel.Controls.Add(this.pictBoxH);
            this.menuLateralPanel.Controls.Add(this.pictBoxS);
            this.menuLateralPanel.Controls.Add(this.pictBoxI);
            this.menuLateralPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuLateralPanel.Location = new System.Drawing.Point(1475, 74);
            this.menuLateralPanel.Margin = new System.Windows.Forms.Padding(4);
            this.menuLateralPanel.Name = "menuLateralPanel";
            this.menuLateralPanel.Size = new System.Drawing.Size(293, 854);
            this.menuLateralPanel.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(238, 748);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 16);
            this.label10.TabIndex = 145;
            this.label10.Text = "I";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(141, 748);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 16);
            this.label9.TabIndex = 144;
            this.label9.Text = "S";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(139, 644);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 16);
            this.label8.TabIndex = 143;
            this.label8.Text = "G";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 644);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 16);
            this.label7.TabIndex = 142;
            this.label7.Text = "B";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(16, 585);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 49);
            this.button1.TabIndex = 141;
            this.button1.Text = "Gerar Miniaturas";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 748);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 16);
            this.label6.TabIndex = 140;
            this.label6.Text = "H";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 644);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 16);
            this.label5.TabIndex = 139;
            this.label5.Text = "R";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 503);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 16);
            this.label4.TabIndex = 132;
            this.label4.Text = "0°";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 16);
            this.label3.TabIndex = 131;
            this.label3.Text = "0%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 503);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 130;
            this.label2.Text = "Mudar Matiz (Hue):";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(16, 530);
            this.trackBar2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar2.Maximum = 180;
            this.trackBar2.Minimum = -180;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(261, 56);
            this.trackBar2.TabIndex = 129;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 128;
            this.label1.Text = "Ajustar Brilho:";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(13, 444);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = -100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(264, 56);
            this.trackBar1.TabIndex = 127;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lblRGB
            // 
            this.lblRGB.AutoSize = true;
            this.lblRGB.Location = new System.Drawing.Point(13, 25);
            this.lblRGB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRGB.Name = "lblRGB";
            this.lblRGB.Size = new System.Drawing.Size(39, 16);
            this.lblRGB.TabIndex = 116;
            this.lblRGB.Text = "RGB:";
            // 
            // tbRGB
            // 
            this.tbRGB.Location = new System.Drawing.Point(13, 49);
            this.tbRGB.Margin = new System.Windows.Forms.Padding(4);
            this.tbRGB.Name = "tbRGB";
            this.tbRGB.Size = new System.Drawing.Size(265, 22);
            this.tbRGB.TabIndex = 115;
            // 
            // lblCMY
            // 
            this.lblCMY.AutoSize = true;
            this.lblCMY.Location = new System.Drawing.Point(13, 86);
            this.lblCMY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCMY.Name = "lblCMY";
            this.lblCMY.Size = new System.Drawing.Size(39, 16);
            this.lblCMY.TabIndex = 118;
            this.lblCMY.Text = "CMY:";
            // 
            // tbCMY
            // 
            this.tbCMY.Location = new System.Drawing.Point(13, 111);
            this.tbCMY.Margin = new System.Windows.Forms.Padding(4);
            this.tbCMY.Name = "tbCMY";
            this.tbCMY.Size = new System.Drawing.Size(265, 22);
            this.tbCMY.TabIndex = 117;
            // 
            // lblHSI
            // 
            this.lblHSI.AutoSize = true;
            this.lblHSI.Location = new System.Drawing.Point(13, 148);
            this.lblHSI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHSI.Name = "lblHSI";
            this.lblHSI.Size = new System.Drawing.Size(32, 16);
            this.lblHSI.TabIndex = 120;
            this.lblHSI.Text = "HSI:";
            // 
            // tbHSI
            // 
            this.tbHSI.Location = new System.Drawing.Point(13, 172);
            this.tbHSI.Margin = new System.Windows.Forms.Padding(4);
            this.tbHSI.Name = "tbHSI";
            this.tbHSI.Size = new System.Drawing.Size(265, 22);
            this.tbHSI.TabIndex = 119;
            // 
            // lblCoordinates
            // 
            this.lblCoordinates.AutoSize = true;
            this.lblCoordinates.Location = new System.Drawing.Point(13, 209);
            this.lblCoordinates.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoordinates.Name = "lblCoordinates";
            this.lblCoordinates.Size = new System.Drawing.Size(93, 16);
            this.lblCoordinates.TabIndex = 122;
            this.lblCoordinates.Text = "Coordenadas:";
            // 
            // tbCoordinates
            // 
            this.tbCoordinates.Location = new System.Drawing.Point(13, 234);
            this.tbCoordinates.Margin = new System.Windows.Forms.Padding(4);
            this.tbCoordinates.Name = "tbCoordinates";
            this.tbCoordinates.Size = new System.Drawing.Size(265, 22);
            this.tbCoordinates.TabIndex = 121;
            // 
            // btnLuminanciaComDMA
            // 
            this.btnLuminanciaComDMA.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLuminanciaComDMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuminanciaComDMA.ForeColor = System.Drawing.Color.White;
            this.btnLuminanciaComDMA.Location = new System.Drawing.Point(13, 283);
            this.btnLuminanciaComDMA.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuminanciaComDMA.Name = "btnLuminanciaComDMA";
            this.btnLuminanciaComDMA.Size = new System.Drawing.Size(267, 49);
            this.btnLuminanciaComDMA.TabIndex = 109;
            this.btnLuminanciaComDMA.Text = "Luminância com DMA";
            this.btnLuminanciaComDMA.UseVisualStyleBackColor = false;
            this.btnLuminanciaComDMA.Click += new System.EventHandler(this.btnLuminanciaComDMA_Click);
            // 
            // btnNegativoComDMA
            // 
            this.btnNegativoComDMA.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNegativoComDMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNegativoComDMA.ForeColor = System.Drawing.Color.White;
            this.btnNegativoComDMA.Location = new System.Drawing.Point(13, 345);
            this.btnNegativoComDMA.Margin = new System.Windows.Forms.Padding(4);
            this.btnNegativoComDMA.Name = "btnNegativoComDMA";
            this.btnNegativoComDMA.Size = new System.Drawing.Size(267, 49);
            this.btnNegativoComDMA.TabIndex = 111;
            this.btnNegativoComDMA.Text = "Negativo com DMA";
            this.btnNegativoComDMA.UseVisualStyleBackColor = false;
            this.btnNegativoComDMA.Click += new System.EventHandler(this.btnNegativoComDMA_Click);
            // 
            // pictBoxRed
            // 
            this.pictBoxRed.BackColor = System.Drawing.Color.White;
            this.pictBoxRed.Location = new System.Drawing.Point(13, 664);
            this.pictBoxRed.Margin = new System.Windows.Forms.Padding(4);
            this.pictBoxRed.Name = "pictBoxRed";
            this.pictBoxRed.Size = new System.Drawing.Size(80, 74);
            this.pictBoxRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictBoxRed.TabIndex = 133;
            this.pictBoxRed.TabStop = false;
            // 
            // pictBoxGreen
            // 
            this.pictBoxGreen.BackColor = System.Drawing.Color.White;
            this.pictBoxGreen.Location = new System.Drawing.Point(107, 664);
            this.pictBoxGreen.Margin = new System.Windows.Forms.Padding(4);
            this.pictBoxGreen.Name = "pictBoxGreen";
            this.pictBoxGreen.Size = new System.Drawing.Size(80, 74);
            this.pictBoxGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictBoxGreen.TabIndex = 134;
            this.pictBoxGreen.TabStop = false;
            // 
            // pictBoxBlue
            // 
            this.pictBoxBlue.BackColor = System.Drawing.Color.White;
            this.pictBoxBlue.Location = new System.Drawing.Point(200, 664);
            this.pictBoxBlue.Margin = new System.Windows.Forms.Padding(4);
            this.pictBoxBlue.Name = "pictBoxBlue";
            this.pictBoxBlue.Size = new System.Drawing.Size(80, 74);
            this.pictBoxBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictBoxBlue.TabIndex = 135;
            this.pictBoxBlue.TabStop = false;
            // 
            // pictBoxH
            // 
            this.pictBoxH.BackColor = System.Drawing.Color.White;
            this.pictBoxH.Location = new System.Drawing.Point(13, 768);
            this.pictBoxH.Margin = new System.Windows.Forms.Padding(4);
            this.pictBoxH.Name = "pictBoxH";
            this.pictBoxH.Size = new System.Drawing.Size(80, 74);
            this.pictBoxH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictBoxH.TabIndex = 136;
            this.pictBoxH.TabStop = false;
            // 
            // pictBoxS
            // 
            this.pictBoxS.BackColor = System.Drawing.Color.White;
            this.pictBoxS.Location = new System.Drawing.Point(107, 768);
            this.pictBoxS.Margin = new System.Windows.Forms.Padding(4);
            this.pictBoxS.Name = "pictBoxS";
            this.pictBoxS.Size = new System.Drawing.Size(80, 74);
            this.pictBoxS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictBoxS.TabIndex = 137;
            this.pictBoxS.TabStop = false;
            // 
            // pictBoxI
            // 
            this.pictBoxI.BackColor = System.Drawing.Color.White;
            this.pictBoxI.Location = new System.Drawing.Point(200, 768);
            this.pictBoxI.Margin = new System.Windows.Forms.Padding(4);
            this.pictBoxI.Name = "pictBoxI";
            this.pictBoxI.Size = new System.Drawing.Size(80, 74);
            this.pictBoxI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictBoxI.TabIndex = 138;
            this.pictBoxI.TabStop = false;
            // 
            // pictureBoxPanel
            // 
            this.pictureBoxPanel.BackColor = System.Drawing.Color.White;
            this.pictureBoxPanel.Controls.Add(this.pictBoxImg);
            this.pictureBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPanel.Location = new System.Drawing.Point(0, 74);
            this.pictureBoxPanel.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPanel.Name = "pictureBoxPanel";
            this.pictureBoxPanel.Size = new System.Drawing.Size(1475, 854);
            this.pictureBoxPanel.TabIndex = 0;
            // 
            // pictBoxImg
            // 
            this.pictBoxImg.BackColor = System.Drawing.Color.White;
            this.pictBoxImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictBoxImg.Location = new System.Drawing.Point(0, 0);
            this.pictBoxImg.Margin = new System.Windows.Forms.Padding(4);
            this.pictBoxImg.Name = "pictBoxImg";
            this.pictBoxImg.Size = new System.Drawing.Size(1475, 854);
            this.pictBoxImg.TabIndex = 0;
            this.pictBoxImg.TabStop = false;
            this.pictBoxImg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictBoxImg_MouseMove);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(1521, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 16);
            this.label11.TabIndex = 110;
            this.label11.Text = "Filtrar Matiz (Hue):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(1521, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 16);
            this.label12.TabIndex = 111;
            this.label12.Text = "Min:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(1626, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 16);
            this.label13.TabIndex = 112;
            this.label13.Text = "Max:";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1768, 928);
            this.Controls.Add(this.pictureBoxPanel);
            this.Controls.Add(this.menuLateralPanel);
            this.Controls.Add(this.menuSuperiorPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Processamento de Imagens";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuSuperiorPanel.ResumeLayout(false);
            this.menuSuperiorPanel.PerformLayout();
            this.menuLateralPanel.ResumeLayout(false);
            this.menuLateralPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxI)).EndInit();
            this.pictureBoxPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel menuSuperiorPanel;
        private System.Windows.Forms.Button btnAbrirImagem;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Panel menuLateralPanel;
        private System.Windows.Forms.TextBox tbRGB;
        private System.Windows.Forms.TextBox tbCMY;
        private System.Windows.Forms.TextBox tbHSI;
        private System.Windows.Forms.TextBox tbCoordinates;
        private System.Windows.Forms.Button btnLuminanciaComDMA;
        private System.Windows.Forms.Button btnNegativoComDMA;
        private System.Windows.Forms.Panel pictureBoxPanel;
        private System.Windows.Forms.PictureBox pictBoxImg;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lblRGB;
        private System.Windows.Forms.Label lblCMY;
        private System.Windows.Forms.Label lblHSI;
        private System.Windows.Forms.Label lblCoordinates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictBoxRed;
        private System.Windows.Forms.PictureBox pictBoxBlue;
        private System.Windows.Forms.PictureBox pictBoxGreen;
        private System.Windows.Forms.PictureBox pictBoxH;
        private System.Windows.Forms.PictureBox pictBoxS;
        private System.Windows.Forms.PictureBox pictBoxI;
        private Button button1;
        private Label label6;
        private Label label5;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox minHue;
        private TextBox maxHue;
        private Label label11;
        private Label label13;
        private Label label12;
    }
}