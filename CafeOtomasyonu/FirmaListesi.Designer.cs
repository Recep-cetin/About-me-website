namespace CafeOtomasyonu
{
    partial class FirmaListesi
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
			this.unvanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.masasayisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.firmaTanimBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cafeOtomasyonuDataSet = new CafeOtomasyonu.CafeOtomasyonuDataSet();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.TxtArama = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.firmaTanimTableAdapter = new CafeOtomasyonu.CafeOtomasyonuDataSetTableAdapters.FirmaTanimTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.firmaTanimBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cafeOtomasyonuDataSet)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.unvanDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.masasayisi,
            this.adresDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.firmaTanimBindingSource;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGridView1.Location = new System.Drawing.Point(0, 90);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(696, 360);
			this.dataGridView1.TabIndex = 7;
			// 
			// unvanDataGridViewTextBoxColumn
			// 
			this.unvanDataGridViewTextBoxColumn.DataPropertyName = "unvan";
			this.unvanDataGridViewTextBoxColumn.HeaderText = "UNVAN";
			this.unvanDataGridViewTextBoxColumn.Name = "unvanDataGridViewTextBoxColumn";
			this.unvanDataGridViewTextBoxColumn.ReadOnly = true;
			this.unvanDataGridViewTextBoxColumn.Width = 150;
			// 
			// telDataGridViewTextBoxColumn
			// 
			this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
			this.telDataGridViewTextBoxColumn.HeaderText = "TEL";
			this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
			this.telDataGridViewTextBoxColumn.ReadOnly = true;
			this.telDataGridViewTextBoxColumn.Width = 150;
			// 
			// masasayisi
			// 
			this.masasayisi.DataPropertyName = "masasayisi";
			this.masasayisi.HeaderText = "MASA SAYISI";
			this.masasayisi.Name = "masasayisi";
			this.masasayisi.ReadOnly = true;
			// 
			// adresDataGridViewTextBoxColumn
			// 
			this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
			this.adresDataGridViewTextBoxColumn.HeaderText = "ADRES";
			this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
			this.adresDataGridViewTextBoxColumn.ReadOnly = true;
			this.adresDataGridViewTextBoxColumn.Width = 200;
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
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.groupBox1.Controls.Add(this.TxtArama);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(696, 78);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Arama";
			// 
			// TxtArama
			// 
			this.TxtArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.TxtArama.Location = new System.Drawing.Point(95, 30);
			this.TxtArama.Name = "TxtArama";
			this.TxtArama.Size = new System.Drawing.Size(393, 30);
			this.TxtArama.TabIndex = 0;
			this.TxtArama.TextChanged += new System.EventHandler(this.TxtArama_TextChanged);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(696, 84);
			this.panel1.TabIndex = 6;
			// 
			// firmaTanimTableAdapter
			// 
			this.firmaTanimTableAdapter.ClearBeforeFill = true;
			// 
			// FirmaListesi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(696, 450);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel1);
			this.Name = "FirmaListesi";
			this.Text = "FirmaListesi";
			this.Load += new System.EventHandler(this.FirmaListesi_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.firmaTanimBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cafeOtomasyonuDataSet)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtArama;
        private System.Windows.Forms.Panel panel1;
        private CafeOtomasyonuDataSet cafeOtomasyonuDataSet;
        private System.Windows.Forms.BindingSource firmaTanimBindingSource;
        private CafeOtomasyonuDataSetTableAdapters.FirmaTanimTableAdapter firmaTanimTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn unvanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn masasayisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
    }
}