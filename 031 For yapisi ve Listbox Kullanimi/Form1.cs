using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _030_For_yapisi_ve_Listbox_Kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            lbMeyveler.Items.Clear();
            //Listbox içeriği temizler
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lbMeyveler.Items.Add("Karpuz");
            lbMeyveler.Items.Add("Kavun");
        }

        private void btnSay_Click(object sender, EventArgs e)
        {
            int elemansayisi = lbMeyveler.Items.Count;
            MessageBox.Show(elemansayisi.ToString());
        }

        private void btnSecileniSil_Click(object sender, EventArgs e)
        {
            //Seçileni siler
            lbMeyveler.Items.RemoveAt(lbMeyveler.SelectedIndex);
        }

        private void btnSayiEkle_Click(object sender, EventArgs e)
        {
            for(int i = 1; i <= 5; i++)
            {
                lbMeyveler.Items.Add(i);
            }
        }
    }
}
