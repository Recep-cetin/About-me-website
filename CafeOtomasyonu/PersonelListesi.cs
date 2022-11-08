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
    public partial class PersonelListesi : Form
    {
        public PersonelListesi()
        {
            InitializeComponent();
        }

        private void PersonelListesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'cafeOtomasyonuDataSet.PersonelTanim' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelTanimTableAdapter.Fill(this.cafeOtomasyonuDataSet.PersonelTanim);

        }

        private void TxtArama_TextChanged(object sender, EventArgs e)
        {
            personelTanimTableAdapter.Arama(cafeOtomasyonuDataSet.PersonelTanim, '%' + TxtArama.Text + '%');
        }
    }
}
