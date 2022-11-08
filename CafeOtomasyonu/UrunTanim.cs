using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;       // excel k

using Microsoft.Office.Interop.Excel;

namespace CafeOtomasyonu
{
    public partial class UrunTanim : Form
    {
        public UrunTanim()
        {
            InitializeComponent();
        }
        public string file_path = @"C:\Users\MONSTER\Desktop\CafeOtomasyonu\test.xlsx";

        private void UrunTanim_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'cafeOtomasyonuDataSet.Urun_Tanim' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.urun_TanimTableAdapter.Fill(this.cafeOtomasyonuDataSet.Urun_Tanim);
            Buton_Kontrol(false);
        }
        private void Buton_Kontrol(bool durum)
        {
            TxtBarkod.Enabled = durum;
            TxtAd.Enabled = durum;
            TxtAfiyat.Enabled = durum;
            TxtSfiyat.Enabled = durum;
            BtnYeni.Enabled = !durum;
            BtnDuzelt.Enabled = !durum;
            BtnSil.Enabled = !durum;
            BtnVazgec.Enabled = durum;
            BtnKaydet.Enabled = durum;
        }
        private void BtnYeni_Click(object sender, EventArgs e)
        {
            urunTanimBindingSource.AddNew();
            Buton_Kontrol(true);
        }

