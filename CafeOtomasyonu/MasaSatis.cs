using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

using Microsoft.Office.Interop.Excel;

namespace CafeOtomasyonu
{
    public partial class MasaSatis : Form
    {
        public MasaSatis()
        {
            InitializeComponent();
        }

        public string file_path = @"C:\Users\MONSTER\Desktop\CafeOtomasyonu\test.xlsx";

        public static string adi, soyadi;
        public static int genelid, hesapturu;


        public static string barkodu, cinsi;
        public static Double fiyat, kdv;
        public static int uid, ustid = -20000;

        private void MasaSatis_Load(object sender, EventArgs e)
        {

            Kayitlar(-2500);
            ButtonKontrol(true);
            MasaEkle();
        }
        private void Kayitlar(int gelenid)
        {
            masaSatisUstTableAdapter.Fill(this.cafeOtomasyonuDataSet.MasaSatisUst, gelenid);
            // TODO: This line of code loads data into the 'marketOtomasyonuDataSet.FaturaSatisDetay' table. You can move, or remove it, as needed.
            masaSatisDetayTableAdapter.Fill(this.cafeOtomasyonuDataSet.MasaSatisDetay, gelenid);
            GenelToplam_Bul();
        }
        private void MasaEkle()
        {
            int masasayisi;
            DataRowView kayitlar;
            firmaTanimTableAdapter.Fill(cafeOtomasyonuDataSet.FirmaTanim);
            kayitlar = (DataRowView)firmaTanimBindingSource.Current;
            masasayisi = Convert.ToInt32(kayitlar["masasayisi"].ToString());
            lbxMasalar.Items.Clear();
            for (int i = 1; i <= masasayisi; i++)
            {
                masaSatisUstTableAdapter.MasaKontrol(this.cafeOtomasyonuDataSet.MasaSatisUst, "Masa=" + (i.ToString()));
                if (masaSatisUstBindingSource.Count > 0)
                    lbxMasalar.Items.Add("Masa=" + (i.ToString()) + "  D");
                else
                    lbxMasalar.Items.Add("Masa=" + (i.ToString()));
            }
        }
        private void KayitArama(string masa)
        {
            masaSatisUstTableAdapter.MasaKontrol(this.cafeOtomasyonuDataSet.MasaSatisUst, masa);
            DataRowView UstKayit;
            UstKayit = (DataRowView)masaSatisUstBindingSource.Current;
            if (masaSatisUstBindingSource.Count > 0)
                ustid = Convert.ToInt32(UstKayit["ms_ustid"].ToString());
            else
                ustid = -12000;
            Kayitlar(ustid);
        }
        private void ButtonKontrol(Boolean durum)
        {
			btnYeni1.Enabled = durum;
			btnDuzelt1.Enabled = durum;
			btnSil1.Enabled = durum;
			btnVazgec1.Enabled = !durum;
			btnKaydet1.Enabled = !durum;
			satırSilToolStripMenuItem.Enabled = !durum;

            txtMasa.Enabled = !durum;
            txtSeri.Enabled = !durum;
            txtNo.Enabled = !durum;
            txtAciklama.Enabled = !durum;
            txtBarkod.Enabled = !durum;
            txtAdi.Enabled = !durum;
            txtMiktar.Enabled = !durum;
            txtFiyat.Enabled = !durum;
            txtKdv.Enabled = !durum;
            txtTutar.Enabled = !durum;
            txtArama.Enabled = !durum;
            cbbOdeme.Enabled = !durum;

            dtpTarih.Enabled = !durum;

            dataGridView1.ReadOnly = true;

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Kayitlar(-2500);
            masaSatisUstBindingSource.AddNew();
            masaSatisUstBindingSource.EndEdit();
            ButtonKontrol(false);
            cbbOdeme.Text = "Peşin";
            if (lbxMasalar.SelectedIndex > 0)
                txtMasa.Text = lbxMasalar.SelectedItem.ToString();
            txtArama.Focus();
            lblindirim.Text = "0000";
        }
        private void UrunBul()
        {
            urun_TanimTableAdapter.Arama(this.cafeOtomasyonuDataSet.Urun_Tanim, '%' + txtArama.Text.Trim() + '%');

            if (urunTanimBindingSource.Count > 0)
            {
                DataRowView BulunanUrun;// Aktif Kayıt
                BulunanUrun = (DataRowView)urunTanimBindingSource.Current;
                DataRowView DetayKayit;

                masaSatisDetayBindingSource.AddNew();
                masaSatisDetayBindingSource.EndEdit();

                DetayKayit = (DataRowView)masaSatisDetayBindingSource.Current;
                DetayKayit["uadi"] = BulunanUrun["uadi"].ToString();
                DetayKayit["barkod"] = BulunanUrun["barkodu"].ToString();
                DetayKayit["uid"] = Convert.ToInt32(BulunanUrun["uid"].ToString());
                if (BulunanUrun["sfiyat"].ToString().Trim() == "")
                    DetayKayit["sfiyat"] = 0;
                else
                    DetayKayit["sfiyat"] = Convert.ToDouble(BulunanUrun["sfiyat"].ToString());
                if (BulunanUrun["kdv"].ToString().Trim() == "")
                    DetayKayit["kdv"] = 0;
                else
                    DetayKayit["kdv"] = Convert.ToDouble(BulunanUrun["kdv"].ToString());
                DetayKayit["tutar"] = DetayKayit["sfiyat"];
                DetayKayit["miktar"] = 1;


                masaSatisDetayBindingSource.MoveLast();
                //ToplamTutarBul();

            }
            else
            {
                MessageBox.Show("Ürün Bulunamadı");
            }
            txtArama.Text = "";
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtArama_KeyPress(object sender, KeyPressEventArgs e)
        {
            int basilantus;
            basilantus = Convert.ToInt32((byte)e.KeyChar);

            if (basilantus == 13)
            {
                UrunBul();
                GenelToplam_Bul();
            }
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            //UrunBul();
        }

        private void lbxMasalar_DoubleClick(object sender, EventArgs e)
        {
            string masa = lbxMasalar.SelectedItem.ToString();
            if (btnYeni1.Enabled)
            {
                if (masa.IndexOf("  D") == -1)
                    KayitArama(masa);
                else
                    KayitArama(masa.Substring(0, masa.Length - 3));
            }

            else
                txtMasa.Text = lbxMasalar.SelectedItem.ToString();
        }

        private void btnHesapKapat_Click(object sender, EventArgs e)
        {
            if (masaSatisUstBindingSource.Count == 0) return;
            DataRowView UstKayit;

            UstKayit = (DataRowView)masaSatisUstBindingSource.Current;
            ustid = Convert.ToInt32(UstKayit["ms_ustid"].ToString());
            masaSatisUstBindingSource.EndEdit();
            UstKayit["durumu"] = 0;  

            masaSatisUstTableAdapter.Update(cafeOtomasyonuDataSet.MasaSatisUst);
            cafeOtomasyonuDataSet.MasaSatisUst.AcceptChanges();
            MasaEkle();
            Kayitlar(-12223);
        }

        private void btnDuzelt_Click(object sender, EventArgs e)
        {
            DataRowView UstKayit;
            UstKayit = (DataRowView)masaSatisUstBindingSource.Current;
            if (masaSatisUstBindingSource.Count == 0) return;
            ButtonKontrol(false);
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            DataRowView UstKayit;
            UstKayit = (DataRowView)masaSatisUstBindingSource.Current;
            ustid = Convert.ToInt32(UstKayit["ms_ustid"].ToString());
            Kayitlar(ustid);
            ButtonKontrol(true);
            //ToplamTutarBul();
        }

        private void txtMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            int basilantus;
            basilantus = Convert.ToInt32(e.KeyChar);
            if (basilantus == 13)
            {
                TutarBul();
            }
        }

