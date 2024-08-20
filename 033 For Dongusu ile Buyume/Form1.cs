using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _033_For_Dongusu_ile_Buyume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            lbBoy.Items.Clear();
            double oran = double.Parse(txtOran.Text);
            double boy = double.Parse(txtBaslangic.Text);
            for(int i = 1; i <= 10; i++)
            {
                boy += (boy * oran / 100);
                lbBoy.Items.Add(boy);
            }
            double sonboy = Math.Round(boy, 3);
            MessageBox.Show(sonboy.ToString());

        }
    }
}
