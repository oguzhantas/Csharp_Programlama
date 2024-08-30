using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _057_Metot_Sonsuz_Parametreli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int topla(int s1, int s2)
        {
            int sonuc = s1 + s2;
            return sonuc;
        }

        static int toplaSonsuz(params int[] sayilar)
        {
            int sonuc = 0;
            for(int i=0;i < sayilar.Length; i++)
            {
                sonuc += sayilar[i];
            }
            return sonuc;
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(topla(2, 3).ToString());

            MessageBox.Show(toplaSonsuz(2, 3).ToString()); //5
            MessageBox.Show(toplaSonsuz(5, 7,9).ToString()); //21
            MessageBox.Show(toplaSonsuz(2,4,6,8,10).ToString()); //30

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int s= int.Parse(txtSayi.Text);
            lbSayilar.Items.Add(s);

            int[] dizi = new int[lbSayilar.Items.Count];
            for(int i=0;i<lbSayilar.Items.Count;i++)
            {
                dizi[i]= int.Parse( lbSayilar.Items[i].ToString());
            }

            //MessageBox.Show(  toplaSonsuz(dizi).ToString());
            labToplam.Text = toplaSonsuz(dizi).ToString();
        }
    }
}
