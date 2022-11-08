namespace CafeOtomasyonu
{
	partial class test
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
			this.msdetayidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.msustidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.uidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.barkodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.uadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.miktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sfiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.kdvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.masaSatisDetayBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cafeOtomasyonuDataSet = new CafeOtomasyonu.CafeOtomasyonuDataSet();
			this.masaSatisDetayTableAdapter = new CafeOtomasyonu.CafeOtomasyonuDataSetTableAdapters.MasaSatisDetayTableAdapter();
			this.panel1 = new System.Windows.Forms.Panel();
			this.TxtArama = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.masaSatisDetayBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cafeOtomasyonuDataSet)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.msdetayidDataGridViewTextBoxColumn,
            this.msustidDataGridViewTextBoxColumn,
            this.uidDataGridViewTextBoxColumn,
            this.barkodDataGridViewTextBoxColumn,
            this.uadiDataGridViewTextBoxColumn,
            this.miktarDataGridViewTextBoxColumn,
            this.sfiyatDataGridViewTextBoxColumn,
            this.kdvDataGridViewTextBoxColumn,
            this.tutarDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.masaSatisDetayBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(0, 198);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(1124, 435);
			this.dataGridView1.TabIndex = 0;
			// 
			// msdetayidDataGridViewTextBoxColumn
			// 
			this.msdetayidDataGridViewTextBoxColumn.DataPropertyName = "ms_detayid";
			this.msdetayidDataGridViewTextBoxColumn.HeaderText = "ms_detayid";
			this.msdetayidDataGridViewTextBoxColumn.Name = "msdetayidDataGridViewTextBoxColumn";
			this.msdetayidDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// msustidDataGridViewTextBoxColumn
			// 
			this.msustidDataGridViewTextBoxColumn.DataPropertyName = "ms_ustid";
			this.msustidDataGridViewTextBoxColumn.HeaderText = "ms_ustid";
			this.msustidDataGridViewTextBoxColumn.Name = "msustidDataGridViewTextBoxColumn";
			// 
			// uidDataGridViewTextBoxColumn
			// 
			this.uidDataGridViewTextBoxColumn.DataPropertyName = "uid";
			this.uidDataGridViewTextBoxColumn.HeaderText = "uid";
			this.uidDataGridViewTextBoxColumn.Name = "uidDataGridViewTextBoxColumn";
			// 
			// barkodDataGridViewTextBoxColumn
			// 
			this.barkodDataGridViewTextBoxColumn.DataPropertyName = "barkod";
			this.barkodDataGridViewTextBoxColumn.HeaderText = "barkod";
			this.barkodDataGridViewTextBoxColumn.Name = "barkodDataGridViewTextBoxColumn";
			// 
			// uadiDataGridViewTextBoxColumn
			// 
			this.uadiDataGridViewTextBoxColumn.DataPropertyName = "uadi";
			this.uadiDataGridViewTextBoxColumn.HeaderText = "uadi";
			this.uadiDataGridViewTextBoxColumn.Name = "uadiDataGridViewTextBoxColumn";
			// 
			// miktarDataGridViewTextBoxColumn
			// 
			this.miktarDataGridViewTextBoxColumn.DataPropertyName = "miktar";
			this.miktarDataGridViewTextBoxColumn.HeaderText = "miktar";
			this.miktarDataGridViewTextBoxColumn.Name = "miktarDataGridViewTextBoxColumn";
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
			// tutarDataGridViewTextBoxColumn
			// 
			this.tutarDataGridViewTextBoxColumn.DataPropertyName = "tutar";
			this.tutarDataGridViewTextBoxColumn.HeaderText = "tutar";
			this.tutarDataGridViewTextBoxColumn.Name = "tutarDataGridViewTextBoxColumn";
			// 
			// masaSatisDetayBindingSource
			// 
			this.masaSatisDetayBindingSource.DataMember = "MasaSatisDetay";
			this.masaSatisDetayBindingSource.DataSource = this.cafeOtomasyonuDataSet;
			// 
			// cafeOtomasyonuDataSet
			// 
			this.cafeOtomasyonuDataSet.DataSetName = "CafeOtomasyonuDataSet";
			this.cafeOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// masaSatisDetayTableAdapter
			// 
			this.masaSatisDetayTableAdapter.ClearBeforeFill = true;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Cyan;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.TxtArama);
			this.panel1.Location = new System.Drawing.Point(12, 29);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1103, 100);
			this.panel1.TabIndex = 1;
			// 
			// TxtArama
			// 
			this.TxtArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.TxtArama.Location = new System.Drawing.Point(132, 51);
			this.TxtArama.Name = "TxtArama";
			this.TxtArama.Size = new System.Drawing.Size(199, 29);
			this.TxtArama.TabIndex = 0;
			this.TxtArama.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(132, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Arama";
			// 
			// test
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1127, 636);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "test";
			this.Text = "test";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.masaSatisDetayBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cafeOtomasyonuDataSet)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn msdetayidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn msustidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn uidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn barkodDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn uadiDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn miktarDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn sfiyatDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn kdvDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tutarDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource masaSatisDetayBindingSource;
		private CafeOtomasyonuDataSet cafeOtomasyonuDataSet;
		private CafeOtomasyonuDataSetTableAdapters.MasaSatisDetayTableAdapter masaSatisDetayTableAdapter;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox TxtArama;
		private System.Windows.Forms.Label label1;
	}
}