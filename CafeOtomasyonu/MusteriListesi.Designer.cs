namespace CafeOtomasyonu
{
    partial class MusteriListesi
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
			this.TxtArama = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.musteriTanimBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cafeOtomasyonuDataSet = new CafeOtomasyonu.CafeOtomasyonuDataSet();
			this.musteri_TanimTableAdapter = new CafeOtomasyonu.CafeOtomasyonuDataSetTableAdapters.Musteri_TanimTableAdapter();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.musteriTanimBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cafeOtomasyonuDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.groupBox1.Controls.Add(this.TxtArama);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(800, 78);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Arama";
			// 
			// TxtArama
			// 
			this.TxtArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.TxtArama.Location = new System.Drawing.Point(145, 19);
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
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.musteriTanimBindingSource;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 78);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(800, 372);
			this.dataGridView1.TabIndex = 3;
			this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
			// 
			// adDataGridViewTextBoxColumn
			// 
			this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
			this.adDataGridViewTextBoxColumn.HeaderText = "AD";
			this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
			this.adDataGridViewTextBoxColumn.Width = 150;
			// 
			// soyadDataGridViewTextBoxColumn
			// 
			this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
			this.soyadDataGridViewTextBoxColumn.HeaderText = "SOYAD";
			this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
			this.soyadDataGridViewTextBoxColumn.Width = 150;
			// 
			// adresDataGridViewTextBoxColumn
			// 
			this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
			this.adresDataGridViewTextBoxColumn.HeaderText = "ADRES";
			this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
			this.adresDataGridViewTextBoxColumn.Width = 200;
			// 
			// telDataGridViewTextBoxColumn
			// 
			this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
			this.telDataGridViewTextBoxColumn.HeaderText = "TELNO";
			this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
			this.telDataGridViewTextBoxColumn.Width = 150;
			// 
			// musteriTanimBindingSource
			// 
			this.musteriTanimBindingSource.DataMember = "Musteri_Tanim";
			this.musteriTanimBindingSource.DataSource = this.cafeOtomasyonuDataSet;
			// 
			// cafeOtomasyonuDataSet
			// 
			this.cafeOtomasyonuDataSet.DataSetName = "CafeOtomasyonuDataSet";
			this.cafeOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// musteri_TanimTableAdapter
			// 
			this.musteri_TanimTableAdapter.ClearBeforeFill = true;
			// 
			// MusteriListesi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.groupBox1);
			this.Name = "MusteriListesi";
			this.Text = "MusteriListesi";
			this.Load += new System.EventHandler(this.MusteriListesi_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.musteriTanimBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cafeOtomasyonuDataSet)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtArama;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CafeOtomasyonuDataSet cafeOtomasyonuDataSet;
        private CafeOtomasyonuDataSetTableAdapters.Musteri_TanimTableAdapter musteri_TanimTableAdapter;
        private System.Windows.Forms.BindingSource musteriTanimBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
    }
}