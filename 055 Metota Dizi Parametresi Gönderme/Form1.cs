using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _055_Metota_Dizi_Parametresi_Gönderme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static void diziYaz(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                MessageBox.Show(a[i].ToString());
            }
        }
        
        static int diziTopla(int[] a) 
        {
            int toplam = 0;
            for (int i = 0; i < a.Length; i++)
            {
                toplam += a[i];
            }

            return toplam;
        }
        
        private void btnDiziYaz_Click(object sender, EventArgs e)
        {
            int[] dizi = { 5, 10, 15 ,20 };
            // diziYaz(dizi);
            int sonuc;
            sonuc = diziTopla(dizi);
            MessageBox.Show(sonuc.ToString());
        
        }

        static int[] sayiUret(int baslangic, int bitis, int adet)
        {
            int[] sayilar = new int[adet];

            Random rastgele = new Random();
            for (int i = 0; i < adet; i++)
            {
                sayilar[i] = rastgele.Next(baslangic, bitis + 1);
              
            }
            
            return(sayilar);
        }

        static void ListBoxYaz(ListBox list, int[] x)
        {
            for(int i = 0; i < x.Length; i++)
            {
                list.Items.Add(x[i]);
            }
        }

        private void btnRastgele_Click(object sender, EventArgs e)
        {
            int start, stop, n;
            int sayi;

            start= int.Parse(txtBaslangic.Text);
            stop= int.Parse(txtBitis.Text);
            n= int.Parse(txtAdet.Text);

            int[] dizi = new int[n];
            dizi = sayiUret(start, stop, n);
            ListBoxYaz(lbSayilar, dizi);
            
        }
    }
}
