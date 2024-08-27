using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _52_Radio_Button_Temel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList a = new ArrayList();


        static int topla(ArrayList x)
        {
            int sonuc = 0;
            for (int i = 0;i<x.Count;i++)
            {
                sonuc += (int)x[i];
            }
            return sonuc;
        }
      
        private void btnEkle_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(txtSayi.Text);
         
            a.Add(sayi);

            /*for (int i = 0; i < a.Count; i++)
            {
                MessageBox.Show(a[i].ToString());
            }*/
           
           MessageBox.Show("Toplamı:"+topla(a).ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
