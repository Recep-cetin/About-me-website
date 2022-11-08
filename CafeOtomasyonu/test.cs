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
	public partial class test : Form
	{
		public test()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		 masaSatisDetayTableAdapter.Arama(cafeOtomasyonuDataSet.MasaSatisDetay, '%' + TxtArama.Text + '%');
		}
	}
}