        private void txtMiktar_Leave(object sender, EventArgs e)
        {
            TutarBul();
        }

		private void button1_Click(object sender, EventArgs e)
		{
            Excel.Application ExcelUygulama0;             // excel uygulaması tanımla
            Excel.Workbook CalismaKitabi0;                // çalışma Kitabı tanımla
            Excel.Worksheet CalismaSayfasi0;              // çalışma Sayfası tanımla               
            ExcelUygulama0 = new Excel.Application();     // yeni bir excel uygulaması yarat
            CalismaKitabi0 = ExcelUygulama0.Workbooks.Open(file_path);                  // dosyayı aç
            CalismaSayfasi0 = (Excel.Worksheet)CalismaKitabi0.Worksheets.get_Item(1);   // 1. sayfayı aç



            CalismaSayfasi0.Cells[1, 1] = "ms_detayid";                                // dataya yaz (satır, sutun)
            CalismaSayfasi0.Cells[1, 2] = "ms_ustid";                                // dataya yaz
            CalismaSayfasi0.Cells[1, 3] = "uid";
            CalismaSayfasi0.Cells[1, 4] = "barkod";                                // dataya yaz
            CalismaSayfasi0.Cells[1, 5] = "uadi";
            CalismaSayfasi0.Cells[1, 6] = "miktar";
            CalismaSayfasi0.Cells[1, 7] = "sfiyat";                                // dataya yaz
            CalismaSayfasi0.Cells[1, 8] = "kdv";  // dataya yaz
            CalismaSayfasi0.Cells[1, 9] = "tutar";


            int kayitsayisi, kayitsayisi2 ,secilenno;

            DataRowView AktifKayit ;// Aktif Kayıt 

            kayitsayisi = masaSatisDetayBindingSource.Count;
            masaSatisDetayBindingSource.MoveFirst();

            kayitsayisi2 = masaSatisUstBindingSource.Count;
            masaSatisUstBindingSource.MoveFirst();

            Range myRange;



            for (int i = 0; i < kayitsayisi; i++)
            {
                AktifKayit = (DataRowView)masaSatisDetayBindingSource.Current;

                CalismaSayfasi0.Cells[i + 2, 1] = AktifKayit["ms_detayid"].ToString();                        // dataya yaz (satır, sutun)
                CalismaSayfasi0.Cells[i + 2, 2] = AktifKayit["ms_ustid"].ToString();                           // dataya yaz
                CalismaSayfasi0.Cells[i + 2, 3] = AktifKayit["uid"].ToString();
                CalismaSayfasi0.Cells[i + 2, 4] = AktifKayit["barkod"].ToString();                           // dataya yaz
                CalismaSayfasi0.Cells[i + 2, 5] = AktifKayit["uadi"].ToString();
                CalismaSayfasi0.Cells[i + 2, 6] = AktifKayit["miktar"].ToString();                           // dataya yaz
                CalismaSayfasi0.Cells[i + 2, 7] = AktifKayit["sfiyat"].ToString();
                CalismaSayfasi0.Cells[i + 2, 8] = AktifKayit["kdv"].ToString();                           // dataya yaz
                CalismaSayfasi0.Cells[i + 2, 9] = AktifKayit["tutar"].ToString();

                myRange = (Range)CalismaSayfasi0.Cells[i + 2, 1]; myRange.EntireColumn.AutoFit();
                myRange = (Range)CalismaSayfasi0.Cells[i + 2, 2]; myRange.EntireColumn.AutoFit();
                myRange = (Range)CalismaSayfasi0.Cells[i + 2, 3]; myRange.EntireColumn.AutoFit();
                myRange = (Range)CalismaSayfasi0.Cells[i + 2, 4]; myRange.EntireColumn.AutoFit();
                myRange = (Range)CalismaSayfasi0.Cells[i + 2, 5]; myRange.EntireColumn.AutoFit();
                myRange = (Range)CalismaSayfasi0.Cells[i + 2, 6]; myRange.EntireColumn.AutoFit();
                myRange = (Range)CalismaSayfasi0.Cells[i + 2, 7]; myRange.EntireColumn.AutoFit();
                myRange = (Range)CalismaSayfasi0.Cells[i + 2, 8]; myRange.EntireColumn.AutoFit();
                myRange = (Range)CalismaSayfasi0.Cells[i + 2, 9]; myRange.EntireColumn.AutoFit();

                masaSatisDetayBindingSource.MoveNext();
            }

            ExcelUygulama0.Visible = true;
        }

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnuygula_Click(object sender, EventArgs e)
		{
            Double oran, fiyat, yeni_fiyat ,eskifiyat;

            oran = Convert.ToDouble(textBox1.Text);
                      
            oran = -1 * oran;
                        
            fiyat = Convert.ToDouble(lblGenelToplam.Text);
            eskifiyat = fiyat;

            //if (radioButton1.Checked)
            //{
            //    yeni_fiyat = fiyat + fiyat * (oran / 100);
            //    eskifiyat = yeni_fiyat - fiyat;

            //    lblindirim.Text = eskifiyat.ToString();
            //    lblGenelToplam.Text = yeni_fiyat.ToString();
            //    ttxtindirimturu.Text = "yuzde";
            //    txtindirim.Text=eskifiyat.ToString().Trim();
            //}
            //else {
            //    yeni_fiyat = fiyat + oran;
            //    eskifiyat = yeni_fiyat - fiyat;

            //    lblindirim.Text = eskifiyat.ToString();
            //    lblGenelToplam.Text = yeni_fiyat.ToString();
            //    ttxtindirimturu.Text = "birim";
            //    txtindirim.Text = eskifiyat.ToString().Trim();
            //}

			if (comboBox1.Text == "YUZDE")
			{
				yeni_fiyat = fiyat + fiyat * (oran / 100);
				eskifiyat = yeni_fiyat - fiyat;

				lblindirim.Text = eskifiyat.ToString();
				lblGenelToplam.Text = yeni_fiyat.ToString();
				//ttxtindirimturu.Text = "yuzde";
				//txtindirim.Text = eskifiyat.ToString().Trim();
			}
			else
			{
				yeni_fiyat = fiyat + oran;
				eskifiyat = yeni_fiyat - fiyat;

				lblindirim.Text = eskifiyat.ToString();
				lblGenelToplam.Text = yeni_fiyat.ToString();
				//ttxtindirimturu.Text = "birim";
				//txtindirim.Text = eskifiyat.ToString().Trim();
			}

			masaSatisDetayBindingSource.EndEdit();
            masaSatisDetayTableAdapter.Update(cafeOtomasyonuDataSet.MasaSatisDetay);
            cafeOtomasyonuDataSet.AcceptChanges();
        }

