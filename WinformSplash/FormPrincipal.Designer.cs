namespace WinformSplash
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.LabelDestino = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcion1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcion2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcion3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ActividadesExtras = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Fecha = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.GB = new System.Windows.Forms.GroupBox();
            this.RBPensionCompleta = new System.Windows.Forms.RadioButton();
            this.RBMediaPension = new System.Windows.Forms.RadioButton();
            this.RBSoloDormir = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CuadroTexto = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.DireccionCorreo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.IconoReloj = new System.Windows.Forms.ToolStripStatusLabel();
            this.SystemTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Total = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.ListaImagenes = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelDestino
            // 
            this.LabelDestino.AutoSize = true;
            this.LabelDestino.BackColor = System.Drawing.Color.PaleTurquoise;
            this.LabelDestino.Location = new System.Drawing.Point(240, 88);
            this.LabelDestino.Name = "LabelDestino";
            this.LabelDestino.Size = new System.Drawing.Size(94, 15);
            this.LabelDestino.TabIndex = 0;
            this.LabelDestino.Text = "Elige un destino:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcion1ToolStripMenuItem,
            this.opcion2ToolStripMenuItem,
            this.opcion3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcion1ToolStripMenuItem
            // 
            this.opcion1ToolStripMenuItem.Name = "opcion1ToolStripMenuItem";
            this.opcion1ToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.opcion1ToolStripMenuItem.Text = "Acuerdo Empresa";
            this.opcion1ToolStripMenuItem.Click += new System.EventHandler(this.opcion1ToolStripMenuItem_Click_1);
            // 
            // opcion2ToolStripMenuItem
            // 
            this.opcion2ToolStripMenuItem.Name = "opcion2ToolStripMenuItem";
            this.opcion2ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.opcion2ToolStripMenuItem.Text = "Precios";
            // 
            // opcion3ToolStripMenuItem
            // 
            this.opcion3ToolStripMenuItem.Name = "opcion3ToolStripMenuItem";
            this.opcion3ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.opcion3ToolStripMenuItem.Text = "Salir";
            this.opcion3ToolStripMenuItem.Click += new System.EventHandler(this.opcion3ToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "Ciudad",
            "Montaña",
            "Playa",
            "Tour"});
            this.listBox1.Location = new System.Drawing.Point(248, 112);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(80, 64);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // ActividadesExtras
            // 
            this.ActividadesExtras.AutoSize = true;
            this.ActividadesExtras.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ActividadesExtras.Location = new System.Drawing.Point(472, 88);
            this.ActividadesExtras.Name = "ActividadesExtras";
            this.ActividadesExtras.Size = new System.Drawing.Size(105, 15);
            this.ActividadesExtras.TabIndex = 6;
            this.ActividadesExtras.Text = "Actividades Extras:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Cena y Espectáculo",
            "Excursiones",
            "Lavandería",
            "NaturAventura",
            "Spa"});
            this.checkedListBox1.Location = new System.Drawing.Point(472, 112);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(136, 94);
            this.checkedListBox1.TabIndex = 7;
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Fecha.Location = new System.Drawing.Point(240, 192);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(41, 15);
            this.Fecha.TabIndex = 8;
            this.Fecha.Text = "Fecha:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(240, 216);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            // 
            // GB
            // 
            this.GB.Controls.Add(this.RBPensionCompleta);
            this.GB.Controls.Add(this.RBMediaPension);
            this.GB.Controls.Add(this.RBSoloDormir);
            this.GB.Location = new System.Drawing.Point(40, 240);
            this.GB.Name = "GB";
            this.GB.Size = new System.Drawing.Size(136, 152);
            this.GB.TabIndex = 10;
            this.GB.TabStop = false;
            this.GB.Text = "Tipo de estancia";
            // 
            // RBPensionCompleta
            // 
            this.RBPensionCompleta.AutoSize = true;
            this.RBPensionCompleta.Location = new System.Drawing.Point(16, 112);
            this.RBPensionCompleta.Name = "RBPensionCompleta";
            this.RBPensionCompleta.Size = new System.Drawing.Size(122, 19);
            this.RBPensionCompleta.TabIndex = 2;
            this.RBPensionCompleta.TabStop = true;
            this.RBPensionCompleta.Text = "Pensión Completa";
            this.RBPensionCompleta.UseVisualStyleBackColor = true;
            // 
            // RBMediaPension
            // 
            this.RBMediaPension.AutoSize = true;
            this.RBMediaPension.Location = new System.Drawing.Point(16, 72);
            this.RBMediaPension.Name = "RBMediaPension";
            this.RBMediaPension.Size = new System.Drawing.Size(103, 19);
            this.RBMediaPension.TabIndex = 1;
            this.RBMediaPension.TabStop = true;
            this.RBMediaPension.Text = "Media Pension";
            this.RBMediaPension.UseVisualStyleBackColor = true;
            // 
            // RBSoloDormir
            // 
            this.RBSoloDormir.AutoSize = true;
            this.RBSoloDormir.Location = new System.Drawing.Point(16, 32);
            this.RBSoloDormir.Name = "RBSoloDormir";
            this.RBSoloDormir.Size = new System.Drawing.Size(88, 19);
            this.RBSoloDormir.TabIndex = 0;
            this.RBSoloDormir.TabStop = true;
            this.RBSoloDormir.Text = "Sólo Dormir";
            this.RBSoloDormir.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(472, 248);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(40, 23);
            this.numericUpDown1.TabIndex = 11;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(472, 312);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(40, 23);
            this.numericUpDown2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Location = new System.Drawing.Point(520, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Número de personas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label2.Location = new System.Drawing.Point(520, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Estrellas";
            // 
            // CuadroTexto
            // 
            this.CuadroTexto.Location = new System.Drawing.Point(16, 16);
            this.CuadroTexto.Name = "CuadroTexto";
            this.CuadroTexto.Size = new System.Drawing.Size(312, 104);
            this.CuadroTexto.TabIndex = 15;
            this.CuadroTexto.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.DireccionCorreo,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.IconoReloj,
            this.SystemTime,
            this.toolStripStatusLabel5});
            this.statusStrip1.Location = new System.Drawing.Point(0, 591);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.Color.MintCream;
            this.toolStripStatusLabel2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel2.Image")));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(16, 17);
            // 
            // DireccionCorreo
            // 
            this.DireccionCorreo.BackColor = System.Drawing.Color.White;
            this.DireccionCorreo.IsLink = true;
            this.DireccionCorreo.Name = "DireccionCorreo";
            this.DireccionCorreo.Size = new System.Drawing.Size(165, 17);
            this.DireccionCorreo.Text = "viajeconnosotros@gmail.com";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(129, 17);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BackColor = System.Drawing.Color.MintCream;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(129, 17);
            this.toolStripStatusLabel3.Spring = true;
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.BackColor = System.Drawing.Color.MintCream;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(129, 17);
            this.toolStripStatusLabel4.Spring = true;
            // 
            // IconoReloj
            // 
            this.IconoReloj.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IconoReloj.Image = ((System.Drawing.Image)(resources.GetObject("IconoReloj.Image")));
            this.IconoReloj.Name = "IconoReloj";
            this.IconoReloj.Size = new System.Drawing.Size(16, 17);
            // 
            // SystemTime
            // 
            this.SystemTime.BackColor = System.Drawing.Color.MintCream;
            this.SystemTime.Name = "SystemTime";
            this.SystemTime.Size = new System.Drawing.Size(71, 17);
            this.SystemTime.Text = "SystemTime";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.BackColor = System.Drawing.Color.MintCream;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(129, 17);
            this.toolStripStatusLabel5.Spring = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(64, 416);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 17;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.Total);
            this.panel1.Controls.Add(this.btnValidar);
            this.panel1.Controls.Add(this.CuadroTexto);
            this.panel1.Location = new System.Drawing.Point(184, 408);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 160);
            this.panel1.TabIndex = 18;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(16, 136);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(32, 15);
            this.Total.TabIndex = 17;
            this.Total.Text = "Total";
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(256, 128);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(75, 23);
            this.btnValidar.TabIndex = 16;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            // 
            // ListaImagenes
            // 
            this.ListaImagenes.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ListaImagenes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ListaImagenes.ImageStream")));
            this.ListaImagenes.TransparentColor = System.Drawing.Color.Transparent;
            this.ListaImagenes.Images.SetKeyName(0, "ciudad.png");
            this.ListaImagenes.Images.SetKeyName(1, "mountain.jpg");
            this.ListaImagenes.Images.SetKeyName(2, "beach.jpg");
            this.ListaImagenes.Images.SetKeyName(3, "tour.png");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 613);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.GB);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.ActividadesExtras);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.LabelDestino);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrincipal_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GB.ResumeLayout(false);
            this.GB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelDestino;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem opcion1ToolStripMenuItem;
        private ToolStripMenuItem opcion2ToolStripMenuItem;
        private ToolStripMenuItem opcion3ToolStripMenuItem;
        private EventHandler opcion1ToolStripMenuItem_Click;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private PictureBox pictureBox1;
        private ListBox listBox1;
        private Label ActividadesExtras;
        private CheckedListBox checkedListBox1;
        private Label Fecha;
        private MonthCalendar monthCalendar1;
        private GroupBox GB;
        private RadioButton RBPensionCompleta;
        private RadioButton RBMediaPension;
        private RadioButton RBSoloDormir;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label label1;
        private Label label2;
        private RichTextBox CuadroTexto;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel DireccionCorreo;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel SystemTime;
        private ToolStripStatusLabel IconoReloj;
        private Panel panel1;
        private Button btnValidar;
        private Button btnCalcular;
        private ImageList ListaImagenes;
        private System.Windows.Forms.Timer timer1;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripStatusLabel toolStripStatusLabel5;
        private Label Total;
        private ToolStripStatusLabel toolStripStatusLabel2;
    }
}