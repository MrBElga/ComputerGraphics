namespace ProcessamentoImagens
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictBoxImg1 = new PictureBox();
            pictBoxImg2 = new PictureBox();
            btnAbrirImagem = new Button();
            openFileDialog = new OpenFileDialog();
            btnLimpar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictBoxImg1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictBoxImg2).BeginInit();
            SuspendLayout();
            // 
            // pictBoxImg1
            // 
            pictBoxImg1.BackColor = SystemColors.ControlLightLight;
            pictBoxImg1.Location = new Point(6, 7);
            pictBoxImg1.Margin = new Padding(4, 3, 4, 3);
            pictBoxImg1.Name = "pictBoxImg1";
            pictBoxImg1.Size = new Size(700, 577);
            pictBoxImg1.TabIndex = 102;
            pictBoxImg1.TabStop = false;
            // 
            // pictBoxImg2
            // 
            pictBoxImg2.BackColor = SystemColors.ControlLightLight;
            pictBoxImg2.Location = new Point(713, 7);
            pictBoxImg2.Margin = new Padding(4, 3, 4, 3);
            pictBoxImg2.Name = "pictBoxImg2";
            pictBoxImg2.Size = new Size(700, 577);
            pictBoxImg2.TabIndex = 105;
            pictBoxImg2.TabStop = false;
            // 
            // btnAbrirImagem
            // 
            btnAbrirImagem.Location = new Point(6, 591);
            btnAbrirImagem.Margin = new Padding(4, 3, 4, 3);
            btnAbrirImagem.Name = "btnAbrirImagem";
            btnAbrirImagem.Size = new Size(118, 27);
            btnAbrirImagem.TabIndex = 106;
            btnAbrirImagem.Text = "Abrir Imagem";
            btnAbrirImagem.UseVisualStyleBackColor = true;
            btnAbrirImagem.Click += btnAbrirImagem_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(131, 591);
            btnLimpar.Margin = new Padding(4, 3, 4, 3);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(118, 27);
            btnLimpar.TabIndex = 107;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1423, 702);
            Controls.Add(btnLimpar);
            Controls.Add(btnAbrirImagem);
            Controls.Add(pictBoxImg2);
            Controls.Add(pictBoxImg1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulário Principal";
            ((System.ComponentModel.ISupportInitialize)pictBoxImg1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictBoxImg2).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictBoxImg1;
        private System.Windows.Forms.PictureBox pictBoxImg2;
        private System.Windows.Forms.Button btnAbrirImagem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private Button btnLimpar;
    }
}

