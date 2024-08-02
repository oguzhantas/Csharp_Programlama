using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _020_Saat_Ucreti__Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double saatucret, saatmiktar, sonuc;

            saatucret = double.Parse( txtSaatUcret.Text);
            saatmiktar = double.Parse(txtSaatMiktar.Text);
            sonuc = saatucret * saatmiktar;
            labSonuc.Text = sonuc.ToString();
        }
    }
}
