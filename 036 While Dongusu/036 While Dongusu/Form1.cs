using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _036_While_Dongusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {



            int i = 1;
            while (i <= 5)
            {
                MessageBox.Show(i.ToString() + " eleman while");
                i++;

            }



        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 5; i++)
            {
                MessageBox.Show(i.ToString() + " eleman For");
            }

        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            int i = 1;
            do
            {
                MessageBox.Show(i.ToString() + " eleman Do-While");
                i++;
            } while (i <= 5);

        }

        private void btnWhileTek_Click(object sender, EventArgs e)
        {
            int i = 1;
            while (i <= 10)
            {
                MessageBox.Show(i.ToString() + " while Tek Sayılar");
                i = i + 2; // i+=2
            }
            MessageBox.Show(i + " değişkeninin son değeri");
        }

        private void btnForTek_Click(object sender, EventArgs e)
        {
            int i = 1;
            for (i = 1; i <= 10; i += 2)
            {
                MessageBox.Show(i.ToString() + " for Tek Sayılar");
            }
            MessageBox.Show(i + " değişkeninin son değeri");
        }

        private void btnDoWhileTek_Click(object sender, EventArgs e)
        {
            int i = 1;
            do
            {
                MessageBox.Show(i.ToString() + " eleman tek sayılar do-while");
                i = i + 2;
            } while (i <= 10);
        }

        private void btnCiftWhile_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i <= 10)
            {
                MessageBox.Show(i.ToString() + " çift sayı while");
                i = i + 2;
            }
        }

        private void btnDoWhileCift_Click(object sender, EventArgs e)
        {
            int i = 0;
            do
            {
                MessageBox.Show(i.ToString() + " çift sayı Do-while");
                i = i + 2;
            } while (i <= 10);
        }

        private void btnForCift_Click(object sender, EventArgs e)
        {
            for(int i = 0; i <= 10; i += 2)
            {
                MessageBox.Show(i.ToString() + " eleman");
            }
        }
    }
}
