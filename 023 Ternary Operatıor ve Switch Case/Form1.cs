using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _023_Ternary_Operatıor_ve_Switch_Case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            // yaş 18'den büyük eşit
            // Cinsiyet bilgisi de erkek ise askere gidecek
            char cinsiyet='E';
            int yas;

            yas = int.Parse(txtYas.Text);
            int secilen = cbCinsiyet.SelectedIndex; //seçilen indeks değeri
            
            //MessageBox.Show(cbCinsiyet.Items[cbCinsiyet.SelectedIndex].ToString());
            //MessageBox.Show(cbCinsiyet.SelectedItem.ToString());
           
            if (secilen == 0)
            {
                cinsiyet = 'E';
            }
            else if (secilen == 1)
            {
                cinsiyet = 'K';
            }

            if (yas>=18 && cinsiyet == 'E')
            {
                MessageBox.Show("Askere gidebilirsiniz");
            }
            else if (yas < 18 && cinsiyet == 'E')
            {
                MessageBox.Show("Yaşınız 18 den küçük olduğundan askere gidemezsiniz");
            }
            else
            {
                MessageBox.Show("Askere alınamıyorsunuz");
            }
                



        }
    }
}
