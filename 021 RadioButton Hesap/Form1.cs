using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _021_RadioButton_Hesap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double fiyat, kdvmiktar, kdvlifiyat=0;

            fiyat = double.Parse(txtFiyat.Text);
            if (rbYuzde1.Checked)
            {
                kdvlifiyat = fiyat + fiyat * 1 / 100;

            }else if (rbYuzde10.Checked)
            {
                kdvlifiyat = fiyat + fiyat * 10 / 100;
            }
            else if (rbYuzde20.Checked)
            {
                kdvlifiyat = fiyat + fiyat * 20 / 100;
            }
            txtKDV.Text = kdvlifiyat.ToString();

        }
    }
}
