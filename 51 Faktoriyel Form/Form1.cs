using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _51_Faktoriyel_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        static int faktoriyel(int n)
        {
            int fakt =1, sonuc = 1;

            if (n == 0) { sonuc=1; }
            else if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    fakt *= i;
                }
                sonuc= fakt;
            }
            return sonuc;
        } 
        
      

        static int permutasyon(int n, int r)
        {

            int sonuc = faktoriyel(n) / faktoriyel(n - r);
            return sonuc;
        }

        static int kombinasyon(int n, int r)
        {

            int sonuc = faktoriyel(n) / (faktoriyel(r)*faktoriyel(n - r));
            return sonuc;
        }



        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            int r=  int.Parse(txtR.Text);

            if (rbFaktoriyel.Checked)
            {
                txtR.Visible = false;
                labR.Visible = false;
                MessageBox.Show("Faktoriyel:" + faktoriyel(n).ToString());
            } 
            
            else if (rbKombinasyon.Checked)
            {
                txtR.Visible = true;
                labR.Visible = true;
                int kombinasyonSonuc = kombinasyon(n, r);
                MessageBox.Show("Kombinasyon:" + kombinasyonSonuc.ToString());
            } else if (rbPermutasyon.Checked)
            {
                txtR.Visible = true;
                labR.Visible = true;
                int permutasyonSonuc = permutasyon(n, r);
                MessageBox.Show("Permütasyon sonucu:" + permutasyonSonuc.ToString());

            }






        }

        private void rbFaktoriyel_CheckedChanged(object sender, EventArgs e)
        {
            txtR.Visible = false;
            labR.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtR.Visible = false;
            labR.Visible = false;
        }

        private void rbKombinasyon_CheckedChanged(object sender, EventArgs e)
        {
            txtR.Visible = true;
            labR.Visible = true;
        }

        private void rbPermutasyon_CheckedChanged(object sender, EventArgs e)
        {
            txtR.Visible = true;
            labR.Visible = true;
        }
    }
}
