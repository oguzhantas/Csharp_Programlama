using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _056_Metotla_Rasgele_Şifre_Üretme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string sifreUret(Random rastgele, int kharfAdet, int bharfAdet, 
            int rakamAdet, int sembolAdet)
        {
            //Random rastgele = new Random();
            string bharfSifre="",  kharfSifre="", rakamSifre = "", sembolSifre="";


        
            //Büyük Harf
            for (int i = 0;i < bharfAdet; i++)
            {
                int buyukHarf = rastgele.Next(65, 91); 
                bharfSifre += ((char)buyukHarf).ToString();
            }
            //Küçük Harf
            for (int i = 0; i < kharfAdet; i++)
            {
                int kucukHarf = rastgele.Next(97, 123);
                kharfSifre += ((char)kucukHarf).ToString();
            }
            //Rakam 
            for (int i = 0; i < rakamAdet; i++)
            {
                int rakam = rastgele.Next(48, 58);
                rakamSifre += ((char)rakam).ToString();
            }
            //Sembol
            for (int i = 0; i < sembolAdet; i++)
            {
                int sembol = rastgele.Next(58, 65);
                sembolSifre += ((char)sembol).ToString();
            }

            string sifre= kharfSifre+bharfSifre+rakamSifre+sembolSifre;
            return sifre;
        }


        private void btnUret_Click(object sender, EventArgs e)
        {
           
            int adetKucukHarf= int.Parse(txtKucukHarf.Text);
            int adetBuyukHarf = int.Parse(txtBuyukHarf.Text);
            int adetRakam = int.Parse(txtRakam.Text);
            int adetSembol= int.Parse(txtSembol.Text);
            
            Random rastgele = new Random(); 
            for(int i= 0; i < 10; i++)
            {
                string sonSifre = sifreUret(rastgele, adetKucukHarf, adetBuyukHarf, adetRakam, adetSembol);
                lbSifreler.Items.Add(sonSifre);
            }
      
          
            
        }
    }
}
