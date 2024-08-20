using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _037_Toplam_ve_Faktoriyel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToplam_Click(object sender, EventArgs e)
        {
            double toplam=0;
            int elemansayisi = lbSayilar.Items.Count;

            for (int i = 0; i <elemansayisi; i++) {
                toplam += double.Parse(lbSayilar.Items[i].ToString());

            }
            labToplam.Text = toplam.ToString();

        }

        private void btnOrtalama_Click(object sender, EventArgs e)
        {

            double toplam = 0, ortalama;
            int elemansayisi = lbSayilar.Items.Count;

            for (int i = 0; i < elemansayisi; i++)
            {
                toplam += double.Parse(lbSayilar.Items[i].ToString());

            }
            ortalama =Math.Round(toplam / elemansayisi,2);
            labOrtalama.Text = ortalama.ToString();
        }

        private void btnEnbuyuk_Click(object sender, EventArgs e)
        {
            double enbuyuk;
            enbuyuk= double.Parse( lbSayilar.Items[0].ToString());
            // enbuyuk = (double)lbSayilar.Items[0];
            double eleman;
            int elemansayisi= lbSayilar.Items.Count;
            for (int i = 0; i < elemansayisi; i++)
            {
                eleman = double.Parse(lbSayilar.Items[i].ToString());
             
                if (eleman>enbuyuk)
                {
                    enbuyuk = eleman;
                }
                //2 ,5,3,4,10,9,7
            }
            labEnbuyuk.Text = enbuyuk.ToString();
        }

        private void btnEnKucuk_Click(object sender, EventArgs e)
        {
            double enkucuk;
            enkucuk = double.Parse(lbSayilar.Items[0].ToString());
           
            double eleman;
            int elemansayisi = lbSayilar.Items.Count;
            for (int i = 0; i < elemansayisi; i++)
            {
                eleman = double.Parse(lbSayilar.Items[i].ToString());

                if (enkucuk>eleman)
                if (enkucuk>eleman)
                {
                    enkucuk = eleman;
                }
                //2 ,5,3,4,10,9,7
            }
            labEnKucuk.Text = enkucuk.ToString();
        }
    }
}