        private void BtnDuzelt_Click(object sender, EventArgs e)
        {
            Buton_Kontrol(true);
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            urunTanimBindingSource.CancelEdit();
            Buton_Kontrol(false);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult sil;
            sil = MessageBox.Show("Kayıt silinsin mi ?", "silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sil == DialogResult.Yes)
            {
                urunTanimBindingSource.RemoveCurrent();
                urun_TanimTableAdapter.Update(cafeOtomasyonuDataSet.Urun_Tanim);
                cafeOtomasyonuDataSet.AcceptChanges();
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            urunTanimBindingSource.EndEdit();
            urun_TanimTableAdapter.Update(cafeOtomasyonuDataSet.Urun_Tanim);
            cafeOtomasyonuDataSet.AcceptChanges();
            Buton_Kontrol(false);
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtArama_TextChanged(object sender, EventArgs e)
        {
            if (RbnAd.Checked)
                urun_TanimTableAdapter.AdaGore(cafeOtomasyonuDataSet.Urun_Tanim, '%' + TxtArama.Text + '%');
            else if (RbnBarkod.Checked)
                urun_TanimTableAdapter.BarkodaGore(cafeOtomasyonuDataSet.Urun_Tanim, '%' + TxtArama.Text + '%');
            else
                urun_TanimTableAdapter.Arama(cafeOtomasyonuDataSet.Urun_Tanim, '%' + TxtArama.Text + '%');
        }

        private void BtnIleri_Click(object sender, EventArgs e)
        {
            urunTanimBindingSource.MoveNext();
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            urunTanimBindingSource.MovePrevious();
        }

        private void BtnIlkKayit_Click(object sender, EventArgs e)
        {
            urunTanimBindingSource.MoveFirst();
        }

        private void BtnSonKayit_Click(object sender, EventArgs e)
        {
            urunTanimBindingSource.MoveLast();
        }

		private void button1_Click(object sender, EventArgs e)
		{
            Excel.Application ExcelUygulama0;             // excel uygulaması tanımla
            Excel.Workbook CalismaKitabi0;                // çalışma Kitabı tanımla
            Excel.Worksheet CalismaSayfasi0;              // çalışma Sayfası tanımla               
            ExcelUygulama0 = new Excel.Application();     // yeni bir excel uygulaması yarat
            CalismaKitabi0 = ExcelUygulama0.Workbooks.Open(file_path);                  // dosyayı aç
            CalismaSayfasi0 = (Excel.Worksheet)CalismaKitabi0.Worksheets.get_Item(1);   // 1. sayfayı aç


            CalismaSayfasi0.Cells[1, 1] = "Barkodu";                                // dataya yaz (satır, sutun)
            CalismaSayfasi0.Cells[1, 2] = "Ürün Adı";                                // dataya yaz
            CalismaSayfasi0.Cells[1, 3] = "Alış Fiyat";
            CalismaSayfasi0.Cells[1, 4] = "Satis Fiyat";                                // dataya yaz
            CalismaSayfasi0.Cells[1, 5] = "kdv";      // dataya yaz

            int kayitsayisi;

            DataRowView AktifKayit;// Aktif Kayıt 

            kayitsayisi = urunTanimBindingSource.Count;
            urunTanimBindingSource.MoveFirst();

            Range myRange;

            for (int i = 0; i < kayitsayisi; i++)
            {
                AktifKayit = (DataRowView)urunTanimBindingSource.Current;

                CalismaSayfasi0.Cells[i + 2, 1] = AktifKayit["barkodu"].ToString();                        // dataya yaz (satır, sutun)
                CalismaSayfasi0.Cells[i + 2, 2] = AktifKayit["uadi"].ToString();                           // dataya yaz
                CalismaSayfasi0.Cells[i + 2, 3] = AktifKayit["afiyat"].ToString();
                CalismaSayfasi0.Cells[i + 2, 4] = AktifKayit["sfiyat"].ToString();                           // dataya yaz
                CalismaSayfasi0.Cells[i + 2, 5] = AktifKayit["kdv"].ToString();

                myRange = (Range)CalismaSayfasi0.Cells[i + 2, 1]; myRange.EntireColumn.AutoFit();
                myRange = (Range)CalismaSayfasi0.Cells[i + 2, 2]; myRange.EntireColumn.AutoFit();
                myRange = (Range)CalismaSayfasi0.Cells[i + 2, 3]; myRange.EntireColumn.AutoFit();
                myRange = (Range)CalismaSayfasi0.Cells[i + 2, 4]; myRange.EntireColumn.AutoFit();
                myRange = (Range)CalismaSayfasi0.Cells[i + 2, 5]; myRange.EntireColumn.AutoFit();


                urunTanimBindingSource.MoveNext();
            }

            ExcelUygulama0.Visible = true;                 // excel' i görünür yap
        }

		private void button1_Click_1(object sender, EventArgs e)
        {
            Excel.Application ExcelUygulama0;             // excel uygulaması tanımla
            Excel.Workbook CalismaKitabi0;                // çalışma Kitabı tanımla
            Excel.Worksheet CalismaSayfasi0;              // çalışma Sayfası tanımla               
            ExcelUygulama0 = new Excel.Application();     // yeni bir excel uygulaması yarat
            CalismaKitabi0 = ExcelUygulama0.Workbooks.Open(file_path);                  // dosyayı aç
            CalismaSayfasi0 = (Excel.Worksheet)CalismaKitabi0.Worksheets.get_Item(1);   // 1. sayfayı aç


            CalismaSayfasi0.Cells[1, 1] = "Barkodu";                                // dataya yaz (satır, sutun)
            CalismaSayfasi0.Cells[1, 2] = "Ürün Adı";                                // dataya yaz
            CalismaSayfasi0.Cells[1, 3] = "Alış Fiyat";
            CalismaSayfasi0.Cells[1, 4] = "Satis Fiyat";                                // dataya yaz
            CalismaSayfasi0.Cells[1, 5] = "kdv";      // dataya yaz

            int kayitsayisi;

            DataRowView AktifKayit;// Aktif Kayıt 

            kayitsayisi = urunTanimBindingSource.Count;
            urunTanimBindingSource.MoveFirst();

            Range myRange;



                AktifKayit = (DataRowView)urunTanimBindingSource.Current;

                CalismaSayfasi0.Cells[2, 1] = AktifKayit["barkodu"].ToString();                        // dataya yaz (satır, sutun)
                CalismaSayfasi0.Cells[ 2, 2] = AktifKayit["uadi"].ToString();                           // dataya yaz
                CalismaSayfasi0.Cells[ 2, 3] = AktifKayit["afiyat"].ToString();
                CalismaSayfasi0.Cells[ 2, 4] = AktifKayit["sfiyat"].ToString();                           // dataya yaz
                CalismaSayfasi0.Cells[ 2, 5] = AktifKayit["kdv"].ToString();

                myRange = (Range)CalismaSayfasi0.Cells[ 2, 1]; myRange.EntireColumn.AutoFit();
                myRange = (Range)CalismaSayfasi0.Cells[ 2, 2]; myRange.EntireColumn.AutoFit();
                myRange = (Range)CalismaSayfasi0.Cells[ 2, 3]; myRange.EntireColumn.AutoFit();
                myRange = (Range)CalismaSayfasi0.Cells[ 2, 4]; myRange.EntireColumn.AutoFit();
                myRange = (Range)CalismaSayfasi0.Cells[ 2, 5]; myRange.EntireColumn.AutoFit();


                urunTanimBindingSource.MoveNext();
            

            ExcelUygulama0.Visible = true;

        }
        public  static string secilensatir;
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
		{
            
            secilensatir = dataGridView1.SelectedRows.ToString();  
		}
	}
}
