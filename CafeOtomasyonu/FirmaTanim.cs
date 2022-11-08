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
    public partial class FirmaTanim : Form
    {
        public FirmaTanim()
        {
            InitializeComponent();
        }

        private void FirmaTanim_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'cafeOtomasyonuDataSet.FirmaTanim' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.firmaTanimTableAdapter.Fill(this.cafeOtomasyonuDataSet.FirmaTanim);
            Buton_Kontrol(false);
        }
        private void Buton_Kontrol(bool durum)
        {
            TxtUnvan.Enabled = durum;
            txtTelno.Enabled = durum;
            TxtAdres.Enabled = durum;
            BtnYeni1.Enabled = !durum;
            BtnDuzelt1.Enabled = !durum;
            BtnVazgec1.Enabled = !durum;
            BtnSil1.Enabled = durum;
            BtnKaydet1.Enabled = durum;
        }
        private void BtnYeni_Click(object sender, EventArgs e)
        {
            firmaTanimBindingSource.AddNew();
            Buton_Kontrol(true);
        }

        private void BtnDuzelt_Click(object sender, EventArgs e)
        {
            Buton_Kontrol(true);
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            firmaTanimBindingSource.CancelEdit();
            Buton_Kontrol(false);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult sil;
            sil = MessageBox.Show("Kayıt silinsin mi ?", "silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sil == DialogResult.Yes)
            {
                firmaTanimBindingSource.RemoveCurrent();
                firmaTanimTableAdapter.Update(cafeOtomasyonuDataSet.FirmaTanim);
                cafeOtomasyonuDataSet.AcceptChanges();
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            firmaTanimBindingSource.EndEdit();
            firmaTanimTableAdapter.Update(cafeOtomasyonuDataSet.FirmaTanim);
            cafeOtomasyonuDataSet.AcceptChanges();
            Buton_Kontrol(false);
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnIleri_Click(object sender, EventArgs e)
        {
            firmaTanimBindingSource.MoveNext();
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            firmaTanimBindingSource.MovePrevious();
        }

        private void BtnIlkKayit_Click(object sender, EventArgs e)
        {
            firmaTanimBindingSource.MoveFirst();
        }

        private void BtnSonKayit_Click(object sender, EventArgs e)
        {
            firmaTanimBindingSource.MoveLast();
        }
    }
}
