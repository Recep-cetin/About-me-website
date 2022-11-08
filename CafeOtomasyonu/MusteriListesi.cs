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
    public partial class MusteriListesi : Form
    {
        public MusteriListesi()
        {
            InitializeComponent();
        }
        public static string GelenForm;

        private void MusteriListesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'cafeOtomasyonuDataSet.MusteriTanim' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.musteri_TanimTableAdapter.Fill(this.cafeOtomasyonuDataSet.Musteri_Tanim);

        }

        private void TxtArama_TextChanged(object sender, EventArgs e)
        {
            musteri_TanimTableAdapter.Arama(cafeOtomasyonuDataSet.Musteri_Tanim, '%' + TxtArama.Text + '%');
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (GelenForm == "Fatura Alış")
            {
                DataRowView AktifKayit;
                AktifKayit = (DataRowView)musteriTanimBindingSource.Current;
                // MessageBox.Show(AktifKayit["ad"].ToString());
                FaturaSatis.ad = AktifKayit["ad"].ToString();
                FaturaSatis.soyad = AktifKayit["soyad"].ToString();
                FaturaSatis.mid = AktifKayit["mid"].ToString();
            }
            Close();
        }
    }
}
