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
            this.btnAjustarBrilho = new System.Windows.Forms.Button();
            this.btnAjustarHue = new System.Windows.Forms.Button();
            this.tbBrilho = new System.Windows.Forms.TextBox();
            this.tbHue = new System.Windows.Forms.TextBox();
            this.pictureBoxPanel = new System.Windows.Forms.Panel();
            this.pictBoxImg = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuSuperiorPanel.SuspendLayout();
            this.menuLateralPanel.SuspendLayout();
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
            this.menuSuperiorPanel.Name = "menuSuperiorPanel";
            this.menuSuperiorPanel.Size = new System.Drawing.Size(1220, 60);
            this.menuSuperiorPanel.TabIndex = 2;
            // 
            // btnAbrirImagem
            // 
            this.btnAbrirImagem.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAbrirImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirImagem.ForeColor = System.Drawing.Color.White;
            this.btnAbrirImagem.Location = new System.Drawing.Point(10, 10);
            this.btnAbrirImagem.Name = "btnAbrirImagem";
            this.btnAbrirImagem.Size = new System.Drawing.Size(120, 40);
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
            this.btnLimpar.Location = new System.Drawing.Point(140, 10);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(120, 40);
            this.btnLimpar.TabIndex = 107;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // menuLateralPanel
            // 
            this.menuLateralPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuLateralPanel.Controls.Add(this.tbHue);
            this.menuLateralPanel.Controls.Add(this.tbBrilho);
            this.menuLateralPanel.Controls.Add(this.btnAjustarHue);
            this.menuLateralPanel.Controls.Add(this.btnAjustarBrilho);
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
            this.menuLateralPanel.Location = new System.Drawing.Point(1000, 60);
            this.menuLateralPanel.Name = "menuLateralPanel";
            this.menuLateralPanel.Size = new System.Drawing.Size(220, 548);
            this.menuLateralPanel.TabIndex = 1;
            // 
            // lblRGB
            // 
            this.lblRGB.AutoSize = true;
            this.lblRGB.Location = new System.Drawing.Point(10, 20);
            this.lblRGB.Name = "lblRGB";
            this.lblRGB.Size = new System.Drawing.Size(33, 13);
            this.lblRGB.TabIndex = 116;
            this.lblRGB.Text = "RGB:";
            // 
            // tbRGB
            // 
            this.tbRGB.Location = new System.Drawing.Point(10, 40);
            this.tbRGB.Name = "tbRGB";
            this.tbRGB.Size = new System.Drawing.Size(200, 20);
            this.tbRGB.TabIndex = 115;
            // 
            // lblCMY
            // 
            this.lblCMY.AutoSize = true;
            this.lblCMY.Location = new System.Drawing.Point(10, 70);
            this.lblCMY.Name = "lblCMY";
            this.lblCMY.Size = new System.Drawing.Size(34, 13);
            this.lblCMY.TabIndex = 118;
            this.lblCMY.Text = "CMY:";
            // 
            // tbCMY
            // 
            this.tbCMY.Location = new System.Drawing.Point(10, 90);
            this.tbCMY.Name = "tbCMY";
            this.tbCMY.Size = new System.Drawing.Size(200, 20);
            this.tbCMY.TabIndex = 117;
            // 
            // lblHSI
            // 
            this.lblHSI.AutoSize = true;
            this.lblHSI.Location = new System.Drawing.Point(10, 120);
            this.lblHSI.Name = "lblHSI";
            this.lblHSI.Size = new System.Drawing.Size(28, 13);
            this.lblHSI.TabIndex = 120;
            this.lblHSI.Text = "HSI:";
            // 
            // tbHSI
            // 
            this.tbHSI.Location = new System.Drawing.Point(10, 140);
            this.tbHSI.Name = "tbHSI";
            this.tbHSI.Size = new System.Drawing.Size(200, 20);
            this.tbHSI.TabIndex = 119;
            // 
            // lblCoordinates
            // 
            this.lblCoordinates.AutoSize = true;
            this.lblCoordinates.Location = new System.Drawing.Point(10, 170);
            this.lblCoordinates.Name = "lblCoordinates";
            this.lblCoordinates.Size = new System.Drawing.Size(63, 13);
            this.lblCoordinates.TabIndex = 122;
            this.lblCoordinates.Text = "Coordenadas:";
            // 
            // tbCoordinates
            // 
            this.tbCoordinates.Location = new System.Drawing.Point(10, 190);
            this.tbCoordinates.Name = "tbCoordinates";
            this.tbCoordinates.Size = new System.Drawing.Size(200, 20);
            this.tbCoordinates.TabIndex = 121;
            // 
            // btnLuminanciaComDMA
            // 
            this.btnLuminanciaComDMA.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLuminanciaComDMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuminanciaComDMA.ForeColor = System.Drawing.Color.White;
            this.btnLuminanciaComDMA.Location = new System.Drawing.Point(10, 230);
            this.btnLuminanciaComDMA.Name = "btnLuminanciaComDMA";
            this.btnLuminanciaComDMA.Size = new System.Drawing.Size(200, 40);
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
            this.btnNegativoComDMA.Location = new System.Drawing.Point(10, 280);
            this.btnNegativoComDMA.Name = "btnNegativoComDMA";
            this.btnNegativoComDMA.Size = new System.Drawing.Size(200, 40);
            this.btnNegativoComDMA.TabIndex = 111;
            this.btnNegativoComDMA.Text = "Negativo com DMA";
            this.btnNegativoComDMA.UseVisualStyleBackColor = false;
            this.btnNegativoComDMA.Click += new System.EventHandler(this.btnNegativoComDMA_Click);
            // 
            // btnAjustarBrilho
            // 
            this.btnAjustarBrilho.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAjustarBrilho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjustarBrilho.ForeColor = System.Drawing.Color.White;
            this.btnAjustarBrilho.Location = new System.Drawing.Point(10, 330);
            this.btnAjustarBrilho.Name = "btnAjustarBrilho";
            this.btnAjustarBrilho.Size = new System.Drawing.Size(200, 40);
            this.btnAjustarBrilho.TabIndex = 123;
            this.btnAjustarBrilho.Text = "Ajustar Brilho";
            this.btnAjustarBrilho.UseVisualStyleBackColor = false;
            this.btnAjustarBrilho.Click += new System.EventHandler(this.btnAjustarBrilho_Click);
            // 
            // btnAjustarHue
            // 
            this.btnAjustarHue.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAjustarHue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjustarHue.ForeColor = System.Drawing.Color.White;
            this.btnAjustarHue.Location = new System.Drawing.Point(10, 380);
            this.btnAjustarHue.Name = "btnAjustarHue";
            this.btnAjustarHue.Size = new System.Drawing.Size(200, 40);
            this.btnAjustarHue.TabIndex = 124;
            this.btnAjustarHue.Text = "Ajustar Hue";
            this.btnAjustarHue.UseVisualStyleBackColor = false;
            this.btnAjustarHue.Click += new System.EventHandler(this.btnAjustarHue_Click);
            // 
            // tbBrilho
            // 
            this.tbBrilho.Location = new System.Drawing.Point(10, 430);
            this.tbBrilho.Name = "tbBrilho";
            this.tbBrilho.Size = new System.Drawing.Size(200, 20);
            this.tbBrilho.TabIndex = 125;
            this.tbBrilho.Text = "0";
            // 
            // tbHue
            // 
            this.tbHue.Location = new System.Drawing.Point(10, 480);
            this.tbHue.Name = "tbHue";
            this.tbHue.Size = new System.Drawing.Size(200, 20);
            this.tbHue.TabIndex = 126;
            this.tbHue.Text = "0";
            // 
            // pictureBoxPanel
            // 
            this.pictureBoxPanel.BackColor = System.Drawing.Color.White;
            this.pictureBoxPanel.Controls.Add(this.pictBoxImg);
            this.pictureBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPanel.Location = new System.Drawing.Point(0, 60);
            this.pictureBoxPanel.Name = "pictureBoxPanel";
            this.pictureBoxPanel.Size = new System.Drawing.Size(1000, 548);
            this.pictureBoxPanel.TabIndex = 0;
            // 
            // pictBoxImg
            // 
            this.pictBoxImg.BackColor = System.Drawing.Color.White;
            this.pictBoxImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictBoxImg.Location = new System.Drawing.Point(0, 0);
            this.pictBoxImg.Name = "pictBoxImg";
            this.pictBoxImg.Size = new System.Drawing.Size(1000, 548);
            this.pictBoxImg.TabIndex = 0;
            this.pictBoxImg.TabStop = false;
            this.pictBoxImg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictBoxImg_MouseMove);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 608);
            this.Controls.Add(this.pictureBoxPanel);
            this.Controls.Add(this.menuLateralPanel);
            this.Controls.Add(this.menuSuperiorPanel);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Processamento de Imagens";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuSuperiorPanel.ResumeLayout(false);
            this.menuLateralPanel.ResumeLayout(false);
            this.menuLateralPanel.PerformLayout();
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
        private System.Windows.Forms.Button btnAjustarBrilho;
        private System.Windows.Forms.Button btnAjustarHue;
        private System.Windows.Forms.TextBox tbBrilho;
        private System.Windows.Forms.TextBox tbHue;
    }
}