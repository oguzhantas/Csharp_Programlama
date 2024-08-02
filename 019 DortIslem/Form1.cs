using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _019_DortIslem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2,  toplam;
            sayi1 = double.Parse(txtSayi1.Text);
            sayi2 = double.Parse(txtSayi2.Text);


            toplam = sayi1 + sayi2;
            MessageBox.Show(toplam.ToString());
        }

        private void btnCikarma_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, cikarma;
            sayi1 = double.Parse(txtSayi1.Text);
            sayi2 = double.Parse(txtSayi2.Text);

            cikarma = sayi1 - sayi2;
            MessageBox.Show(cikarma.ToString());
        }

        private void btnCarpma_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, carpma;
            sayi1 = double.Parse(txtSayi1.Text);
            sayi2 = double.Parse(txtSayi2.Text);

            carpma = sayi1 * sayi2;
            MessageBox.Show(carpma.ToString());
        }

        private void btnBolme_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, bolum;
            sayi1 = double.Parse(txtSayi1.Text);
            sayi2 = double.Parse(txtSayi2.Text);
            sayi2 = double.Parse(txtSayi2.Text);

            bolum = sayi1 /sayi2;
            MessageBox.Show(bolum.ToString());
        }
    }
}
