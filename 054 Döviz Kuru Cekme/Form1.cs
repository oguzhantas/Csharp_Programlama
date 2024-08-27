using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;  

namespace _054_Döviz_Kuru_Cekme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void DovizGoster()
        {
            try
            {
                XmlDocument xmlVerisi = new XmlDocument();
                xmlVerisi.Load("http://www.tcmb.gov.tr/kurlar/today.xml");

                decimal dolar = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "USD")).InnerText.Replace('.', ','));
                decimal euro = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "EUR")).InnerText.Replace('.', ','));
                decimal sterlin = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "GBP")).InnerText.Replace('.', ','));
                //decimal altin = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "XAU")).InnerText.Replace('.', ','));


                lbDolar.Text = dolar.ToString();
                lbEuro.Text = euro.ToString();
                lbSterlin.Text = sterlin.ToString();
            }
            catch (XmlException xml)
            {
                 timer1.Stop();
                MessageBox.Show(xml.ToString());
            }

        }

        private void btnDovizCek_Click(object sender, EventArgs e)
        {
            DovizGoster();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DovizGoster();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DovizGoster();
            labZaman.Text = DateTime.Now.ToString();
        }
    }
}
