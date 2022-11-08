namespace CafeOtomasyonu
{
    partial class FirmaTanim
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
			this.components = new System.ComponentModel.Container();
			this.BtnYeni = new System.Windows.Forms.Button();
			this.BtnDuzelt = new System.Windows.Forms.Button();
			this.BtnVazgec = new System.Windows.Forms.Button();
			this.BtnSil = new System.Windows.Forms.Button();
			this.BtnKaydet = new System.Windows.Forms.Button();
			this.BtnKapat = new System.Windows.Forms.Button();
			this.txtTelno = new System.Windows.Forms.MaskedTextBox();
			this.firmaTanimBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cafeOtomasyonuDataSet = new CafeOtomasyonu.CafeOtomasyonuDataSet();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.BtnSonKayit = new System.Windows.Forms.Button();
			this.BtnIlkKayit = new System.Windows.Forms.Button();
			this.BtnGeri = new System.Windows.Forms.Button();
			this.BtnIleri = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.TxtAdres = new System.Windows.Forms.TextBox();
			this.PnlBtn = new System.Windows.Forms.Panel();
			this.LblAdres = new System.Windows.Forms.Label();
			this.LblTelno = new System.Windows.Forms.Label();
			this.LblUnvan = new System.Windows.Forms.Label();
			this.TxtUnvan = new System.Windows.Forms.TextBox();
			this.PnlTxt = new System.Windows.Forms.Panel();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.firmaTanimTableAdapter = new CafeOtomasyonu.CafeOtomasyonuDataSetTableAdapters.FirmaTanimTableAdapter();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.düzeltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.vazgeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button6 = new System.Windows.Forms.Button();
			this.BtnKaydet1 = new System.Windows.Forms.Button();
			this.BtnSil1 = new System.Windows.Forms.Button();
			this.BtnVazgec1 = new System.Windows.Forms.Button();
			this.BtnDuzelt1 = new System.Windows.Forms.Button();
			this.BtnYeni1 = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.firmaTanimBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cafeOtomasyonuDataSet)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.PnlBtn.SuspendLayout();
			this.PnlTxt.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// BtnYeni
			// 
			this.BtnYeni.Dock = System.Windows.Forms.DockStyle.Right;
			this.BtnYeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnYeni.Location = new System.Drawing.Point(-985, 0);
			this.BtnYeni.Name = "BtnYeni";
			this.BtnYeni.Size = new System.Drawing.Size(186, 61);
			this.BtnYeni.TabIndex = 0;
			this.BtnYeni.Text = "Yeni";
			this.BtnYeni.UseVisualStyleBackColor = true;
			this.BtnYeni.Click += new System.EventHandler(this.BtnYeni_Click);
			// 
			// BtnDuzelt
			// 
			this.BtnDuzelt.Dock = System.Windows.Forms.DockStyle.Right;
			this.BtnDuzelt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnDuzelt.Location = new System.Drawing.Point(-799, 0);
			this.BtnDuzelt.Name = "BtnDuzelt";
			this.BtnDuzelt.Size = new System.Drawing.Size(163, 61);
			this.BtnDuzelt.TabIndex = 1;
			this.BtnDuzelt.Text = "Düzelt";
			this.BtnDuzelt.UseVisualStyleBackColor = true;
			this.BtnDuzelt.Click += new System.EventHandler(this.BtnDuzelt_Click);
			// 
			// BtnVazgec
			// 
			this.BtnVazgec.Dock = System.Windows.Forms.DockStyle.Right;
			this.BtnVazgec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnVazgec.Location = new System.Drawing.Point(-636, 0);
			this.BtnVazgec.Name = "BtnVazgec";
			this.BtnVazgec.Size = new System.Drawing.Size(157, 61);
			this.BtnVazgec.TabIndex = 2;
			this.BtnVazgec.Text = "Vazgeç";
			this.BtnVazgec.UseVisualStyleBackColor = true;
			this.BtnVazgec.Click += new System.EventHandler(this.BtnVazgec_Click);
			// 
			// BtnSil
			// 
			this.BtnSil.Dock = System.Windows.Forms.DockStyle.Right;
			this.BtnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnSil.Location = new System.Drawing.Point(-479, 0);
			this.BtnSil.Name = "BtnSil";
			this.BtnSil.Size = new System.Drawing.Size(163, 61);
			this.BtnSil.TabIndex = 3;
			this.BtnSil.Text = "Sil";
			this.BtnSil.UseVisualStyleBackColor = true;
			this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
			// 
			// BtnKaydet
			// 
			this.BtnKaydet.Dock = System.Windows.Forms.DockStyle.Right;
			this.BtnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnKaydet.Location = new System.Drawing.Point(-316, 0);
			this.BtnKaydet.Name = "BtnKaydet";
			this.BtnKaydet.Size = new System.Drawing.Size(163, 61);
			this.BtnKaydet.TabIndex = 4;
			this.BtnKaydet.Text = "Kaydet";
			this.BtnKaydet.UseVisualStyleBackColor = true;
			this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
			// 
			// BtnKapat
			// 
			this.BtnKapat.Dock = System.Windows.Forms.DockStyle.Right;
			this.BtnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnKapat.Location = new System.Drawing.Point(-153, 0);
			this.BtnKapat.Name = "BtnKapat";
			this.BtnKapat.Size = new System.Drawing.Size(163, 61);
			this.BtnKapat.TabIndex = 5;
			this.BtnKapat.Text = "Kapat";
			this.BtnKapat.UseVisualStyleBackColor = true;
			this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
			// 
			// txtTelno
			// 
			this.txtTelno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmaTanimBindingSource, "tel", true));
			this.txtTelno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtTelno.Location = new System.Drawing.Point(108, 53);
			this.txtTelno.Name = "txtTelno";
			this.txtTelno.Size = new System.Drawing.Size(237, 30);
			this.txtTelno.TabIndex = 17;
			// 
			// firmaTanimBindingSource
			// 
			this.firmaTanimBindingSource.DataMember = "FirmaTanim";
			this.firmaTanimBindingSource.DataSource = this.cafeOtomasyonuDataSet;
			// 
			// cafeOtomasyonuDataSet
			// 
			this.cafeOtomasyonuDataSet.DataSetName = "CafeOtomasyonuDataSet";
			this.cafeOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.BtnSonKayit, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.BtnIlkKayit, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.BtnGeri, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.BtnIleri, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 53);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.92308F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.07692F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(288, 104);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// BtnSonKayit
			// 
			this.BtnSonKayit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BtnSonKayit.Location = new System.Drawing.Point(147, 57);
			this.BtnSonKayit.Name = "BtnSonKayit";
			this.BtnSonKayit.Size = new System.Drawing.Size(138, 44);
			this.BtnSonKayit.TabIndex = 3;
			this.BtnSonKayit.Text = "Son Kayıt";
			this.BtnSonKayit.UseVisualStyleBackColor = true;
			this.BtnSonKayit.Click += new System.EventHandler(this.BtnSonKayit_Click);
			// 
			// BtnIlkKayit
			// 
			this.BtnIlkKayit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BtnIlkKayit.Location = new System.Drawing.Point(3, 57);
			this.BtnIlkKayit.Name = "BtnIlkKayit";
			this.BtnIlkKayit.Size = new System.Drawing.Size(138, 44);
			this.BtnIlkKayit.TabIndex = 2;
			this.BtnIlkKayit.Text = "İlk Kayıt";
			this.BtnIlkKayit.UseVisualStyleBackColor = true;
			this.BtnIlkKayit.Click += new System.EventHandler(this.BtnIlkKayit_Click);
			// 
			// BtnGeri
			// 
			this.BtnGeri.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BtnGeri.Location = new System.Drawing.Point(147, 3);
			this.BtnGeri.Name = "BtnGeri";
			this.BtnGeri.Size = new System.Drawing.Size(138, 48);
			this.BtnGeri.TabIndex = 1;
			this.BtnGeri.Text = "Geri";
			this.BtnGeri.UseVisualStyleBackColor = true;
			this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
			// 
			// BtnIleri
			// 
			this.BtnIleri.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BtnIleri.Location = new System.Drawing.Point(3, 3);
			this.BtnIleri.Name = "BtnIleri";
			this.BtnIleri.Size = new System.Drawing.Size(138, 48);
			this.BtnIleri.TabIndex = 0;
			this.BtnIleri.Text = "İleri";
			this.BtnIleri.UseVisualStyleBackColor = true;
			this.BtnIleri.Click += new System.EventHandler(this.BtnIleri_Click);
			// 
			// panel1
			// 
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(-1166, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(181, 61);
			this.panel1.TabIndex = 6;
			// 
			// TxtAdres
			// 
			this.TxtAdres.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmaTanimBindingSource, "adres", true));
			this.TxtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.TxtAdres.Location = new System.Drawing.Point(460, 14);
			this.TxtAdres.Multiline = true;
			this.TxtAdres.Name = "TxtAdres";
			this.TxtAdres.Size = new System.Drawing.Size(218, 119);
			this.TxtAdres.TabIndex = 16;
			// 
			// PnlBtn
			// 
			this.PnlBtn.Controls.Add(this.panel1);
			this.PnlBtn.Controls.Add(this.BtnYeni);
			this.PnlBtn.Controls.Add(this.BtnDuzelt);
			this.PnlBtn.Controls.Add(this.BtnVazgec);
			this.PnlBtn.Controls.Add(this.BtnSil);
			this.PnlBtn.Controls.Add(this.BtnKaydet);
			this.PnlBtn.Controls.Add(this.BtnKapat);
			this.PnlBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.PnlBtn.Location = new System.Drawing.Point(0, -51);
			this.PnlBtn.Name = "PnlBtn";
			this.PnlBtn.Size = new System.Drawing.Size(10, 61);
			this.PnlBtn.TabIndex = 14;
			// 
			// LblAdres
			// 
			this.LblAdres.AutoSize = true;
			this.LblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.LblAdres.Location = new System.Drawing.Point(388, 14);
			this.LblAdres.Name = "LblAdres";
			this.LblAdres.Size = new System.Drawing.Size(64, 25);
			this.LblAdres.TabIndex = 12;
			this.LblAdres.Text = "Adres";
			// 
			// LblTelno
			// 
			this.LblTelno.AutoSize = true;
			this.LblTelno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.LblTelno.Location = new System.Drawing.Point(24, 53);
			this.LblTelno.Name = "LblTelno";
			this.LblTelno.Size = new System.Drawing.Size(78, 25);
			this.LblTelno.TabIndex = 11;
			this.LblTelno.Text = "Telefon";
			// 
			// LblUnvan
			// 
			this.LblUnvan.AutoSize = true;
			this.LblUnvan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.LblUnvan.Location = new System.Drawing.Point(36, 14);
			this.LblUnvan.Name = "LblUnvan";
			this.LblUnvan.Size = new System.Drawing.Size(69, 25);
			this.LblUnvan.TabIndex = 10;
			this.LblUnvan.Text = "Unvan";
			// 
			// TxtUnvan
			// 
			this.TxtUnvan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmaTanimBindingSource, "unvan", true));
			this.TxtUnvan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.TxtUnvan.Location = new System.Drawing.Point(108, 14);
			this.TxtUnvan.Name = "TxtUnvan";
			this.TxtUnvan.Size = new System.Drawing.Size(237, 30);
			this.TxtUnvan.TabIndex = 6;
			// 
			// PnlTxt
			// 
			this.PnlTxt.BackColor = System.Drawing.Color.Lime;
			this.PnlTxt.Controls.Add(this.PnlBtn);
			this.PnlTxt.Location = new System.Drawing.Point(471, 0);
			this.PnlTxt.Name = "PnlTxt";
			this.PnlTxt.Size = new System.Drawing.Size(10, 10);
			this.PnlTxt.TabIndex = 7;
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmaTanimBindingSource, "masasayisi", true));
			this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.maskedTextBox1.Location = new System.Drawing.Point(836, 27);
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(237, 30);
			this.maskedTextBox1.TabIndex = 19;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(702, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(119, 25);
			this.label1.TabIndex = 18;
			this.label1.Text = "Masa Sayısı";
			// 
			// firmaTanimTableAdapter
			// 
			this.firmaTanimTableAdapter.ClearBeforeFill = true;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem,
            this.düzeltToolStripMenuItem,
            this.vazgeçToolStripMenuItem,
            this.silToolStripMenuItem,
            this.kaydetToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.ShowImageMargin = false;
			this.contextMenuStrip1.Size = new System.Drawing.Size(105, 114);
			// 
			// yeniToolStripMenuItem
			// 
			this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
			this.yeniToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.yeniToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
			this.yeniToolStripMenuItem.Text = "Yeni";
			this.yeniToolStripMenuItem.Click += new System.EventHandler(this.BtnYeni_Click);
			// 
			// düzeltToolStripMenuItem
			// 
			this.düzeltToolStripMenuItem.Name = "düzeltToolStripMenuItem";
			this.düzeltToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
			this.düzeltToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
			this.düzeltToolStripMenuItem.Text = "Düzelt";
			this.düzeltToolStripMenuItem.Click += new System.EventHandler(this.BtnDuzelt_Click);
			// 
			// vazgeçToolStripMenuItem
			// 
			this.vazgeçToolStripMenuItem.Name = "vazgeçToolStripMenuItem";
			this.vazgeçToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7;
			this.vazgeçToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
			this.vazgeçToolStripMenuItem.Text = "Vazgeç";
			this.vazgeçToolStripMenuItem.Click += new System.EventHandler(this.BtnVazgec_Click);
			// 
			// silToolStripMenuItem
			// 
			this.silToolStripMenuItem.Name = "silToolStripMenuItem";
			this.silToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8;
			this.silToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
			this.silToolStripMenuItem.Text = "Sil";
			this.silToolStripMenuItem.Click += new System.EventHandler(this.BtnSil_Click);
			// 
			// kaydetToolStripMenuItem
			// 
			this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
			this.kaydetToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
			this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
			this.kaydetToolStripMenuItem.Text = "Kaydet";
			this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.BtnKaydet_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Cyan;
			this.panel2.Controls.Add(this.button6);
			this.panel2.Controls.Add(this.BtnKaydet1);
			this.panel2.Controls.Add(this.BtnSil1);
			this.panel2.Controls.Add(this.tableLayoutPanel1);
			this.panel2.Controls.Add(this.BtnVazgec1);
			this.panel2.Controls.Add(this.BtnDuzelt1);
			this.panel2.Controls.Add(this.BtnYeni1);
			this.panel2.Location = new System.Drawing.Point(0, 188);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1283, 188);
			this.panel2.TabIndex = 20;
			// 
			// button6
			// 
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button6.Location = new System.Drawing.Point(1033, 67);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(140, 81);
			this.button6.TabIndex = 5;
			this.button6.Text = "KAPAT";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.BtnKapat_Click);
			// 
			// BtnKaydet1
			// 
			this.BtnKaydet1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnKaydet1.Location = new System.Drawing.Point(887, 67);
			this.BtnKaydet1.Name = "BtnKaydet1";
			this.BtnKaydet1.Size = new System.Drawing.Size(140, 81);
			this.BtnKaydet1.TabIndex = 4;
			this.BtnKaydet1.Text = "KAYDET";
			this.BtnKaydet1.UseVisualStyleBackColor = true;
			this.BtnKaydet1.Click += new System.EventHandler(this.BtnKaydet_Click);
			// 
			// BtnSil1
			// 
			this.BtnSil1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnSil1.Location = new System.Drawing.Point(741, 67);
			this.BtnSil1.Name = "BtnSil1";
			this.BtnSil1.Size = new System.Drawing.Size(140, 81);
			this.BtnSil1.TabIndex = 3;
			this.BtnSil1.Text = "SIL";
			this.BtnSil1.UseVisualStyleBackColor = true;
			this.BtnSil1.Click += new System.EventHandler(this.BtnSil_Click);
			// 
			// BtnVazgec1
			// 
			this.BtnVazgec1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnVazgec1.Location = new System.Drawing.Point(595, 67);
			this.BtnVazgec1.Name = "BtnVazgec1";
			this.BtnVazgec1.Size = new System.Drawing.Size(140, 81);
			this.BtnVazgec1.TabIndex = 2;
			this.BtnVazgec1.Text = "VAZGEC";
			this.BtnVazgec1.UseVisualStyleBackColor = true;
			this.BtnVazgec1.Click += new System.EventHandler(this.BtnVazgec_Click);
			// 
			// BtnDuzelt1
			// 
			this.BtnDuzelt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnDuzelt1.Location = new System.Drawing.Point(449, 67);
			this.BtnDuzelt1.Name = "BtnDuzelt1";
			this.BtnDuzelt1.Size = new System.Drawing.Size(140, 81);
			this.BtnDuzelt1.TabIndex = 1;
			this.BtnDuzelt1.Text = "DUZELT";
			this.BtnDuzelt1.UseVisualStyleBackColor = true;
			this.BtnDuzelt1.Click += new System.EventHandler(this.BtnDuzelt_Click);
			// 
			// BtnYeni1
			// 
			this.BtnYeni1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnYeni1.Location = new System.Drawing.Point(303, 67);
			this.BtnYeni1.Name = "BtnYeni1";
			this.BtnYeni1.Size = new System.Drawing.Size(140, 81);
			this.BtnYeni1.TabIndex = 0;
			this.BtnYeni1.Text = "YENI";
			this.BtnYeni1.UseVisualStyleBackColor = true;
			this.BtnYeni1.Click += new System.EventHandler(this.BtnYeni_Click);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.panel3.Controls.Add(this.maskedTextBox1);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Controls.Add(this.TxtUnvan);
			this.panel3.Controls.Add(this.LblUnvan);
			this.panel3.Controls.Add(this.TxtAdres);
			this.panel3.Controls.Add(this.txtTelno);
			this.panel3.Controls.Add(this.LblAdres);
			this.panel3.Controls.Add(this.LblTelno);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1283, 182);
			this.panel3.TabIndex = 21;
			// 
			// FirmaTanim
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1283, 370);
			this.ContextMenuStrip = this.contextMenuStrip1;
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.PnlTxt);
			this.Name = "FirmaTanim";
			this.Text = "FirmaTanim";
			this.Load += new System.EventHandler(this.FirmaTanim_Load);
			((System.ComponentModel.ISupportInitialize)(this.firmaTanimBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cafeOtomasyonuDataSet)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.PnlBtn.ResumeLayout(false);
			this.PnlTxt.ResumeLayout(false);
			this.contextMenuStrip1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnYeni;
        private System.Windows.Forms.Button BtnDuzelt;
        private System.Windows.Forms.Button BtnVazgec;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnKapat;
        private System.Windows.Forms.MaskedTextBox txtTelno;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnSonKayit;
        private System.Windows.Forms.Button BtnIlkKayit;
        private System.Windows.Forms.Button BtnGeri;
        private System.Windows.Forms.Button BtnIleri;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtAdres;
        private System.Windows.Forms.Panel PnlBtn;
        private System.Windows.Forms.Label LblAdres;
        private System.Windows.Forms.Label LblTelno;
        private System.Windows.Forms.Label LblUnvan;
        private System.Windows.Forms.TextBox TxtUnvan;
        private System.Windows.Forms.Panel PnlTxt;
        private CafeOtomasyonuDataSet cafeOtomasyonuDataSet;
        private System.Windows.Forms.BindingSource firmaTanimBindingSource;
        private CafeOtomasyonuDataSetTableAdapters.FirmaTanimTableAdapter firmaTanimTableAdapter;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzeltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vazgeçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button BtnKaydet1;
		private System.Windows.Forms.Button BtnSil1;
		private System.Windows.Forms.Button BtnVazgec1;
		private System.Windows.Forms.Button BtnDuzelt1;
		private System.Windows.Forms.Button BtnYeni1;
		private System.Windows.Forms.Panel panel3;
	}
}