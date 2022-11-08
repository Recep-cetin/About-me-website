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
	public partial class GelirGider : Form
	{
		public GelirGider()
		{
			InitializeComponent();
		}

		private void GelirGider_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'cafeOtomasyonuDataSet.Musteri_Tanim' table. You can move, or remove it, as needed.
			this.musteri_TanimTableAdapter.Fill(this.cafeOtomasyonuDataSet.Musteri_Tanim);
			// TODO: This line of code loads data into the 'cafeOtomasyonuDataSet.Urun_Tanim' table. You can move, or remove it, as needed.
			this.urun_TanimTableAdapter.Fill(this.cafeOtomasyonuDataSet.Urun_Tanim);

            GiGeneltoplam();
            GeGeneltoplam();
            ciro();

        }

        private void button1_Click(object sender, EventArgs e)
		{

		}
        public static double giAraToplam = 0;
        public static double geAraToplam = 0;
        public static double gidenGenelToplam = 0;
        public static double gelenGenelToplam = 0;
        public static double giToplamkdv = 0;
        public static double geToplamkdv = 0;



        public void GeGeneltoplam()
		{
            Double AraToplam = 0, sfiyat = 0, tutar =0,kdv = 0, ToplamKdv = 0, GenelToplam = 0 ,satilanmiktar = 0;
            int kayitsayisi, sirasi;
            DataRowView DetayKayit;
            kayitsayisi = urunTanimBindingSource.Count;
            sirasi = urunTanimBindingSource.Position;
            urunTanimBindingSource.MoveFirst();
            for (int i = 1; i <= kayitsayisi; i++)
            {
                DetayKayit = (DataRowView)urunTanimBindingSource.Current;
                if (DetayKayit["sfiyat"].ToString().Trim() == "")
                    sfiyat = 0;
                else
                    sfiyat = Convert.ToDouble(DetayKayit["sfiyat"].ToString());
                if (DetayKayit["kdv"].ToString().Trim() == "")
                    kdv = 0;
                else
                    kdv = Convert.ToDouble(DetayKayit["kdv"].ToString());
                if (DetayKayit["satilan_miktar"].ToString().Trim() == "")
                    satilanmiktar = 0;
                else
                    satilanmiktar = Convert.ToDouble(DetayKayit["satilan_miktar"].ToString());

                tutar = satilanmiktar * sfiyat;
                AraToplam = AraToplam + tutar;
                kdv = tutar * kdv / 100;
                ToplamKdv = ToplamKdv + kdv;
                urunTanimBindingSource.MoveNext();

            }
            GenelToplam = AraToplam + ToplamKdv;
            gelblAraToplam.Text = AraToplam.ToString();
            geToplamKdv.Text = ToplamKdv.ToString();
            geGenelToplam.Text = GenelToplam.ToString();
            urunTanimBindingSource.Position = sirasi;

            geAraToplam = AraToplam;
            gelenGenelToplam = GenelToplam;
            geToplamkdv = ToplamKdv;
        }
        public void GiGeneltoplam()
        {
            Double AraToplam = 0, afiyat = 0, tutar = 0, kdv = 0, ToplamKdv = 0, GenelToplam = 0, alinanmiktar = 0;
            int kayitsayisi, sirasi;
            DataRowView DetayKayit;
            kayitsayisi = urunTanimBindingSource.Count;
            sirasi = urunTanimBindingSource.Position;
            urunTanimBindingSource.MoveFirst();
            for (int i = 1; i <= kayitsayisi; i++)
            {
                DetayKayit = (DataRowView)urunTanimBindingSource.Current;
                if (DetayKayit["afiyat"].ToString().Trim() == "")
                    afiyat = 0;
                else
                    afiyat = Convert.ToDouble(DetayKayit["afiyat"].ToString());
                if (DetayKayit["kdv"].ToString().Trim() == "")
                    kdv = 0;
                else
                    kdv = Convert.ToDouble(DetayKayit["kdv"].ToString());
                if (DetayKayit["alinan_miktar"].ToString().Trim() == "")
                    alinanmiktar = 0;
                else
                    alinanmiktar = Convert.ToDouble(DetayKayit["alinan_miktar"].ToString());

                tutar = alinanmiktar * afiyat;
                AraToplam = AraToplam + tutar;
                kdv = tutar * kdv / 100;
                ToplamKdv = ToplamKdv + kdv;
                urunTanimBindingSource.MoveNext();

            }
            GenelToplam = AraToplam + ToplamKdv;
            gilblAraToplam.Text = AraToplam.ToString();
            giToplamKdv.Text = ToplamKdv.ToString();
            giGenelToplam.Text = GenelToplam.ToString();
            urunTanimBindingSource.Position = sirasi;

            giAraToplam = AraToplam;
            gidenGenelToplam = GenelToplam;
            giToplamkdv = ToplamKdv;

        }

        public void ciro()
		{
            double geneltoplam = 0, aratoplam = 0, kdv = 0;

            aratoplam = geAraToplam - giAraToplam;
            kdv = geToplamkdv - giToplamkdv;
            geneltoplam = gelenGenelToplam - gidenGenelToplam;

            cilblAraToplam.Text=aratoplam.ToString();   
            ciToplamKdv.Text = kdv.ToString();
            ciGenelToplam.Text =    geneltoplam.ToString(); 
        }
    }
}
