namespace CafeOtomasyonu
{
	partial class KarZarar
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.cafeOtomasyonuDataSet = new CafeOtomasyonu.CafeOtomasyonuDataSet();
			this.vWKarZararBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.vW_KarZararTableAdapter = new CafeOtomasyonu.CafeOtomasyonuDataSetTableAdapters.VW_KarZararTableAdapter();
			this.türDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.seriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.uadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.miktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.kdvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cafeOtomasyonuDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vWKarZararBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Aqua;
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.dateTimePicker2);
			this.panel1.Controls.Add(this.dateTimePicker1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1081, 193);
			this.panel1.TabIndex = 5;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Location = new System.Drawing.Point(600, 26);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(373, 97);
			this.groupBox1.TabIndex = 22;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Kar Zarar";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label15.ForeColor = System.Drawing.Color.Maroon;
			this.label15.Location = new System.Drawing.Point(145, 16);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(20, 24);
			this.label15.TabIndex = 21;
			this.label15.Text = "0";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label14.Location = new System.Drawing.Point(33, 16);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(97, 24);
			this.label14.TabIndex = 18;
			this.label14.Text = "Kar Zarar :";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(123, 75);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Ara";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker2.Location = new System.Drawing.Point(204, 35);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(101, 20);
			this.dateTimePicker2.TabIndex = 1;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(65, 35);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(101, 20);
			this.dateTimePicker1.TabIndex = 0;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.türDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn,
            this.seriDataGridViewTextBoxColumn,
            this.noDataGridViewTextBoxColumn,
            this.uadiDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn,
            this.miktarDataGridViewTextBoxColumn,
            this.kdvDataGridViewTextBoxColumn,
            this.tutarDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.vWKarZararBindingSource;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 193);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(1081, 444);
			this.dataGridView1.TabIndex = 6;
			// 
			// cafeOtomasyonuDataSet
			// 
			this.cafeOtomasyonuDataSet.DataSetName = "CafeOtomasyonuDataSet";
			this.cafeOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// vWKarZararBindingSource
			// 
			this.vWKarZararBindingSource.DataMember = "VW_KarZarar";
			this.vWKarZararBindingSource.DataSource = this.cafeOtomasyonuDataSet;
			// 
			// vW_KarZararTableAdapter
			// 
			this.vW_KarZararTableAdapter.ClearBeforeFill = true;
			// 
			// türDataGridViewTextBoxColumn
			// 
			this.türDataGridViewTextBoxColumn.DataPropertyName = "Tür";
			this.türDataGridViewTextBoxColumn.HeaderText = "Tür";
			this.türDataGridViewTextBoxColumn.Name = "türDataGridViewTextBoxColumn";
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
			// uadiDataGridViewTextBoxColumn
			// 
			this.uadiDataGridViewTextBoxColumn.DataPropertyName = "uadi";
			this.uadiDataGridViewTextBoxColumn.HeaderText = "uadi";
			this.uadiDataGridViewTextBoxColumn.Name = "uadiDataGridViewTextBoxColumn";
			// 
			// fiyatDataGridViewTextBoxColumn
			// 
			this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "fiyat";
			this.fiyatDataGridViewTextBoxColumn.HeaderText = "fiyat";
			this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
			// 
			// miktarDataGridViewTextBoxColumn
			// 
			this.miktarDataGridViewTextBoxColumn.DataPropertyName = "miktar";
			this.miktarDataGridViewTextBoxColumn.HeaderText = "miktar";
			this.miktarDataGridViewTextBoxColumn.Name = "miktarDataGridViewTextBoxColumn";
			// 
			// kdvDataGridViewTextBoxColumn
			// 
			this.kdvDataGridViewTextBoxColumn.DataPropertyName = "kdv";
			this.kdvDataGridViewTextBoxColumn.HeaderText = "kdv";
			this.kdvDataGridViewTextBoxColumn.Name = "kdvDataGridViewTextBoxColumn";
			// 
			// tutarDataGridViewTextBoxColumn
			// 
			this.tutarDataGridViewTextBoxColumn.DataPropertyName = "tutar";
			this.tutarDataGridViewTextBoxColumn.HeaderText = "tutar";
			this.tutarDataGridViewTextBoxColumn.Name = "tutarDataGridViewTextBoxColumn";
			// 
			// KarZarar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1081, 637);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel1);
			this.Name = "KarZarar";
			this.Text = "KarZarar";
			this.Load += new System.EventHandler(this.KarZarar_Load);
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cafeOtomasyonuDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vWKarZararBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn türDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn seriDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn uadiDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn miktarDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn kdvDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tutarDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource vWKarZararBindingSource;
		private CafeOtomasyonuDataSet cafeOtomasyonuDataSet;
		private CafeOtomasyonuDataSetTableAdapters.VW_KarZararTableAdapter vW_KarZararTableAdapter;
	}
}