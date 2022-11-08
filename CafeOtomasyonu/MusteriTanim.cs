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
    public partial class MusteriTanim : Form
    {
        public MusteriTanim()
        {
            InitializeComponent();
        }
        public string file_path = @"C:\Users\MONSTER\Desktop\CafeOtomasyonu\test.xlsx";

        private void MusteriTanim_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'cafeOtomasyonuDataSet.MusteriTanim' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.musteri_TanimTableAdapter.Fill(this.cafeOtomasyonuDataSet.Musteri_Tanim);
            Buton_Kontrol(false);
        }
        private void Buton_Kontrol(bool durum)
        {
            TxtMadi.Enabled = durum;
            TxtMsoyadi.Enabled = durum;
            TxtMtelefon.Enabled = durum;
            TxtAdres.Enabled = durum;
            BtnYeni.Enabled = !durum;
            BtnDuzelt.Enabled = !durum;
            BtnSil.Enabled = !durum;
            BtnVazgec.Enabled = durum;
            BtnKaydet.Enabled = durum;
        }
        private void BtnYeni_Click(object sender, EventArgs e)
        {
            musteriTanimBindingSource.AddNew();
            Buton_Kontrol(true);
        }

        private void BtnDuzelt_Click(object sender, EventArgs e)
        {
            Buton_Kontrol(true);
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            musteriTanimBindingSource.CancelEdit();
            Buton_Kontrol(false);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult sil;
            sil = MessageBox.Show("Kayıt silinsin mi ?", "silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sil == DialogResult.Yes)
            {
                musteriTanimBindingSource.RemoveCurrent();
                musteri_TanimTableAdapter.Update(cafeOtomasyonuDataSet.Musteri_Tanim);
                cafeOtomasyonuDataSet.AcceptChanges();
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            musteriTanimBindingSource.EndEdit();
            musteri_TanimTableAdapter.Update(cafeOtomasyonuDataSet.Musteri_Tanim);
            cafeOtomasyonuDataSet.AcceptChanges();
            Buton_Kontrol(false);
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtArama_TextChanged(object sender, EventArgs e)
        {
            if (RbnAdaGore.Checked)
                musteri_TanimTableAdapter.AdaGore(cafeOtomasyonuDataSet.Musteri_Tanim, '%' + TxtArama.Text + '%');
            else if (RbnSoyadaGore.Checked)
                musteri_TanimTableAdapter.SoyadaGore(cafeOtomasyonuDataSet.Musteri_Tanim, '%' + TxtArama.Text + '%');
            else
                musteri_TanimTableAdapter.Arama(cafeOtomasyonuDataSet.Musteri_Tanim, '%' + TxtArama.Text + '%');
        }

        private void BtnIleri_Click(object sender, EventArgs e)
        {
            musteriTanimBindingSource.MoveNext();
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            musteriTanimBindingSource.MovePrevious();
        }

        private void BtnIlkKayit_Click(object sender, EventArgs e)
        {
            musteriTanimBindingSource.MoveFirst();
        }

        private void BtnSonKayit_Click(object sender, EventArgs e)
        {
            musteriTanimBindingSource.MoveLast();
        }

		private void btnexel_Click(object sender, EventArgs e)
		{
            Excel.Application ExcelUygulama0;             // excel uygulaması tanımla
            Excel.Workbook CalismaKitabi0;                // çalışma Kitabı tanımla
            Excel.Worksheet CalismaSayfasi0;              // çalışma Sayfası tanımla               
            ExcelUygulama0 = new Excel.Application();     // yeni bir excel uygulaması yarat
            CalismaKitabi0 = ExcelUygulama0.Workbooks.Open(file_path);                  // dosyayı aç
            CalismaSayfasi0 = (Excel.Worksheet)CalismaKitabi0.Worksheets.get_Item(1);   // 1. sayfayı aç


            CalismaSayfasi0.Cells[1, 1] = "id";                                // dataya yaz (satır, sutun)
            CalismaSayfasi0.Cells[1, 2] = "ADI";                                // dataya yaz
            CalismaSayfasi0.Cells[1, 3] = "SOYADI";
            CalismaSayfasi0.Cells[1, 4] = "ADRES";                                // dataya yaz
            CalismaSayfasi0.Cells[1, 5] = "TELNO";

            int kayitsayisi;

            DataRowView AktifKayit;// Aktif Kayıt 

            kayitsayisi = musteriTanimBindingSource.Count;
            musteriTanimBindingSource.MoveFirst();

            Range myRange;

            for (int i = 0; i < kayitsayisi; i++)
            {
                AktifKayit = (DataRowView)musteriTanimBindingSource.Current;

                CalismaSayfasi0.Cells[i + 2, 1] = AktifKayit["mid"].ToString();                        // dataya yaz (satır, sutun)
                CalismaSayfasi0.Cells[i + 2, 2] = AktifKayit["ad"].ToString();                           // dataya yaz
                CalismaSayfasi0.Cells[i + 2, 3] = AktifKayit["soyad"].ToString();
                CalismaSayfasi0.Cells[i + 2, 4] = AktifKayit["adres"].ToString();                           // dataya yaz
                CalismaSayfasi0.Cells[i + 2, 5] = AktifKayit["tel"].ToString();


                myRange = (Range)CalismaSayfasi0.Cells[i + 2, 1]; myRange.EntireColumn.AutoFit();
                myRange = (Range)CalismaSayfasi0.Cells[i + 2, 2]; myRange.EntireColumn.AutoFit();
                myRange = (Range)CalismaSayfasi0.Cells[i + 2, 3]; myRange.EntireColumn.AutoFit();
                myRange = (Range)CalismaSayfasi0.Cells[i + 2, 4]; myRange.EntireColumn.AutoFit();
                myRange = (Range)CalismaSayfasi0.Cells[i + 2, 5]; myRange.EntireColumn.AutoFit();


                musteriTanimBindingSource.MoveNext();
            }

            ExcelUygulama0.Visible = true;
        }
	}
}
