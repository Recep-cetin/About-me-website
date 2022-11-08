using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyonu
{
	public partial class StokTakip : Form
	{
		public StokTakip()
		{
			InitializeComponent();
		}

		public static string uid = "-1", uad = "";

		private void button1_Click(object sender, EventArgs e)
		{
			Getir();
			GenelToplam();
		}

		private void Getir()
		{
			if (uid == "-1")
			{
				vW_StokSatisTableAdapter.Hepsi(cafeOtomasyonuDataSet.VW_StokSatis, dateTimePicker1.Text, dateTimePicker2.Text);
				vW_StokAlisTableAdapter.Hepsi(cafeOtomasyonuDataSet.VW_StokAlis, dateTimePicker1.Text, dateTimePicker2.Text);
			}
			else
			{
				vW_StokSatisTableAdapter.Fill(cafeOtomasyonuDataSet.VW_StokSatis, dateTimePicker1.Text, dateTimePicker2.Text, Convert.ToInt32(uid));
				vW_StokAlisTableAdapter.Fill(cafeOtomasyonuDataSet.VW_StokAlis, dateTimePicker1.Text, dateTimePicker2.Text, Convert.ToInt32(uid));
			}
			GenelToplam();
		}

		private void ürünListesiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			uid = "-1";
			UrunListesi.GelenForm = "StokTakip";
			UrunListesi yeni = new UrunListesi();
			yeni.ShowDialog();
			if (uid != "-1")
			{
				textBox1.Text = uad;
				Getir();
				GenelToplam();
			}
		}

		private void StokTakip_Load(object sender, EventArgs e)
		{
			Getir();
		}

		private void GenelToplam()
		{
			double kalan = 0, alis = 0, satis = 0;
			for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
			{
				DataGridViewCell miktar = dataGridView1[7, i];
				satis += Convert.ToDouble(miktar.Value);
			}
			for (int i = 0; i <= dataGridView2.RowCount - 1; i++)
			{
				DataGridViewCell miktar = dataGridView2[7, i];
				alis += Convert.ToDouble(miktar.Value);
			}
			kalan = alis - satis;
			lblalinanmiktar.Text = alis.ToString();
			lblsatilanmiktar.Text = satis.ToString();
			lblkalanmiktar.Text = kalan.ToString();
		}

	}
}
