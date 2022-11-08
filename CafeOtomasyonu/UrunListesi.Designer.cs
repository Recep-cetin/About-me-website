namespace CafeOtomasyonu
{
    partial class UrunListesi
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.TxtArama = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.urunTanimBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cafeOtomasyonuDataSet = new CafeOtomasyonu.CafeOtomasyonuDataSet();
			this.urun_TanimTableAdapter = new CafeOtomasyonu.CafeOtomasyonuDataSetTableAdapters.Urun_TanimTableAdapter();
			this.uidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.barkoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.uadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.afiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sfiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.kdvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.alinanmiktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.satilanmiktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.kalanmiktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.urunTanimBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cafeOtomasyonuDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.TxtArama);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(960, 78);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Arama";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.comboBox1);
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.radioButton2);
			this.groupBox2.Controls.Add(this.radioButton1);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Location = new System.Drawing.Point(463, 6);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(270, 66);
			this.groupBox2.TabIndex = 21;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Fiyat artışı";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Zam",
            "İndirim"});
			this.comboBox1.Location = new System.Drawing.Point(130, 10);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 6;
			this.comboBox1.Text = "Zam";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(143, 34);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "Uygula";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(67, 14);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(47, 17);
			this.radioButton2.TabIndex = 4;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Birim";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(6, 14);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(55, 17);
			this.radioButton1.TabIndex = 3;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Yüzde";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(24, 37);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 2;
			// 
			// TxtArama
			// 
			this.TxtArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.TxtArama.Location = new System.Drawing.Point(12, 19);
			this.TxtArama.Name = "TxtArama";
			this.TxtArama.Size = new System.Drawing.Size(393, 30);
			this.TxtArama.TabIndex = 0;
			this.TxtArama.TextChanged += new System.EventHandler(this.TxtArama_TextChanged);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uidDataGridViewTextBoxColumn,
            this.barkoduDataGridViewTextBoxColumn,
            this.uadiDataGridViewTextBoxColumn,
            this.afiyatDataGridViewTextBoxColumn,
            this.sfiyatDataGridViewTextBoxColumn,
            this.kdvDataGridViewTextBoxColumn,
            this.alinanmiktarDataGridViewTextBoxColumn,
            this.satilanmiktarDataGridViewTextBoxColumn,
            this.kalanmiktarDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.urunTanimBindingSource;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 78);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(960, 372);
			this.dataGridView1.TabIndex = 3;
			this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
			// 
			// urunTanimBindingSource
			// 
			this.urunTanimBindingSource.DataMember = "Urun_Tanim";
			this.urunTanimBindingSource.DataSource = this.cafeOtomasyonuDataSet;
			// 
			// cafeOtomasyonuDataSet
			// 
			this.cafeOtomasyonuDataSet.DataSetName = "CafeOtomasyonuDataSet";
			this.cafeOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// urun_TanimTableAdapter
			// 
			this.urun_TanimTableAdapter.ClearBeforeFill = true;
			// 
			// uidDataGridViewTextBoxColumn
			// 
			this.uidDataGridViewTextBoxColumn.DataPropertyName = "uid";
			this.uidDataGridViewTextBoxColumn.HeaderText = "uid";
			this.uidDataGridViewTextBoxColumn.Name = "uidDataGridViewTextBoxColumn";
			this.uidDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// barkoduDataGridViewTextBoxColumn
			// 
			this.barkoduDataGridViewTextBoxColumn.DataPropertyName = "barkodu";
			this.barkoduDataGridViewTextBoxColumn.HeaderText = "barkodu";
			this.barkoduDataGridViewTextBoxColumn.Name = "barkoduDataGridViewTextBoxColumn";
			// 
			// uadiDataGridViewTextBoxColumn
			// 
			this.uadiDataGridViewTextBoxColumn.DataPropertyName = "uadi";
			this.uadiDataGridViewTextBoxColumn.HeaderText = "uadi";
			this.uadiDataGridViewTextBoxColumn.Name = "uadiDataGridViewTextBoxColumn";
			// 
			// afiyatDataGridViewTextBoxColumn
			// 
			this.afiyatDataGridViewTextBoxColumn.DataPropertyName = "afiyat";
			this.afiyatDataGridViewTextBoxColumn.HeaderText = "afiyat";
			this.afiyatDataGridViewTextBoxColumn.Name = "afiyatDataGridViewTextBoxColumn";
			// 
			// sfiyatDataGridViewTextBoxColumn
			// 
			this.sfiyatDataGridViewTextBoxColumn.DataPropertyName = "sfiyat";
			this.sfiyatDataGridViewTextBoxColumn.HeaderText = "sfiyat";
			this.sfiyatDataGridViewTextBoxColumn.Name = "sfiyatDataGridViewTextBoxColumn";
			// 
			// kdvDataGridViewTextBoxColumn
			// 
			this.kdvDataGridViewTextBoxColumn.DataPropertyName = "kdv";
			this.kdvDataGridViewTextBoxColumn.HeaderText = "kdv";
			this.kdvDataGridViewTextBoxColumn.Name = "kdvDataGridViewTextBoxColumn";
			// 
			// alinanmiktarDataGridViewTextBoxColumn
			// 
			this.alinanmiktarDataGridViewTextBoxColumn.DataPropertyName = "alinan_miktar";
			this.alinanmiktarDataGridViewTextBoxColumn.HeaderText = "alinan_miktar";
			this.alinanmiktarDataGridViewTextBoxColumn.Name = "alinanmiktarDataGridViewTextBoxColumn";
			// 
			// satilanmiktarDataGridViewTextBoxColumn
			// 
			this.satilanmiktarDataGridViewTextBoxColumn.DataPropertyName = "satilan_miktar";
			this.satilanmiktarDataGridViewTextBoxColumn.HeaderText = "satilan_miktar";
			this.satilanmiktarDataGridViewTextBoxColumn.Name = "satilanmiktarDataGridViewTextBoxColumn";
			// 
			// kalanmiktarDataGridViewTextBoxColumn
			// 
			this.kalanmiktarDataGridViewTextBoxColumn.DataPropertyName = "kalan_miktar";
			this.kalanmiktarDataGridViewTextBoxColumn.HeaderText = "kalan_miktar";
			this.kalanmiktarDataGridViewTextBoxColumn.Name = "kalanmiktarDataGridViewTextBoxColumn";
			// 
			// UrunListesi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(960, 450);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.groupBox1);
			this.Name = "UrunListesi";
			this.Text = "UrunListesi";
			this.Load += new System.EventHandler(this.UrunListesi_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.urunTanimBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cafeOtomasyonuDataSet)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtArama;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CafeOtomasyonuDataSet cafeOtomasyonuDataSet;
        private System.Windows.Forms.BindingSource urunTanimBindingSource;
        private CafeOtomasyonuDataSetTableAdapters.Urun_TanimTableAdapter urun_TanimTableAdapter;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn uidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn barkoduDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn uadiDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn afiyatDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn sfiyatDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn kdvDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn alinanmiktarDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn satilanmiktarDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn kalanmiktarDataGridViewTextBoxColumn;
	}
}