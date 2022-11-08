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
	public partial class faturaalis : Form
	{
		public faturaalis()
		{
			InitializeComponent();
		}

        DataRowView AktifKayitUst;
        DataRowView AktifKayitDetay;
        public static string ad, soyad, mid;
        public static string uid, uad, barkod, fiyat;
        public static int fustid = -1;


        private void faturaalis_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'cafeOtomasyonuDataSet.AlisUst' table. You can move, or remove it, as needed.
            Button_Kontrol(true);
            Kayitlar(-111111);
        }

		private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
		{
            int basilantus;
            basilantus = Convert.ToInt32(e.KeyChar);
            if (basilantus == 13)
            {
                TutarBul();
            }
        }

        private void Kayitlar(int id)
        {

            alisDetayTableAdapter.Fill(cafeOtomasyonuDataSet.AlisDetay, id);
            alisUstTableAdapter.Fill(cafeOtomasyonuDataSet.AlisUst, id);
            GenelToplam_Bul();

        }

        private void faturaAlışListesiToolStripMenuItem_Click(object sender, EventArgs e)
		{
            FaturaAlisListesi.GelenForm = "Fatura Alış";
            FaturaAlisListesi yeni = new FaturaAlisListesi();
            yeni.ShowDialog();
            if (fustid != -1)
            {
                Kayitlar(fustid);
            }
        }

		private void müşteriListesiToolStripMenuItem1_Click(object sender, EventArgs e)
		{
            mid = "-1";
            MusteriListesi.GelenForm = "Fatura Alış";

            MusteriListesi yeni = new MusteriListesi();
            yeni.ShowDialog();

            if (mid != "-1")
            {
                AktifKayitUst["ad"] = ad;
                AktifKayitUst["soyad"] = soyad;
                AktifKayitUst["mid"] = mid;
            }
        }

		private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
		{
            int basilantus;
            basilantus = Convert.ToInt32(e.KeyChar);
            if (basilantus == 13)
            {

                if (radioButton1.Checked)
                    urun_TanimTableAdapter.AdaGore(cafeOtomasyonuDataSet.Urun_Tanim, '%' + textBox11.Text + '%');
                else
                    urun_TanimTableAdapter.BarkodaGore(cafeOtomasyonuDataSet.Urun_Tanim, '%' + textBox11.Text + '%');

                if (urunTanimBindingSource.Count == 0)
                {
                    MessageBox.Show("ürün bulunamadı");
                    textBox11.Text = "";
                    return;
                }

                DataRowView AktifKayit;
                AktifKayit = (DataRowView)urunTanimBindingSource.Current;
                alisDetayBindingSource.AddNew();
                alisDetayBindingSource.EndEdit();
                AktifKayitDetay = (DataRowView)alisDetayBindingSource.Current;
                AktifKayitDetay["uid"] = AktifKayit["uid"].ToString();
                AktifKayitDetay["barkod"] = AktifKayit["barkodu"].ToString();
                AktifKayitDetay["uadi"] = AktifKayit["uadi"].ToString();

                if (AktifKayit["afiyat"].ToString().Trim() == "")
                    AktifKayitDetay["fiyat"] = "0";
                else
                    AktifKayitDetay["fiyat"] = AktifKayit["afiyat"].ToString();

                AktifKayitDetay["tutar"] = AktifKayitDetay["fiyat"];
                AktifKayitDetay["miktar"] = 1;
                AktifKayitDetay["kdv"] = 18;
                textBox11.Text = "";
                GenelToplam_Bul();
            }
        }

		private void btnYeni_Click(object sender, EventArgs e)
		{
            Kayitlar(-111111);
            Button_Kontrol(false);
            textBox1.Focus();
            alisUstBindingSource.AddNew();
            alisUstBindingSource.EndEdit();
            AktifKayitUst = (DataRowView)alisUstBindingSource.Current;
            AktifKayitUst["tarih"] = DateTime.Today;
        }

		private void btnDuzelt_Click(object sender, EventArgs e)
		{
            Button_Kontrol(false);
        }

		private void btnVazgec_Click(object sender, EventArgs e)
		{
            Button_Kontrol(true);
            AktifKayitUst = (DataRowView)alisUstBindingSource.Current;
            fustid = Convert.ToInt32(AktifKayitUst["fustid"].ToString());
            Kayitlar(fustid);
        }

		private void btnKaydet_Click(object sender, EventArgs e)
		{
            string fustid;
            int kayitsayisi;
            alisUstBindingSource.EndEdit();
            alisUstTableAdapter.Update(cafeOtomasyonuDataSet.AlisUst);
            cafeOtomasyonuDataSet.AlisUst.AcceptChanges();

            AktifKayitUst = (DataRowView)alisUstBindingSource.Current;
            fustid = AktifKayitUst["fustid"].ToString();
            alisDetayBindingSource.MoveFirst();
            kayitsayisi = alisDetayBindingSource.Count;
            for (int i = 1; i <= kayitsayisi; i++)
            {
                AktifKayitDetay = (DataRowView)alisDetayBindingSource.Current;
                AktifKayitDetay["fustid"] = fustid;
                alisDetayBindingSource.MoveNext();
            }
            alisDetayBindingSource.EndEdit();
            alisDetayTableAdapter.Update(cafeOtomasyonuDataSet.AlisDetay);
            cafeOtomasyonuDataSet.AlisDetay.AcceptChanges();
            GenelToplam_Bul();
            Button_Kontrol(true);
        }

		private void satırSilToolStripMenuItem_Click(object sender, EventArgs e)
		{
            alisDetayBindingSource.RemoveCurrent();
            GenelToplam_Bul();
        }

		private void ürünListesiToolStripMenuItem1_Click(object sender, EventArgs e)
		{
            uid = "-1";
            UrunListesi.GelenForm = "Fatura Alış";
            UrunListesi yeni = new UrunListesi();
            yeni.ShowDialog();
            if (uid != "-1")
            {
                alisDetayBindingSource.AddNew();
                alisDetayBindingSource.EndEdit();
                AktifKayitDetay = (DataRowView)alisDetayBindingSource.Current;
                AktifKayitDetay["uid"] = uid;
                AktifKayitDetay["barkod"] = barkod;
                AktifKayitDetay["uadi"] = uad;
                AktifKayitDetay["fiyat"] = fiyat;
                AktifKayitDetay["tutar"] = fiyat;
                AktifKayitDetay["miktar"] = 1;
                AktifKayitDetay["kdv"] = 18;
                GenelToplam_Bul();
            }
        }


        private void textBox7_Leave(object sender, EventArgs e)
		{
			TutarBul();
		}

        private void TutarBul()
        {
            double miktar = 0, fiyat = 0, tutar = 0;
            if (textBox6.Text.Trim() == "")
                fiyat = 0;
            else
                fiyat = Convert.ToDouble(textBox6.Text);

            if (textBox7.Text.Trim() == "")
                miktar = 0;
            else
                miktar = Convert.ToDouble(textBox7.Text);

            tutar = miktar * fiyat;
            textBox9.Text = tutar.ToString();
            GenelToplam_Bul();


        }

        private void Button_Kontrol(Boolean durum)
        {
            btnYeni.Enabled = durum;
            btnDuzelt.Enabled = durum;
            btnSil.Enabled = durum;
            btnVazgec.Enabled = !durum;
            müşteriListesiToolStripMenuItem1.Enabled = !durum;
            ürünListesiToolStripMenuItem1.Enabled = !durum;
            satırSilToolStripMenuItem.Enabled = !durum;

            btnKaydet.Enabled = !durum;
            textBox1.Enabled = !durum;
            textBox11.Enabled = !durum;

        }

        private void GenelToplam_Bul()
        {
            Double AraToplam = 0, tutar = 0, kdv = 0, ToplamKdv = 0, GenelToplam = 0;
            int kayitsayisi, sirasi;
            kayitsayisi = alisDetayBindingSource.Count;
            sirasi = alisDetayBindingSource.Position;
            alisDetayBindingSource.MoveFirst();
            for (int i = 1; i <= kayitsayisi; i++)
            {
                AktifKayitDetay = (DataRowView)alisDetayBindingSource.Current;
                if (AktifKayitDetay["tutar"].ToString().Trim() == "")
                    tutar = 0;
                else
                    tutar = Convert.ToDouble(AktifKayitDetay["tutar"].ToString());
                if (AktifKayitDetay["kdv"].ToString().Trim() == "")
                    kdv = 0;
                else
                    kdv = Convert.ToDouble(AktifKayitDetay["kdv"].ToString());
                AraToplam = AraToplam + tutar;
                kdv = tutar * kdv / 100;
                ToplamKdv = ToplamKdv + kdv;
                alisDetayBindingSource.MoveNext();

            }
            GenelToplam = AraToplam + ToplamKdv;
            label15.Text = GenelToplam.ToString();
            label16.Text = ToplamKdv.ToString();
            label17.Text = AraToplam.ToString();

            alisDetayBindingSource.Position = sirasi;


        }
    }
}
