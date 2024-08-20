using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _032_Iki_sayi_arasi_toplam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            int baslangic, bitis, toplam=0;
            if (txtBitis.Text=="" || txtBaslangic.Text=="")
            {
                MessageBox.Show("Lütfen başlangıç ve bitiş değerlerini giriniz");
                txtBaslangic.Focus();
                return;
            }
            baslangic = int.Parse(txtBaslangic.Text);
            bitis = int.Parse(txtBitis.Text);

            for(int i = baslangic; i <= bitis; i++)
            {
                if (rbTek.Checked)
                {
                    if (i % 2 == 1)
                        toplam = toplam + i;
                }
                else if (rbCift.Checked)
                {
                    if (i % 2 == 0)
                        toplam = toplam + i;
                }
               
            }
            labSonuc.Text = toplam.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbTek.Checked = true;
            txtBaslangic.Text = "";
            txtBitis.Text = "";
        }
    }
}
