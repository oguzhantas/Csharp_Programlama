using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _032_Rastgele_Sayi_Uretme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            int sayi;
            int baslangic= int.Parse(txtBaslangic.Text); //1
            int bitis = int.Parse(txtBitis.Text); //100
            int adet = int.Parse(txtAdet.Text); // Kaç adet 10

            Random rastgele = new Random();
            for(int i = 1; i <= adet; i++)
            {
                sayi= rastgele.Next(baslangic, bitis+1);
                lbSayilar.Items.Add(sayi);
            }
           
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lbSayilar.Items.Clear();
        }
    }
}
