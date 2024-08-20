using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _042_Foreach_Döngüsü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYaz_Click(object sender, EventArgs e)
        {
            /*string[] meyveler = { "kavun", "karpuz", "mango" };
            foreach(string meyve in meyveler)
            {
                MessageBox.Show(meyve);
            }*/

            foreach(string meyve in lbMeyveler.Items)
            {
                MessageBox.Show(meyve);
            }
            }

        }
    }
}
