using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _50_Metodlar_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static double  kdvHesapla(double k, double f){


            double sonuc = f + f * k / 100;
            return sonuc;
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double fiyat, kdvoran, tutar;

            fiyat = double.Parse(txtFiyat.Text);
            kdvoran= double.Parse(txtKDVOran.Text);

            labSonuc.Text = kdvHesapla(kdvoran, fiyat).ToString();
        }
    }
}
