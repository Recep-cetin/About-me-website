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
	public partial class FaturaAlisListesi : Form
	{
		public FaturaAlisListesi()
		{
			InitializeComponent();
		}
		public static string GelenForm;

		private void FaturaAlisListesi_Load(object sender, EventArgs e)
		{
			alisUstTableAdapter.FaturaAlisListesi(cafeOtomasyonuDataSet.AlisUst, "01.01.1900", DateTime.Today.ToString());

		}

		private void button1_Click(object sender, EventArgs e)
		{
			alisUstTableAdapter.FaturaAlisListesi(cafeOtomasyonuDataSet.AlisUst, dateTimePicker1.Text, dateTimePicker2.Text);
		}

		private void dataGridView1_DoubleClick(object sender, EventArgs e)
		{

			if (GelenForm == "Fatura Alış")
			{
				DataRowView AktifKayit;
				AktifKayit = (DataRowView)alisUstBindingSource.Current;
				// MessageBox.Show(AktifKayit["ad"].ToString());
				faturaalis.fustid = Convert.ToInt32(AktifKayit["fustid"].ToString());
			}
			Close();
		}
	}
}
