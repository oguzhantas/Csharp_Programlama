using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _045_Dizi_içindeki_Rakamları_Bulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            string cumle = txtCumle.Text; 
            // bakkaldan 5 kg elma aldım
            for (int i = 0; i < cumle.Length; i++) {

                if (cumle[i]>='0' && cumle[i]<='9')
                {
                    lbSayilar.Items.Add(cumle[i]);
                }
            
            }

        }
    }
}
