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
            this.btnAbrirImagem = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.menuLateralPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.tbHue = new System.Windows.Forms.TextBox();
            this.tbBrilho = new System.Windows.Forms.TextBox();
            this.btnAjustarHue = new System.Windows.Forms.Button();
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
            this.pictureBoxPanel = new System.Windows.Forms.Panel();
            this.pictBoxImg = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuSuperiorPanel.SuspendLayout();
            this.menuLateralPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.pictureBoxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg)).BeginInit();
            this.SuspendLayout();
            // 
            // menuSuperiorPanel
            // 
            this.menuSuperiorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuSuperiorPanel.Controls.Add(this.btnAbrirImagem);
            this.menuSuperiorPanel.Controls.Add(this.btnLimpar);
            this.menuSuperiorPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuSuperiorPanel.Location = new System.Drawing.Point(0, 0);
            this.menuSuperiorPanel.Margin = new System.Windows.Forms.Padding(4);
            this.menuSuperiorPanel.Name = "menuSuperiorPanel";
            this.menuSuperiorPanel.Size = new System.Drawing.Size(1627, 74);
            this.menuSuperiorPanel.TabIndex = 2;
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
            this.menuLateralPanel.Controls.Add(this.label1);
            this.menuLateralPanel.Controls.Add(this.trackBar1);
            this.menuLateralPanel.Controls.Add(this.tbHue);
            this.menuLateralPanel.Controls.Add(this.tbBrilho);
            this.menuLateralPanel.Controls.Add(this.btnAjustarHue);
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
            this.menuLateralPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuLateralPanel.Location = new System.Drawing.Point(1334, 74);
            this.menuLateralPanel.Margin = new System.Windows.Forms.Padding(4);
            this.menuLateralPanel.Name = "menuLateralPanel";
            this.menuLateralPanel.Size = new System.Drawing.Size(293, 674);
            this.menuLateralPanel.TabIndex = 1;
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
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = -100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(264, 56);
            this.trackBar1.TabIndex = 127;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // tbHue
            // 
            this.tbHue.Location = new System.Drawing.Point(13, 624);
            this.tbHue.Margin = new System.Windows.Forms.Padding(4);
            this.tbHue.Name = "tbHue";
            this.tbHue.Size = new System.Drawing.Size(265, 22);
            this.tbHue.TabIndex = 126;
            this.tbHue.Text = "0";
            // 
            // tbBrilho
            // 
            this.tbBrilho.Location = new System.Drawing.Point(13, 594);
            this.tbBrilho.Margin = new System.Windows.Forms.Padding(4);
            this.tbBrilho.Name = "tbBrilho";
            this.tbBrilho.Size = new System.Drawing.Size(265, 22);
            this.tbBrilho.TabIndex = 125;
            this.tbBrilho.Text = "0";
            // 
            // btnAjustarHue
            // 
            this.btnAjustarHue.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAjustarHue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjustarHue.ForeColor = System.Drawing.Color.White;
            this.btnAjustarHue.Location = new System.Drawing.Point(16, 537);
            this.btnAjustarHue.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjustarHue.Name = "btnAjustarHue";
            this.btnAjustarHue.Size = new System.Drawing.Size(267, 49);
            this.btnAjustarHue.TabIndex = 124;
            this.btnAjustarHue.Text = "Ajustar Hue";
            this.btnAjustarHue.UseVisualStyleBackColor = false;
            this.btnAjustarHue.Click += new System.EventHandler(this.btnAjustarHue_Click);
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
            // pictureBoxPanel
            // 
            this.pictureBoxPanel.BackColor = System.Drawing.Color.White;
            this.pictureBoxPanel.Controls.Add(this.pictBoxImg);
            this.pictureBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPanel.Location = new System.Drawing.Point(0, 74);
            this.pictureBoxPanel.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPanel.Name = "pictureBoxPanel";
            this.pictureBoxPanel.Size = new System.Drawing.Size(1334, 674);
            this.pictureBoxPanel.TabIndex = 0;
            // 
            // pictBoxImg
            // 
            this.pictBoxImg.BackColor = System.Drawing.Color.White;
            this.pictBoxImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictBoxImg.Location = new System.Drawing.Point(0, 0);
            this.pictBoxImg.Margin = new System.Windows.Forms.Padding(4);
            this.pictBoxImg.Name = "pictBoxImg";
            this.pictBoxImg.Size = new System.Drawing.Size(1334, 674);
            this.pictBoxImg.TabIndex = 0;
            this.pictBoxImg.TabStop = false;
            this.pictBoxImg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictBoxImg_MouseMove);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1627, 748);
            this.Controls.Add(this.pictureBoxPanel);
            this.Controls.Add(this.menuLateralPanel);
            this.Controls.Add(this.menuSuperiorPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Processamento de Imagens";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuSuperiorPanel.ResumeLayout(false);
            this.menuLateralPanel.ResumeLayout(false);
            this.menuLateralPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
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
        private System.Windows.Forms.Button btnAjustarHue;
        private System.Windows.Forms.TextBox tbBrilho;
        private System.Windows.Forms.TextBox tbHue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}