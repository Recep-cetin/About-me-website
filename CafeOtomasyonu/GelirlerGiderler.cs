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
	public partial class GelirlerGiderler : Form
	{
		public GelirlerGiderler()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			vW_GelirTableAdapter.Fill(cafeOtomasyonuDataSet.VW_Gelir, dateTimePicker1.Text, dateTimePicker2.Text);
			vW_GiderTableAdapter.Fill(cafeOtomasyonuDataSet.VW_Gider, dateTimePicker1.Text, dateTimePicker2.Text);
			GelirBul();
			GiderBul();
			Ciro();
		}

        private void GelirBul()
        {
            DataRowView Gelir;
            Double AraToplam = 0, tutar = 0, kdv = 0, ToplamKdv = 0, GenelToplam = 0;
            int kayitsayisi, sirasi;
            kayitsayisi = vWGelirBindingSource.Count;
            sirasi = vWGelirBindingSource.Position;
            vWGelirBindingSource.MoveFirst();
            for (int i = 1; i <= kayitsayisi; i++)
            {
                Gelir = (DataRowView)vWGelirBindingSource.Current;
                if (Gelir["tutar"].ToString().Trim() == "")
                    tutar = 0;
                else
                    tutar = Convert.ToDouble(Gelir["tutar"].ToString());
                if (Gelir["kdv"].ToString().Trim() == "")
                    kdv = 0;
                else
                    kdv = Convert.ToDouble(Gelir["kdv"].ToString());
                AraToplam = AraToplam + tutar;
                kdv = tutar * kdv / 100;
                ToplamKdv = ToplamKdv + kdv;
                vWGelirBindingSource.MoveNext();
            }
            GenelToplam = AraToplam + ToplamKdv;
            label15.Text = GenelToplam.ToString();
            label16.Text = ToplamKdv.ToString();
            label17.Text = AraToplam.ToString();

            vWGelirBindingSource.Position = sirasi;
        }

        private void GiderBul()
        {
            DataRowView Gider;
            Double AraToplam = 0, tutar = 0, kdv = 0, ToplamKdv = 0, GenelToplam = 0;
            int kayitsayisi, sirasi;
            kayitsayisi = vWGiderBindingSource.Count;
            sirasi = vWGiderBindingSource.Position;
            vWGiderBindingSource.MoveFirst();
            for (int i = 1; i <= kayitsayisi; i++)
            {
                Gider = (DataRowView)vWGiderBindingSource.Current;
                if (Gider["tutar"].ToString().Trim() == "")
                    tutar = 0;
                else
                    tutar = Convert.ToDouble(Gider["tutar"].ToString());
                if (Gider["kdv"].ToString().Trim() == "")
                    kdv = 0;
                else
                    kdv = Convert.ToDouble(Gider["kdv"].ToString());
                AraToplam = AraToplam + tutar;
                kdv = tutar * kdv / 100;
                ToplamKdv = ToplamKdv + kdv;
                vWGiderBindingSource.MoveNext();
            }
            GenelToplam = AraToplam + ToplamKdv;
            label2.Text = GenelToplam.ToString();
            label4.Text = ToplamKdv.ToString();
            label6.Text = AraToplam.ToString();

            vWGiderBindingSource.Position = sirasi;
        }

        private void Ciro()
        {
            double geliraratoplam = 0, gelirkdv = 0, gelirgeneltoplam = 0;
            double gideraratoplam = 0, giderkdv = 0, gidergeneltoplam = 0;
            double ciroaratoplam = 0, cirokdv = 0, cirogeneltoplam = 0;

            geliraratoplam = Convert.ToDouble(label17.Text);
            gelirkdv = Convert.ToDouble(label16.Text);
            gelirgeneltoplam = Convert.ToDouble(label15.Text);
            gideraratoplam = Convert.ToDouble(label16.Text);
            giderkdv = Convert.ToDouble(label4.Text);
            gidergeneltoplam = Convert.ToDouble(label2.Text);

            ciroaratoplam = geliraratoplam - gideraratoplam;
            cirokdv = gelirkdv - giderkdv;
            cirogeneltoplam = gelirgeneltoplam - gidergeneltoplam;
            label8.Text = ciroaratoplam.ToString();
            label10.Text = cirokdv.ToString();
            label18.Text = cirogeneltoplam.ToString();
        }

		private void GelirlerGiderler_Load(object sender, EventArgs e)
		{
            vW_GelirTableAdapter.Fill(cafeOtomasyonuDataSet.VW_Gelir, dateTimePicker1.Text, dateTimePicker2.Text);
            vW_GiderTableAdapter.Fill(cafeOtomasyonuDataSet.VW_Gider, dateTimePicker1.Text, dateTimePicker2.Text);
            GelirBul();
            GiderBul();
            Ciro();
        }
	}
}
