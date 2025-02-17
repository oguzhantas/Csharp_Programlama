using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoList
{
    public partial class frmGiris : Form
    {

        public frmGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string k = "admin", s = "1234";

            string kullanici = txtKullanici.Text;
            string sifre = txtSifre.Text;
            if (string.IsNullOrEmpty(kullanici) || string.IsNullOrEmpty(sifre))
            {

                MessageBox.Show("Kullanıcı adı veya şifre boş geçilemez", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (kullanici == k && sifre == s)
                {
                    //Form açılacak
                    // MessageBox.Show("Giriş OK");
                    this.Hide(); //Mevcut formu gizle
                    frmAna fana = new frmAna(); //Ana Formu çağır
                    fana.ShowDialog(); //Ana Formu aç
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış", "Uyarı",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
