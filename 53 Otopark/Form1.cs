using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _53_Otopark
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bosalt()
        {
            txtAdiSoyadi.Text = "";
            txtPlaka.Text = "";
            cbSaat.SelectedIndex = 0;
            txtAdiSoyadi.Focus();
        }
        static  double fiyatTopla(ListBox liste)
        {
            double toplam = 0;
            for(int i = 0; i < liste.Items.Count; i++)
            {

                toplam += double.Parse(liste.Items[i].ToString());
            }
            return toplam;

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            string adsoyad, plaka, arac;
            int saat;
            double fiyat=0, tutar=0;

            adsoyad = txtAdiSoyadi.Text;
            plaka = txtPlaka.Text;
            arac = lbTarife.SelectedItem.ToString();

            lbAracListe.Items.Add(adsoyad + " " + plaka + " " + arac);
            if (lbTarife.SelectedIndex == 0)
            {
                fiyat = 50; //otomobil
            }
            else if (lbTarife.SelectedIndex == 1)
            {
                fiyat = 60;//suv
            }
            else if (lbTarife.SelectedIndex == 2)
            {
                fiyat = 75; //kamyonet
            }
            if (lbTarife.SelectedIndex == 3)
            {
                fiyat = 100;//panelvan
            }

            saat = int.Parse(cbSaat.Items[cbSaat.SelectedIndex].ToString());

            //saat = int.Parse(cbSaat.SelectedItem.ToString());
            tutar = saat * fiyat;
            lbAracFiyat.Items.Add(tutar);
            labToplam.Text = fiyatTopla(lbAracFiyat).ToString();
            Bosalt();
           
        }

        private void lbAracListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbAracFiyat.SelectedIndex = lbAracListe.SelectedIndex;
        }

        private void lbAracFiyat_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbAracListe.SelectedIndex = lbAracFiyat.SelectedIndex;
        }

        private void btnBosalt_Click(object sender, EventArgs e)
        {
            lbAracListe.Items.Clear();
            lbAracFiyat.Items.Clear();
            labToplam.Text = "0";
        }

        private void btnSecileniSil_Click(object sender, EventArgs e)
        {
            int secilen = lbAracListe.SelectedIndex;
            lbAracListe.Items.RemoveAt(secilen);
            lbAracFiyat.Items.RemoveAt(secilen);
            labToplam.Text = fiyatTopla(lbAracFiyat).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbTarife.SelectedIndex = 1;
        }
    }
}
