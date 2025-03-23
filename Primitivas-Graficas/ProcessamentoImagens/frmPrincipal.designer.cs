namespace RawLine
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.gbRetas = new System.Windows.Forms.GroupBox();
            this.rdReta = new System.Windows.Forms.RadioButton();
            this.rdBresenham = new System.Windows.Forms.RadioButton();
            this.rdDDA = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdCircMed = new System.Windows.Forms.RadioButton();
            this.rdTrig = new System.Windows.Forms.RadioButton();
            this.rdCirc = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdEliMed = new System.Windows.Forms.RadioButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Graphs = new System.Windows.Forms.ListBox();
            this.MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btApagar = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tabIndex = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.polysPoints = new System.Windows.Forms.ListBox();
            this.polist = new System.Windows.Forms.ListBox();
            this.btCriaPoly = new System.Windows.Forms.Button();
            this.btApagaPoly = new System.Windows.Forms.Button();
            this.scrollBar = new System.Windows.Forms.VScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.pnScroll = new System.Windows.Forms.Panel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btScan = new System.Windows.Forms.Button();
            this.btFlood = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btDiag = new System.Windows.Forms.Button();
            this.btVert = new System.Windows.Forms.Button();
            this.btHoriz = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.numAngle = new System.Windows.Forms.NumericUpDown();
            this.btRotation = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.numY = new System.Windows.Forms.NumericUpDown();
            this.btShearXY = new System.Windows.Forms.Button();
            this.btShearY = new System.Windows.Forms.Button();
            this.numX = new System.Windows.Forms.NumericUpDown();
            this.btShearX = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtValueTranslacao = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btTranslacao = new System.Windows.Forms.Button();
            this.slideTransalacao = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtValueEscala = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btEscala = new System.Windows.Forms.Button();
            this.slideEscala = new System.Windows.Forms.TrackBar();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ViewPort = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.gbRetas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.tabIndex.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnScroll.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAngle)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slideTransalacao)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slideEscala)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewPort)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picBox.Location = new System.Drawing.Point(12, 12);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(630, 505);
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            this.picBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseDown);
            this.picBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseMove);
            this.picBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseUp);
            // 
            // gbRetas
            // 
            this.gbRetas.Controls.Add(this.rdReta);
            this.gbRetas.Controls.Add(this.rdBresenham);
            this.gbRetas.Controls.Add(this.rdDDA);
            this.gbRetas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRetas.Location = new System.Drawing.Point(6, 6);
            this.gbRetas.Name = "gbRetas";
            this.gbRetas.Size = new System.Drawing.Size(265, 121);
            this.gbRetas.TabIndex = 1;
            this.gbRetas.TabStop = false;
            this.gbRetas.Text = "Retas";
            // 
            // rdReta
            // 
            this.rdReta.AutoSize = true;
            this.rdReta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdReta.Location = new System.Drawing.Point(18, 27);
            this.rdReta.Name = "rdReta";
            this.rdReta.Size = new System.Drawing.Size(158, 21);
            this.rdReta.TabIndex = 0;
            this.rdReta.TabStop = true;
            this.rdReta.Text = "Equação Real da Reta";
            this.rdReta.UseVisualStyleBackColor = true;
            this.rdReta.Click += new System.EventHandler(this.CheckedChanged);
            // 
            // rdBresenham
            // 
            this.rdBresenham.AutoSize = true;
            this.rdBresenham.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBresenham.ForeColor = System.Drawing.Color.Black;
            this.rdBresenham.Location = new System.Drawing.Point(18, 81);
            this.rdBresenham.Name = "rdBresenham";
            this.rdBresenham.Size = new System.Drawing.Size(91, 21);
            this.rdBresenham.TabIndex = 2;
            this.rdBresenham.TabStop = true;
            this.rdBresenham.Text = "Bresenham";
            this.rdBresenham.UseVisualStyleBackColor = true;
            this.rdBresenham.Click += new System.EventHandler(this.CheckedChanged);
            // 
            // rdDDA
            // 
            this.rdDDA.AutoSize = true;
            this.rdDDA.Checked = true;
            this.rdDDA.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDDA.ForeColor = System.Drawing.Color.Black;
            this.rdDDA.Location = new System.Drawing.Point(18, 54);
            this.rdDDA.Name = "rdDDA";
            this.rdDDA.Size = new System.Drawing.Size(53, 21);
            this.rdDDA.TabIndex = 1;
            this.rdDDA.TabStop = true;
            this.rdDDA.Text = "DDA";
            this.rdDDA.UseVisualStyleBackColor = true;
            this.rdDDA.Click += new System.EventHandler(this.CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdCircMed);
            this.groupBox1.Controls.Add(this.rdTrig);
            this.groupBox1.Controls.Add(this.rdCirc);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 143);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Circunferência";
            // 
            // rdCircMed
            // 
            this.rdCircMed.AutoSize = true;
            this.rdCircMed.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCircMed.ForeColor = System.Drawing.Color.Black;
            this.rdCircMed.Location = new System.Drawing.Point(18, 97);
            this.rdCircMed.Name = "rdCircMed";
            this.rdCircMed.Size = new System.Drawing.Size(102, 21);
            this.rdCircMed.TabIndex = 2;
            this.rdCircMed.TabStop = true;
            this.rdCircMed.Text = "Ponto Médio";
            this.rdCircMed.UseVisualStyleBackColor = true;
            this.rdCircMed.Click += new System.EventHandler(this.CheckedChanged);
            // 
            // rdTrig
            // 
            this.rdTrig.AutoSize = true;
            this.rdTrig.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTrig.ForeColor = System.Drawing.Color.Black;
            this.rdTrig.Location = new System.Drawing.Point(18, 70);
            this.rdTrig.Name = "rdTrig";
            this.rdTrig.Size = new System.Drawing.Size(108, 21);
            this.rdTrig.TabIndex = 1;
            this.rdTrig.TabStop = true;
            this.rdTrig.Text = "Trigonometria";
            this.rdTrig.UseVisualStyleBackColor = true;
            this.rdTrig.Click += new System.EventHandler(this.CheckedChanged);
            // 
            // rdCirc
            // 
            this.rdCirc.AutoSize = true;
            this.rdCirc.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCirc.Location = new System.Drawing.Point(18, 27);
            this.rdCirc.Name = "rdCirc";
            this.rdCirc.Size = new System.Drawing.Size(130, 38);
            this.rdCirc.TabIndex = 0;
            this.rdCirc.TabStop = true;
            this.rdCirc.Text = "Equação Real da \r\nCircunferência";
            this.rdCirc.UseVisualStyleBackColor = true;
            this.rdCirc.Click += new System.EventHandler(this.CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdEliMed);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 70);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Elipse";
            // 
            // rdEliMed
            // 
            this.rdEliMed.AutoSize = true;
            this.rdEliMed.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdEliMed.ForeColor = System.Drawing.Color.Black;
            this.rdEliMed.Location = new System.Drawing.Point(18, 30);
            this.rdEliMed.Name = "rdEliMed";
            this.rdEliMed.Size = new System.Drawing.Size(138, 21);
            this.rdEliMed.TabIndex = 1;
            this.rdEliMed.TabStop = true;
            this.rdEliMed.Text = "Ponto Médio Elipse";
            this.rdEliMed.UseVisualStyleBackColor = true;
            this.rdEliMed.Click += new System.EventHandler(this.CheckedChanged);
            // 
            // Graphs
            // 
            this.Graphs.ContextMenuStrip = this.MenuStrip;
            this.Graphs.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Graphs.FormattingEnabled = true;
            this.Graphs.HorizontalScrollbar = true;
            this.Graphs.ItemHeight = 17;
            this.Graphs.Location = new System.Drawing.Point(6, 381);
            this.Graphs.Name = "Graphs";
            this.Graphs.Size = new System.Drawing.Size(265, 89);
            this.Graphs.TabIndex = 6;
            this.Graphs.SelectedIndexChanged += new System.EventHandler(this.Graphs_SelectedIndexChanged);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btApagar});
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(113, 26);
            this.MenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip_ItemClicked);
            // 
            // btApagar
            // 
            this.btApagar.Name = "btApagar";
            this.btApagar.Size = new System.Drawing.Size(112, 22);
            this.btApagar.Text = "Apagar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Objetos";
            // 
            // tabIndex
            // 
            this.tabIndex.Controls.Add(this.tabPage2);
            this.tabIndex.Controls.Add(this.tabPage1);
            this.tabIndex.Location = new System.Drawing.Point(649, 12);
            this.tabIndex.Name = "tabIndex";
            this.tabIndex.SelectedIndex = 0;
            this.tabIndex.Size = new System.Drawing.Size(285, 390);
            this.tabIndex.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.scrollBar);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.pnScroll);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(277, 361);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Polígonos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.polysPoints);
            this.panel2.Controls.Add(this.polist);
            this.panel2.Controls.Add(this.btCriaPoly);
            this.panel2.Controls.Add(this.btApagaPoly);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 139);
            this.panel2.TabIndex = 9;
            // 
            // polysPoints
            // 
            this.polysPoints.ContextMenuStrip = this.MenuStrip;
            this.polysPoints.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polysPoints.FormattingEnabled = true;
            this.polysPoints.ItemHeight = 17;
            this.polysPoints.Location = new System.Drawing.Point(187, 46);
            this.polysPoints.Name = "polysPoints";
            this.polysPoints.Size = new System.Drawing.Size(81, 89);
            this.polysPoints.TabIndex = 14;
            // 
            // polist
            // 
            this.polist.ContextMenuStrip = this.MenuStrip;
            this.polist.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polist.FormattingEnabled = true;
            this.polist.HorizontalScrollbar = true;
            this.polist.ItemHeight = 17;
            this.polist.Location = new System.Drawing.Point(3, 46);
            this.polist.Name = "polist";
            this.polist.Size = new System.Drawing.Size(178, 89);
            this.polist.TabIndex = 13;
            this.polist.SelectedIndexChanged += new System.EventHandler(this.polist_SelectedIndexChanged);
            // 
            // btCriaPoly
            // 
            this.btCriaPoly.BackColor = System.Drawing.Color.LimeGreen;
            this.btCriaPoly.FlatAppearance.BorderSize = 0;
            this.btCriaPoly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCriaPoly.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCriaPoly.ForeColor = System.Drawing.Color.White;
            this.btCriaPoly.Location = new System.Drawing.Point(3, 3);
            this.btCriaPoly.Name = "btCriaPoly";
            this.btCriaPoly.Size = new System.Drawing.Size(130, 37);
            this.btCriaPoly.TabIndex = 11;
            this.btCriaPoly.Text = "Novo";
            this.btCriaPoly.UseVisualStyleBackColor = false;
            this.btCriaPoly.Click += new System.EventHandler(this.btCriaPoly_Click);
            // 
            // btApagaPoly
            // 
            this.btApagaPoly.BackColor = System.Drawing.Color.Red;
            this.btApagaPoly.FlatAppearance.BorderSize = 0;
            this.btApagaPoly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btApagaPoly.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btApagaPoly.ForeColor = System.Drawing.Color.White;
            this.btApagaPoly.Location = new System.Drawing.Point(138, 3);
            this.btApagaPoly.Name = "btApagaPoly";
            this.btApagaPoly.Size = new System.Drawing.Size(130, 37);
            this.btApagaPoly.TabIndex = 12;
            this.btApagaPoly.Text = "Apagar";
            this.btApagaPoly.UseVisualStyleBackColor = false;
            this.btApagaPoly.Click += new System.EventHandler(this.btApagaPoly_Click);
            // 
            // scrollBar
            // 
            this.scrollBar.LargeChange = 20;
            this.scrollBar.Location = new System.Drawing.Point(257, 153);
            this.scrollBar.Maximum = 445;
            this.scrollBar.Name = "scrollBar";
            this.scrollBar.Size = new System.Drawing.Size(15, 201);
            this.scrollBar.SmallChange = 10;
            this.scrollBar.TabIndex = 10;
            this.scrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollBar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "___________________________________________";
            // 
            // pnScroll
            // 
            this.pnScroll.Controls.Add(this.groupBox7);
            this.pnScroll.Controls.Add(this.groupBox6);
            this.pnScroll.Controls.Add(this.groupBox5);
            this.pnScroll.Controls.Add(this.groupBox4);
            this.pnScroll.Controls.Add(this.groupBox3);
            this.pnScroll.Controls.Add(this.groupBox8);
            this.pnScroll.Location = new System.Drawing.Point(6, -285);
            this.pnScroll.Name = "pnScroll";
            this.pnScroll.Size = new System.Drawing.Size(251, 637);
            this.pnScroll.TabIndex = 9;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btScan);
            this.groupBox8.Controls.Add(this.btFlood);
            this.groupBox8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(3, 540);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(245, 89);
            this.groupBox8.TabIndex = 21;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Preenchimento";
            // 
            // btScan
            // 
            this.btScan.BackColor = System.Drawing.Color.LimeGreen;
            this.btScan.FlatAppearance.BorderSize = 0;
            this.btScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btScan.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btScan.ForeColor = System.Drawing.Color.White;
            this.btScan.Location = new System.Drawing.Point(7, 56);
            this.btScan.Name = "btScan";
            this.btScan.Size = new System.Drawing.Size(231, 27);
            this.btScan.TabIndex = 16;
            this.btScan.Text = "Scan Line";
            this.btScan.UseVisualStyleBackColor = false;
            this.btScan.Click += new System.EventHandler(this.btScan_Click);
            // 
            // btFlood
            // 
            this.btFlood.BackColor = System.Drawing.Color.LimeGreen;
            this.btFlood.FlatAppearance.BorderSize = 0;
            this.btFlood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFlood.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFlood.ForeColor = System.Drawing.Color.White;
            this.btFlood.Location = new System.Drawing.Point(7, 22);
            this.btFlood.Name = "btFlood";
            this.btFlood.Size = new System.Drawing.Size(231, 27);
            this.btFlood.TabIndex = 15;
            this.btFlood.Text = "Flood Fill";
            this.btFlood.UseVisualStyleBackColor = false;
            this.btFlood.Click += new System.EventHandler(this.btFlood_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btDiag);
            this.groupBox7.Controls.Add(this.btVert);
            this.groupBox7.Controls.Add(this.btHoriz);
            this.groupBox7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(3, 445);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(245, 89);
            this.groupBox7.TabIndex = 20;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Espelhamento";
            // 
            // btDiag
            // 
            this.btDiag.BackColor = System.Drawing.Color.LimeGreen;
            this.btDiag.FlatAppearance.BorderSize = 0;
            this.btDiag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDiag.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDiag.ForeColor = System.Drawing.Color.White;
            this.btDiag.Location = new System.Drawing.Point(7, 56);
            this.btDiag.Name = "btDiag";
            this.btDiag.Size = new System.Drawing.Size(231, 27);
            this.btDiag.TabIndex = 16;
            this.btDiag.Text = "Diagonal";
            this.btDiag.UseVisualStyleBackColor = false;
            this.btDiag.Click += new System.EventHandler(this.btDiag_Click);
            // 
            // btVert
            // 
            this.btVert.BackColor = System.Drawing.Color.LimeGreen;
            this.btVert.FlatAppearance.BorderSize = 0;
            this.btVert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVert.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVert.ForeColor = System.Drawing.Color.White;
            this.btVert.Location = new System.Drawing.Point(128, 22);
            this.btVert.Name = "btVert";
            this.btVert.Size = new System.Drawing.Size(110, 27);
            this.btVert.TabIndex = 15;
            this.btVert.Text = "Vertical";
            this.btVert.UseVisualStyleBackColor = false;
            this.btVert.Click += new System.EventHandler(this.btVert_Click);
            // 
            // btHoriz
            // 
            this.btHoriz.BackColor = System.Drawing.Color.LimeGreen;
            this.btHoriz.FlatAppearance.BorderSize = 0;
            this.btHoriz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHoriz.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHoriz.ForeColor = System.Drawing.Color.White;
            this.btHoriz.Location = new System.Drawing.Point(6, 22);
            this.btHoriz.Name = "btHoriz";
            this.btHoriz.Size = new System.Drawing.Size(110, 27);
            this.btHoriz.TabIndex = 14;
            this.btHoriz.Text = "Horizontal";
            this.btHoriz.UseVisualStyleBackColor = false;
            this.btHoriz.Click += new System.EventHandler(this.btHoriz_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.numAngle);
            this.groupBox6.Controls.Add(this.btRotation);
            this.groupBox6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(3, 350);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(245, 89);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Rotação";
            // 
            // numAngle
            // 
            this.numAngle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAngle.Location = new System.Drawing.Point(70, 26);
            this.numAngle.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numAngle.Name = "numAngle";
            this.numAngle.Size = new System.Drawing.Size(105, 23);
            this.numAngle.TabIndex = 10;
            this.numAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numAngle.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // btRotation
            // 
            this.btRotation.BackColor = System.Drawing.Color.LimeGreen;
            this.btRotation.FlatAppearance.BorderSize = 0;
            this.btRotation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRotation.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRotation.ForeColor = System.Drawing.Color.White;
            this.btRotation.Location = new System.Drawing.Point(7, 55);
            this.btRotation.Name = "btRotation";
            this.btRotation.Size = new System.Drawing.Size(231, 27);
            this.btRotation.TabIndex = 9;
            this.btRotation.Text = "OK";
            this.btRotation.UseVisualStyleBackColor = false;
            this.btRotation.Click += new System.EventHandler(this.btRotation_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.numY);
            this.groupBox5.Controls.Add(this.btShearXY);
            this.groupBox5.Controls.Add(this.btShearY);
            this.groupBox5.Controls.Add(this.numX);
            this.groupBox5.Controls.Add(this.btShearX);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(3, 255);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(245, 89);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cisalhamento";
            // 
            // numY
            // 
            this.numY.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numY.Location = new System.Drawing.Point(181, 26);
            this.numY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numY.Name = "numY";
            this.numY.Size = new System.Drawing.Size(57, 23);
            this.numY.TabIndex = 13;
            this.numY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btShearXY
            // 
            this.btShearXY.BackColor = System.Drawing.Color.LimeGreen;
            this.btShearXY.FlatAppearance.BorderSize = 0;
            this.btShearXY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btShearXY.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShearXY.ForeColor = System.Drawing.Color.White;
            this.btShearXY.Location = new System.Drawing.Point(70, 55);
            this.btShearXY.Name = "btShearXY";
            this.btShearXY.Size = new System.Drawing.Size(105, 27);
            this.btShearXY.TabIndex = 12;
            this.btShearXY.Text = "XY";
            this.btShearXY.UseVisualStyleBackColor = false;
            this.btShearXY.Click += new System.EventHandler(this.btShearXY_Click);
            // 
            // btShearY
            // 
            this.btShearY.BackColor = System.Drawing.Color.LimeGreen;
            this.btShearY.FlatAppearance.BorderSize = 0;
            this.btShearY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btShearY.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShearY.ForeColor = System.Drawing.Color.White;
            this.btShearY.Location = new System.Drawing.Point(181, 55);
            this.btShearY.Name = "btShearY";
            this.btShearY.Size = new System.Drawing.Size(58, 27);
            this.btShearY.TabIndex = 11;
            this.btShearY.Text = "Y";
            this.btShearY.UseVisualStyleBackColor = false;
            this.btShearY.Click += new System.EventHandler(this.btShearY_Click);
            // 
            // numX
            // 
            this.numX.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numX.Location = new System.Drawing.Point(7, 26);
            this.numX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numX.Name = "numX";
            this.numX.Size = new System.Drawing.Size(57, 23);
            this.numX.TabIndex = 10;
            this.numX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numX.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // btShearX
            // 
            this.btShearX.BackColor = System.Drawing.Color.LimeGreen;
            this.btShearX.FlatAppearance.BorderSize = 0;
            this.btShearX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btShearX.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShearX.ForeColor = System.Drawing.Color.White;
            this.btShearX.Location = new System.Drawing.Point(6, 55);
            this.btShearX.Name = "btShearX";
            this.btShearX.Size = new System.Drawing.Size(58, 27);
            this.btShearX.TabIndex = 9;
            this.btShearX.Text = "X";
            this.btShearX.UseVisualStyleBackColor = false;
            this.btShearX.Click += new System.EventHandler(this.btShearX_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtValueTranslacao);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.btTranslacao);
            this.groupBox4.Controls.Add(this.slideTransalacao);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(3, 129);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(245, 120);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Translação";
            // 
            // txtValueTranslacao
            // 
            this.txtValueTranslacao.AutoSize = true;
            this.txtValueTranslacao.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValueTranslacao.Location = new System.Drawing.Point(116, 19);
            this.txtValueTranslacao.Name = "txtValueTranslacao";
            this.txtValueTranslacao.Size = new System.Drawing.Size(14, 16);
            this.txtValueTranslacao.TabIndex = 13;
            this.txtValueTranslacao.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(116, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(217, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "100";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "-100";
            // 
            // btTranslacao
            // 
            this.btTranslacao.BackColor = System.Drawing.Color.LimeGreen;
            this.btTranslacao.FlatAppearance.BorderSize = 0;
            this.btTranslacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTranslacao.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTranslacao.ForeColor = System.Drawing.Color.White;
            this.btTranslacao.Location = new System.Drawing.Point(6, 84);
            this.btTranslacao.Name = "btTranslacao";
            this.btTranslacao.Size = new System.Drawing.Size(233, 27);
            this.btTranslacao.TabIndex = 9;
            this.btTranslacao.Text = "OK";
            this.btTranslacao.UseVisualStyleBackColor = false;
            this.btTranslacao.Click += new System.EventHandler(this.btTranslacao_Click);
            // 
            // slideTransalacao
            // 
            this.slideTransalacao.BackColor = System.Drawing.Color.White;
            this.slideTransalacao.LargeChange = 10;
            this.slideTransalacao.Location = new System.Drawing.Point(6, 36);
            this.slideTransalacao.Maximum = 200;
            this.slideTransalacao.Name = "slideTransalacao";
            this.slideTransalacao.Size = new System.Drawing.Size(233, 45);
            this.slideTransalacao.TabIndex = 10;
            this.slideTransalacao.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slideTransalacao.Value = 100;
            this.slideTransalacao.Scroll += new System.EventHandler(this.slideTransalacao_Scroll);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtValueEscala);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btEscala);
            this.groupBox3.Controls.Add(this.slideEscala);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 120);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Escala";
            // 
            // txtValueEscala
            // 
            this.txtValueEscala.AutoSize = true;
            this.txtValueEscala.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValueEscala.Location = new System.Drawing.Point(54, 19);
            this.txtValueEscala.Name = "txtValueEscala";
            this.txtValueEscala.Size = new System.Drawing.Size(14, 16);
            this.txtValueEscala.TabIndex = 13;
            this.txtValueEscala.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(219, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "5";
            // 
            // btEscala
            // 
            this.btEscala.BackColor = System.Drawing.Color.LimeGreen;
            this.btEscala.FlatAppearance.BorderSize = 0;
            this.btEscala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEscala.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEscala.ForeColor = System.Drawing.Color.White;
            this.btEscala.Location = new System.Drawing.Point(6, 84);
            this.btEscala.Name = "btEscala";
            this.btEscala.Size = new System.Drawing.Size(233, 27);
            this.btEscala.TabIndex = 9;
            this.btEscala.Text = "OK";
            this.btEscala.UseVisualStyleBackColor = false;
            this.btEscala.Click += new System.EventHandler(this.btEscala_Click);
            // 
            // slideEscala
            // 
            this.slideEscala.BackColor = System.Drawing.Color.White;
            this.slideEscala.LargeChange = 10;
            this.slideEscala.Location = new System.Drawing.Point(6, 36);
            this.slideEscala.Maximum = 50;
            this.slideEscala.Name = "slideEscala";
            this.slideEscala.Size = new System.Drawing.Size(233, 45);
            this.slideEscala.TabIndex = 10;
            this.slideEscala.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slideEscala.Value = 10;
            this.slideEscala.Scroll += new System.EventHandler(this.slideEscala_Scroll);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.gbRetas);
            this.tabPage1.Controls.Add(this.Graphs);
            this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(277, 476);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Algoritmos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ViewPort
            // 
            this.ViewPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ViewPort.Location = new System.Drawing.Point(719, 408);
            this.ViewPort.Name = "ViewPort";
            this.ViewPort.Size = new System.Drawing.Size(143, 109);
            this.ViewPort.TabIndex = 0;
            this.ViewPort.TabStop = false;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(946, 528);
            this.Controls.Add(this.ViewPort);
            this.Controls.Add(this.tabIndex);
            this.Controls.Add(this.picBox);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RawLine";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FMain_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.gbRetas.ResumeLayout(false);
            this.gbRetas.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.tabIndex.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnScroll.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numAngle)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slideTransalacao)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slideEscala)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewPort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.GroupBox gbRetas;
        private System.Windows.Forms.RadioButton rdBresenham;
        private System.Windows.Forms.RadioButton rdDDA;
        private System.Windows.Forms.RadioButton rdReta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdCircMed;
        private System.Windows.Forms.RadioButton rdTrig;
        private System.Windows.Forms.RadioButton rdCirc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdEliMed;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ListBox Graphs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem btApagar;
        private System.Windows.Forms.TabControl tabIndex;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.VScrollBar scrollBar;
        private System.Windows.Forms.Panel pnScroll;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label txtValueEscala;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btEscala;
        private System.Windows.Forms.TrackBar slideEscala;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label txtValueTranslacao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btTranslacao;
        private System.Windows.Forms.TrackBar slideTransalacao;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox polist;
        private System.Windows.Forms.Button btCriaPoly;
        private System.Windows.Forms.Button btApagaPoly;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btShearX;
        private System.Windows.Forms.NumericUpDown numY;
        private System.Windows.Forms.Button btShearXY;
        private System.Windows.Forms.Button btShearY;
        private System.Windows.Forms.NumericUpDown numX;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown numAngle;
        private System.Windows.Forms.Button btRotation;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btDiag;
        private System.Windows.Forms.Button btVert;
        private System.Windows.Forms.Button btHoriz;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btScan;
        private System.Windows.Forms.Button btFlood;
        private System.Windows.Forms.ListBox polysPoints;
        private System.Windows.Forms.PictureBox ViewPort;
    }
}

