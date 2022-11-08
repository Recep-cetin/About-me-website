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
    public partial class UrunListesi : Form
    {
        public UrunListesi()
        {
            InitializeComponent();
        }
        public static string GelenForm;
        private void UrunListesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'cafeOtomasyonuDataSet.Urun_Tanim' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.urun_TanimTableAdapter.Fill(this.cafeOtomasyonuDataSet.Urun_Tanim);

        }

        private void TxtArama_TextChanged(object sender, EventArgs e)
        {
            urun_TanimTableAdapter.Arama(cafeOtomasyonuDataSet.Urun_Tanim, '%' + TxtArama.Text + '%');
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (GelenForm == "Fatura Alış")
            {
                DataRowView AktifKayit;
                AktifKayit = (DataRowView)urunTanimBindingSource.Current;
                // MessageBox.Show(AktifKayit["ad"].ToString());
                FaturaSatis.uad = AktifKayit["uadi"].ToString();
                FaturaSatis.barkod = AktifKayit["barkodu"].ToString();
                FaturaSatis.uid = AktifKayit["uid"].ToString();
                if (AktifKayit["afiyat"].ToString().Trim() == "")
                    FaturaSatis.fiyat = "0";
                else
                    FaturaSatis.fiyat = AktifKayit["afiyat"].ToString();
            }
            else if (GelenForm == "StokTakip")
			{
                DataRowView AktifKayit;
                AktifKayit = (DataRowView)urunTanimBindingSource.Current;
                StokTakip.uid = AktifKayit["uid"].ToString();
                StokTakip.uid = AktifKayit["uid"].ToString();
                StokTakip.uid = AktifKayit["uid"].ToString();
                StokTakip.uad = AktifKayit["uadi"].ToString();
                
            }
            Close();
        }

		private void button1_Click(object sender, EventArgs e)
		{
            Double oran, fiyat, yeni_fiyat;
            int kayitsayisi;
            oran = Convert.ToDouble(textBox1.Text);
            if (comboBox1.Text == "İndirim")
                oran = -1 * oran;

            DataRowView AktifKayit;// Aktif Kayıt 

            kayitsayisi = urunTanimBindingSource.Count;
            urunTanimBindingSource.MoveFirst();


            for (int i = 0; i < kayitsayisi; i++)
            {
                AktifKayit = (DataRowView)urunTanimBindingSource.Current;

                if (AktifKayit["sfiyat"].ToString().Trim() == "")
                    fiyat = 0;
                else
                    fiyat = Convert.ToDouble(AktifKayit["sfiyat"].ToString());

                if (radioButton1.Checked)
                    yeni_fiyat = fiyat + fiyat * (oran / 100);
                else
                    yeni_fiyat = fiyat + oran;

                AktifKayit["sfiyat"] = yeni_fiyat.ToString();

                urunTanimBindingSource.EndEdit();
                urun_TanimTableAdapter.Update(cafeOtomasyonuDataSet.Urun_Tanim);
                cafeOtomasyonuDataSet.AcceptChanges();

                urunTanimBindingSource.MoveNext();
            }
        }
	}
}
