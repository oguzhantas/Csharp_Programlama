using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _046_Dizi_EnbuyukBuk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRastgeleUret_Click(object sender, EventArgs e)
        {
            lbSayilar.Items.Clear();
            Random rastgele = new Random();
            int sayi;
            int[] dizi = new int[10];
            for(int i = 0; i < 10; i++) //0,1,2,3,4,5,6,7,8,9
            {
                sayi=rastgele.Next(1, 101); // 1 ile 100 arası sayı üretir
                dizi[i] = sayi;
                lbSayilar.Items.Add(sayi);

            }
            //en büyük ve en küçük elemanı buluyoruz
            int enbuyuk = dizi[0];
            int enkucuk = dizi[0];
            for (int i = 0; i < dizi.Length; i++) {
                if (dizi[i] > enbuyuk)
                {
                    enbuyuk = dizi[i];
                }
                if (dizi[i] < enkucuk)
                {
                    enkucuk = dizi[i];
                }

            }

            MessageBox.Show("En büyük değer:" + enbuyuk);
            MessageBox.Show("En küçük değer:" + enkucuk);


        }
    }
}
