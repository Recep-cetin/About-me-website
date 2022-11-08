namespace CafeOtomasyonu
{
    partial class FaturaSatisListesi
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.fustidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.midDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.seriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.alisUstBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cafeOtomasyonuDataSet = new CafeOtomasyonu.CafeOtomasyonuDataSet();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnArama = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.alisUstTableAdapter = new CafeOtomasyonu.CafeOtomasyonuDataSetTableAdapters.AlisUstTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.alisUstBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cafeOtomasyonuDataSet)).BeginInit();
			this.panel1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fustidDataGridViewTextBoxColumn,
            this.midDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn,
            this.seriDataGridViewTextBoxColumn,
            this.noDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.alisUstBindingSource;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 92);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(800, 358);
			this.dataGridView1.TabIndex = 6;
			this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
			// 
			// fustidDataGridViewTextBoxColumn
			// 
			this.fustidDataGridViewTextBoxColumn.DataPropertyName = "fustid";
			this.fustidDataGridViewTextBoxColumn.HeaderText = "fustid";
			this.fustidDataGridViewTextBoxColumn.Name = "fustidDataGridViewTextBoxColumn";
			this.fustidDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// midDataGridViewTextBoxColumn
			// 
			this.midDataGridViewTextBoxColumn.DataPropertyName = "mid";
			this.midDataGridViewTextBoxColumn.HeaderText = "mid";
			this.midDataGridViewTextBoxColumn.Name = "midDataGridViewTextBoxColumn";
			// 
			// tarihDataGridViewTextBoxColumn
			// 
			this.tarihDataGridViewTextBoxColumn.DataPropertyName = "tarih";
			this.tarihDataGridViewTextBoxColumn.HeaderText = "tarih";
			this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
			// 
			// seriDataGridViewTextBoxColumn
			// 
			this.seriDataGridViewTextBoxColumn.DataPropertyName = "seri";
			this.seriDataGridViewTextBoxColumn.HeaderText = "seri";
			this.seriDataGridViewTextBoxColumn.Name = "seriDataGridViewTextBoxColumn";
			// 
			// noDataGridViewTextBoxColumn
			// 
			this.noDataGridViewTextBoxColumn.DataPropertyName = "no";
			this.noDataGridViewTextBoxColumn.HeaderText = "no";
			this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
			// 
			// adDataGridViewTextBoxColumn
			// 
			this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
			this.adDataGridViewTextBoxColumn.HeaderText = "ad";
			this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
			// 
			// soyadDataGridViewTextBoxColumn
			// 
			this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
			this.soyadDataGridViewTextBoxColumn.HeaderText = "soyad";
			this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
			// 
			// alisUstBindingSource
			// 
			this.alisUstBindingSource.DataMember = "AlisUst";
			this.alisUstBindingSource.DataSource = this.cafeOtomasyonuDataSet;
			// 
			// cafeOtomasyonuDataSet
			// 
			this.cafeOtomasyonuDataSet.DataSetName = "CafeOtomasyonuDataSet";
			this.cafeOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 92);
			this.panel1.TabIndex = 5;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnArama);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.dateTimePicker2);
			this.groupBox2.Controls.Add(this.dateTimePicker1);
			this.groupBox2.Location = new System.Drawing.Point(52, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(268, 68);
			this.groupBox2.TabIndex = 21;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "İki Tarih Arası Arama";
			// 
			// btnArama
			// 
			this.btnArama.Location = new System.Drawing.Point(188, 19);
			this.btnArama.Name = "btnArama";
			this.btnArama.Size = new System.Drawing.Size(58, 23);
			this.btnArama.TabIndex = 4;
			this.btnArama.Text = "Ara";
			this.btnArama.UseVisualStyleBackColor = true;
			this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Son Tarih";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "ilk Tarih";
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker2.Location = new System.Drawing.Point(58, 37);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(124, 20);
			this.dateTimePicker2.TabIndex = 1;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(58, 11);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(124, 20);
			this.dateTimePicker1.TabIndex = 0;
			// 
			// alisUstTableAdapter
			// 
			this.alisUstTableAdapter.ClearBeforeFill = true;
			// 
			// FaturaSatisListesi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel1);
			this.Name = "FaturaSatisListesi";
			this.Text = "FaturaSatisListesi";
			this.Load += new System.EventHandler(this.FaturaSatisListesi_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.alisUstBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cafeOtomasyonuDataSet)).EndInit();
			this.panel1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnArama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fustidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn midDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource alisUstBindingSource;
        private CafeOtomasyonuDataSet cafeOtomasyonuDataSet;
        private CafeOtomasyonuDataSetTableAdapters.AlisUstTableAdapter alisUstTableAdapter;
    }
}