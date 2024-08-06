using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _024_Ternary_Operator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int  not1, not2;
            double ortalama;

            not1 = int.Parse(txtNot1.Text);
            not2 = int.Parse(txtNot2.Text);

            ortalama = (double)(not1 + not2) / 2;

            MessageBox.Show(ortalama.ToString());
            string sonuc = "";


           /* if (ortalama >= 50)
                sonuc = "Geçti";
            else
                sonuc = "Kaldı";*/

             sonuc = (ortalama >= 50) ? "Geçti" : "Kaldı";sonuc = (ortalama >= 50) ? "Geçti" : "Kaldı";
            MessageBox.Show("Durum:" + sonuc);
        }
    }
}
