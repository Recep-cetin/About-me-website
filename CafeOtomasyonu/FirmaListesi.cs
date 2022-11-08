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
    public partial class FirmaListesi : Form
    {
        public FirmaListesi()
        {
            InitializeComponent();
        }

        private void FirmaListesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'cafeOtomasyonuDataSet.FirmaTanim' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.firmaTanimTableAdapter.Fill(this.cafeOtomasyonuDataSet.FirmaTanim);

        }

        private void TxtArama_TextChanged(object sender, EventArgs e)
        {
            firmaTanimTableAdapter.Arama(cafeOtomasyonuDataSet.FirmaTanim, '%' + TxtArama.Text + '%');
        }
    }
}
