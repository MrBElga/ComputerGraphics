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
            this.tbCoordinates = new System.Windows.Forms.TextBox();
            this.btnLuminanciaComDMA = new System.Windows.Forms.Button();
            this.btnNegativoComDMA = new System.Windows.Forms.Button();
            this.pictureBoxPanel = new System.Windows.Forms.Panel();
            this.pictBoxImg = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tbHSI = new System.Windows.Forms.TextBox();
            this.tbCMY = new System.Windows.Forms.TextBox();
            this.tbRGB = new System.Windows.Forms.TextBox();
            this.menuSuperiorPanel.SuspendLayout();
            this.menuLateralPanel.SuspendLayout();
            this.pictureBoxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg)).BeginInit();
            this.SuspendLayout();
            // 
            // menuSuperiorPanel
            // 
            this.menuSuperiorPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuSuperiorPanel.Controls.Add(this.btnAbrirImagem);
            this.menuSuperiorPanel.Controls.Add(this.btnLimpar);
            this.menuSuperiorPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuSuperiorPanel.Location = new System.Drawing.Point(0, 0);
            this.menuSuperiorPanel.Name = "menuSuperiorPanel";
            this.menuSuperiorPanel.Size = new System.Drawing.Size(1220, 50);
            this.menuSuperiorPanel.TabIndex = 2;
            // 
            // btnAbrirImagem
            // 
            this.btnAbrirImagem.Location = new System.Drawing.Point(5, 12);
            this.btnAbrirImagem.Name = "btnAbrirImagem";
            this.btnAbrirImagem.Size = new System.Drawing.Size(101, 23);
            this.btnAbrirImagem.TabIndex = 106;
            this.btnAbrirImagem.Text = "Abrir Imagem";
            this.btnAbrirImagem.UseVisualStyleBackColor = true;
            this.btnAbrirImagem.Click += new System.EventHandler(this.btnAbrirImagem_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(112, 12);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(101, 23);
            this.btnLimpar.TabIndex = 107;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // menuLateralPanel
            // 
            this.menuLateralPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuLateralPanel.Controls.Add(this.tbRGB);
            this.menuLateralPanel.Controls.Add(this.tbCMY);
            this.menuLateralPanel.Controls.Add(this.tbHSI);
            this.menuLateralPanel.Controls.Add(this.tbCoordinates);
            this.menuLateralPanel.Controls.Add(this.btnLuminanciaComDMA);
            this.menuLateralPanel.Controls.Add(this.btnNegativoComDMA);
            this.menuLateralPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuLateralPanel.Location = new System.Drawing.Point(1020, 50);
            this.menuLateralPanel.Name = "menuLateralPanel";
            this.menuLateralPanel.Size = new System.Drawing.Size(200, 558);
            this.menuLateralPanel.TabIndex = 1;
            // 
            // tbCoordinates
            // 
            this.tbCoordinates.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbCoordinates.Location = new System.Drawing.Point(0, 538);
            this.tbCoordinates.Name = "tbCoordinates";
            this.tbCoordinates.Size = new System.Drawing.Size(200, 20);
            this.tbCoordinates.TabIndex = 112;
            this.tbCoordinates.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCoordinates.UseWaitCursor = true;
            // 
            // btnLuminanciaComDMA
            // 
            this.btnLuminanciaComDMA.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLuminanciaComDMA.Location = new System.Drawing.Point(0, 23);
            this.btnLuminanciaComDMA.Name = "btnLuminanciaComDMA";
            this.btnLuminanciaComDMA.Size = new System.Drawing.Size(200, 23);
            this.btnLuminanciaComDMA.TabIndex = 109;
            this.btnLuminanciaComDMA.Text = "Luminância com DMA";
            this.btnLuminanciaComDMA.UseVisualStyleBackColor = true;
            this.btnLuminanciaComDMA.Click += new System.EventHandler(this.btnLuminanciaComDMA_Click);
            // 
            // btnNegativoComDMA
            // 
            this.btnNegativoComDMA.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNegativoComDMA.Location = new System.Drawing.Point(0, 0);
            this.btnNegativoComDMA.Name = "btnNegativoComDMA";
            this.btnNegativoComDMA.Size = new System.Drawing.Size(200, 23);
            this.btnNegativoComDMA.TabIndex = 111;
            this.btnNegativoComDMA.Text = "Negativo com DMA";
            this.btnNegativoComDMA.UseVisualStyleBackColor = true;
            this.btnNegativoComDMA.Click += new System.EventHandler(this.btnNegativoComDMA_Click);
            // 
            // pictureBoxPanel
            // 
            this.pictureBoxPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBoxPanel.Controls.Add(this.pictBoxImg);
            this.pictureBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPanel.Location = new System.Drawing.Point(0, 50);
            this.pictureBoxPanel.Name = "pictureBoxPanel";
            this.pictureBoxPanel.Size = new System.Drawing.Size(1020, 558);
            this.pictureBoxPanel.TabIndex = 0;
            // 
            // pictBoxImg
            // 
            this.pictBoxImg.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictBoxImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictBoxImg.Location = new System.Drawing.Point(0, 0);
            this.pictBoxImg.Name = "pictBoxImg";
            this.pictBoxImg.Size = new System.Drawing.Size(1020, 558);
            this.pictBoxImg.TabIndex = 0;
            this.pictBoxImg.TabStop = false;
            this.pictBoxImg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictBoxImg_MouseMove);
            // 
            // tbHSI
            // 
            this.tbHSI.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbHSI.Location = new System.Drawing.Point(0, 518);
            this.tbHSI.Name = "tbHSI";
            this.tbHSI.Size = new System.Drawing.Size(200, 20);
            this.tbHSI.TabIndex = 113;
            this.tbHSI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbHSI.UseWaitCursor = true;
            // 
            // tbCMY
            // 
            this.tbCMY.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbCMY.Location = new System.Drawing.Point(0, 498);
            this.tbCMY.Name = "tbCMY";
            this.tbCMY.Size = new System.Drawing.Size(200, 20);
            this.tbCMY.TabIndex = 114;
            this.tbCMY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCMY.UseWaitCursor = true;
            // 
            // tbRGB
            // 
            this.tbRGB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbRGB.Location = new System.Drawing.Point(0, 478);
            this.tbRGB.Name = "tbRGB";
            this.tbRGB.Size = new System.Drawing.Size(200, 20);
            this.tbRGB.TabIndex = 115;
            this.tbRGB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRGB.UseWaitCursor = true;
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
            this.Text = "Formulário Principal";
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
        private System.Windows.Forms.Panel menuLateralPanel;
        private System.Windows.Forms.Panel pictureBoxPanel;
        private System.Windows.Forms.PictureBox pictBoxImg;
        private System.Windows.Forms.Button btnAbrirImagem;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnLuminanciaComDMA;
        private System.Windows.Forms.Button btnNegativoComDMA;
        private System.Windows.Forms.TextBox tbCoordinates;
        private System.Windows.Forms.TextBox tbRGB;
        private System.Windows.Forms.TextBox tbCMY;
        private System.Windows.Forms.TextBox tbHSI;
    }
}
