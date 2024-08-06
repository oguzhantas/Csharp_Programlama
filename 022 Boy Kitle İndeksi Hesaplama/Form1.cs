using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _022_Boy_Kitle_İndeksi_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double boy, kilo, bki;

            boy = double.Parse(txtBoy.Text);
            kilo = double.Parse(txtKilo.Text);
            bki =kilo / Math.Pow(boy,2);
            //Pow fonksiyonu üstel hesaplama yapar

            double bkison = Math.Round(bki, 2);
             //Virgülden sonra 2 haneye yuvarlama
            
            labSonuc.Text = bkison.ToString();
            //String(Metinsel ifadeye çevirdik)

            if (bki < 20)  //bki<20
                labSonuc.Text += " Zayıf";
            else if (bki >= 20 && bki < 25)  //20<=bki<25
                labSonuc.Text += " Normal";
            else if (bki >= 25 && bki < 30)  //25<=bki<30
                labSonuc.Text += " Hafif Şişman ";
            else if (bki >= 30 && bki < 35)  //30<=bki<35
                labSonuc.Text += " Şişman ";
            else if (bki >= 35 && bki < 45)  //35<=bki<45
                labSonuc.Text += " Ciddi durum ";
            else if (bki >= 45 && bki < 50)  //45<=bki<50
                labSonuc.Text += " Aşırı Şişman ";
            else if (bki >= 50)
                labSonuc.Text += " Morbid";
        }
    }
}