		private void btnsecilensatirexel_Click(object sender, EventArgs e)
		{


            Excel.Application ExcelUygulama0;             // excel uygulaması tanımla
            Excel.Workbook CalismaKitabi0;                // çalışma Kitabı tanımla
            Excel.Worksheet CalismaSayfasi0;              // çalışma Sayfası tanımla               
            ExcelUygulama0 = new Excel.Application();     // yeni bir excel uygulaması yarat
            CalismaKitabi0 = ExcelUygulama0.Workbooks.Open(file_path);                  // dosyayı aç
            CalismaSayfasi0 = (Excel.Worksheet)CalismaKitabi0.Worksheets.get_Item(1);   // 1. sayfayı aç


            CalismaSayfasi0.Cells[1, 1] = "ms_detayid";                                // dataya yaz (satır, sutun)
            CalismaSayfasi0.Cells[1, 2] = "ms_ustid";                                // dataya yaz
            CalismaSayfasi0.Cells[1, 3] = "uid";
            CalismaSayfasi0.Cells[1, 4] = "barkod";                                // dataya yaz
            CalismaSayfasi0.Cells[1, 5] = "uadi";
            CalismaSayfasi0.Cells[1, 6] = "miktar";
            CalismaSayfasi0.Cells[1, 7] = "sfiyat";                                // dataya yaz
            CalismaSayfasi0.Cells[1, 8] = "kdv";  // dataya yaz
            CalismaSayfasi0.Cells[1, 9] = "tutar";


            int kayitsayisi;

            DataRowView AktifKayit;// Aktif Kayıt 

            kayitsayisi = masaSatisDetayBindingSource.Count;
            masaSatisDetayBindingSource.MoveFirst();

            Range myRange;

            

            for (int i = 0; i < kayitsayisi; i++)

            {
                AktifKayit = (DataRowView)masaSatisDetayBindingSource.Current;

                CalismaSayfasi0.Cells[i + 2, 1] = AktifKayit["ms_detayid"].ToString();                        // dataya yaz (satır, sutun)
                CalismaSayfasi0.Cells[i + 2, 2] = AktifKayit["ms_ustid"].ToString();                           // dataya yaz
                CalismaSayfasi0.Cells[i + 2, 3] = AktifKayit["uid"].ToString();
                CalismaSayfasi0.Cells[i + 2, 4] = AktifKayit["barkod"].ToString();                           // dataya yaz
                CalismaSayfasi0.Cells[i + 2, 5] = AktifKayit["uadi"].ToString();
                CalismaSayfasi0.Cells[i + 2, 6] = AktifKayit["miktar"].ToString();                           // dataya yaz
                CalismaSayfasi0.Cells[i + 2, 7] = AktifKayit["sfiyat"].ToString();
                CalismaSayfasi0.Cells[i + 2, 8] = AktifKayit["kdv"].ToString();                           // dataya yaz
                CalismaSayfasi0.Cells[i + 2, 9] = AktifKayit["tutar"].ToString();

                myRange = (Range)CalismaSayfasi0.Cells[i + 2, 1]; myRange.EntireColumn.AutoFit();
                myRange = (Range)CalismaSayfasi0.Cells[i + 2, 2]; myRange.EntireColumn.AutoFit();
                myRange = (Range)CalismaSayfasi0.Cells[i + 2, 3]; myRange.EntireColumn.AutoFit();
                myRange = (Range)CalismaSayfasi0.Cells[i + 2, 4]; myRange.EntireColumn.AutoFit();
                myRange = (Range)CalismaSayfasi0.Cells[i + 2, 5]; myRange.EntireColumn.AutoFit();
                myRange = (Range)CalismaSayfasi0.Cells[i + 2, 6]; myRange.EntireColumn.AutoFit();
                myRange = (Range)CalismaSayfasi0.Cells[i + 2, 7]; myRange.EntireColumn.AutoFit();
                myRange = (Range)CalismaSayfasi0.Cells[i + 2, 8]; myRange.EntireColumn.AutoFit();
                myRange = (Range)CalismaSayfasi0.Cells[i + 2, 9]; myRange.EntireColumn.AutoFit();

                masaSatisDetayBindingSource.MoveNext();
            }

            ExcelUygulama0.Visible = true;

        }

