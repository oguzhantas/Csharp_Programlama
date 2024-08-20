using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _041_Faktoriyel_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFaktoriyel_Click(object sender, EventArgs e)
        {
           /* 5!= 5.4.3.2.1 = 120
            0 != 1;
            2!= 2.1 =2
            3!=3.2.1 =6*/
            int fakt = 1;
            int sayi = int.Parse(txtSayi.Text);
            if (sayi > 0)
            {
                for (int i = 1; i <= sayi; i++)
                {
                    fakt = fakt * i;
                    // fakt= 1*1
                    // fakt=1*2
                    // fakt=2*3
                    // fakt=6*4

                }
            }
            else if (sayi == 0)
                fakt = 1;
           
           txtSonuc.Text= fakt.ToString();
        }
    }
}
