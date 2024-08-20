using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _043_Dizilere_Giriş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnDiziYaz_Click(object sender, EventArgs e)
        {
            int[] a = { 1, 3, 5, 7, 9 };

            int toplam = 0;
            for (int i = 0; i < a.Length; i++)
            {
                //MessageBox.Show(a[i].ToString());
                toplam += a[i];
            }
            MessageBox.Show("Toplam :" + toplam.ToString());
        }
    }
}