		private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult silme;
            DataRowView UstKayit;


            if (masaSatisUstBindingSource.Count == 0) return;

            silme = MessageBox.Show("Silmek İstediğinizden Eminmisiniz?", "", MessageBoxButtons.YesNo);
            if (silme == DialogResult.Yes)
            {
                UstKayit = (DataRowView)masaSatisUstBindingSource.Current;
                genelid = Convert.ToInt32(UstKayit["ms_ustid"].ToString());
                masaSatisUstTableAdapter.DeleteQuery(genelid);
                masaSatisDetayTableAdapter.DeleteQuery(genelid);

                masaSatisUstTableAdapter.Fill(cafeOtomasyonuDataSet.MasaSatisUst, genelid);//, genelid
                masaSatisDetayTableAdapter.Fill(cafeOtomasyonuDataSet.MasaSatisDetay, genelid);//, genelid
                //ToplamTutarBul();
                MasaEkle();
               
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int kayitsayisi;
            if (masaSatisUstBindingSource.Count == 0) return;

            DataRowView UstKayit, DetayKayit;
            UstKayit = (DataRowView)masaSatisUstBindingSource.Current;
            masaSatisUstBindingSource.EndEdit();
            UstKayit["durumu"] = 1;

            masaSatisUstTableAdapter.Update(cafeOtomasyonuDataSet.MasaSatisUst);
            cafeOtomasyonuDataSet.MasaSatisUst.AcceptChanges();

            UstKayit = (DataRowView)masaSatisUstBindingSource.Current;

            masaSatisDetayBindingSource.EndEdit();

            kayitsayisi = masaSatisDetayBindingSource.Count;
            masaSatisDetayBindingSource.MoveFirst();// ilk kayda Konumlan
            ustid = Convert.ToInt32(UstKayit["ms_ustid"].ToString());
            for (int i = 1; i <= kayitsayisi; i++)
            {
                DetayKayit = (DataRowView)masaSatisDetayBindingSource.Current;
                DetayKayit["ms_ustid"] = ustid;
                masaSatisDetayBindingSource.MoveNext();
            }

            masaSatisDetayTableAdapter.Update(cafeOtomasyonuDataSet.MasaSatisDetay);
            cafeOtomasyonuDataSet.AcceptChanges();
            MasaEkle();

            Kayitlar(ustid);
            GenelToplam_Bul();
            ButtonKontrol(true);
        }

        private void satırSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (masaSatisDetayBindingSource.Count == 0) return;

            masaSatisDetayBindingSource.RemoveCurrent();
            GenelToplam_Bul();
        }

        private void TutarBul()
        {
            double miktar = 0, fiyat = 0, tutar = 0;
            if (txtFiyat.Text.Trim() == "")
                fiyat = 0;
            else
                fiyat = Convert.ToDouble(txtFiyat.Text);

            if (txtMiktar.Text.Trim() == "")
                miktar = 0;
            else
                miktar = Convert.ToDouble(txtMiktar.Text);

            tutar = miktar * fiyat;
            txtTutar.Text = tutar.ToString();
            GenelToplam_Bul();


        }
        private void GenelToplam_Bul()
        {
            Double AraToplam = 0, tutar = 0, kdv = 0, ToplamKdv = 0, GenelToplam = 0;
            int kayitsayisi, sirasi;
            DataRowView DetayKayit;
            kayitsayisi = masaSatisDetayBindingSource.Count;
            sirasi = masaSatisDetayBindingSource.Position;
            masaSatisDetayBindingSource.MoveFirst();
            for (int i = 1; i <= kayitsayisi; i++)
            {
                DetayKayit = (DataRowView)masaSatisDetayBindingSource.Current;
                if (DetayKayit["tutar"].ToString().Trim() == "")
                    tutar = 0;
                else
                    tutar = Convert.ToDouble(DetayKayit["tutar"].ToString());
                if (DetayKayit["kdv"].ToString().Trim() == "")
                    kdv = 0;
                else
                    kdv = Convert.ToDouble(DetayKayit["kdv"].ToString());
                AraToplam = AraToplam + tutar;
                kdv = tutar * kdv / 100;
                ToplamKdv = ToplamKdv + kdv;
                masaSatisDetayBindingSource.MoveNext();

            }
            GenelToplam = AraToplam + ToplamKdv;
            lblAraToplam.Text = AraToplam.ToString();
            lblToplamKdv.Text = ToplamKdv.ToString();
            lblGenelToplam.Text = GenelToplam.ToString();
            masaSatisDetayBindingSource.Position = sirasi;
        }
    }
}
