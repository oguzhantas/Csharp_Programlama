using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;//Dosya Giriş Çıkış İşlemleri
using System.Drawing.Printing;  

namespace TodoList
{
    public partial class frmAna : Form
    {
        public frmAna()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           //İpucu ekleme
           


            lbYapilacaklar.Items.Clear();

            //Liste.txt dosyasının içeriğini satır satır okuyalım
            TextReader dosyaoku = new StreamReader("liste.txt");
            string satir;
            while (true)
            {
                satir = dosyaoku.ReadLine();//bir satir okuyup satir değişkenine
                if (satir == null) //eğer dosya sonuna gelinmişse null alır
                {
                    break;//döngüyü kesip çıkıyoruz
                }
                lbYapilacaklar.Items.Add(satir);//listbox a okunan satırı ekle

            }
            dosyaoku.Close();
            dosyaoku = null;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lbYapilacaklar.Items.Add(txtZaman.Text + " " + txtIs.Text);
            txtZaman.Text = "11:00";
            txtIs.Text = "";
            txtIs.Focus();
        }

        private void btnHepsiniSil_Click(object sender, EventArgs e)
        {
            //ListBox içeriğini tamamen boşaltır
            lbYapilacaklar.Items.Clear();
        }

        private void btnSecileniSil_Click(object sender, EventArgs e)
        {
            // Eğer listBox'ta bir seçim yapılmış ise seçileni sil
            if (lbYapilacaklar.SelectedItems.Count > 0)
            {
                //ListBox ta Seçilen elemanı siler
                lbYapilacaklar.Items.RemoveAt(lbYapilacaklar.SelectedIndex);

            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Dosyası | *.txt";
            DialogResult cevap = sfd.ShowDialog();

            if (cevap == DialogResult.OK)
            {
                // MessageBox.Show("Dosya kaydetme işlemi başlıyor.");
                TextWriter dosya = new StreamWriter(sfd.FileName);


                for (int i = 0; i < lbYapilacaklar.Items.Count; i++)
                {
                    dosya.WriteLine(lbYapilacaklar.Items[i].ToString());
                }

                MessageBox.Show("Başarıyla kaydedildi", "Başarılı",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                dosya.Flush();
                dosya.Close();
                dosya = null;
            }
        }

        private void btnDosyaAc_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Dosyası | *.txt";
            ofd.RestoreDirectory = true;

            DialogResult cevap = ofd.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                lbYapilacaklar.Items.Clear();
                TextReader dosyaoku = new StreamReader(ofd.FileName);
                string satir;
                while (true)
                {
                    satir = dosyaoku.ReadLine();//bir satir okuyup satir değişkenine
                    if (satir == null) //eğer dosya sonuna gelinmişse null alır
                    {
                        break;//döngüyü kesip çıkıyoruz
                    }
                    lbYapilacaklar.Items.Add(satir);//listbox a okunan satırı ekle

                }
                dosyaoku.Close();
                dosyaoku = null;

            }



        }
        private PrintDocument belge = new PrintDocument();
        private void btnYazdir_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog ppd = new PrintPreviewDialog(); //Önizleme ekranı 
            //Yazdırma işlemi başlıyor
            ppd.Document = belge;
            ppd.Document.DocumentName = "Test";
            belge.PrintPage += Listbox_Yazdir;
            ppd.ShowDialog();
        }




        void Listbox_Yazdir(object sender, PrintPageEventArgs e)
        {
            e.Graphics.PageUnit = GraphicsUnit.Millimeter;
            int leading = 3; //Satır arası mesafe
            int leftMargin = 25; //Soldan boşluk
            int topMargin = 10; //Üstten boşluk

            // FmtRight Sağa hizalar, FmtLeft Sola hizalar, FmtCenter Ortalar
            StringFormat FmtRight = new StringFormat() { Alignment = StringAlignment.Far };
            StringFormat FmtLeft = new StringFormat() { Alignment = StringAlignment.Near };
            StringFormat FmtCenter = new StringFormat() { Alignment = StringAlignment.Near };

            StringFormat fmt = FmtLeft;

            using (Font font = new Font("Tahoma", 12f))
            {
                SizeF sz = e.Graphics.MeasureString("_|", Font);
                float h = sz.Height + leading;

                for (int i = 0; i < lbYapilacaklar.Items.Count; i++)
                    e.Graphics.DrawString(lbYapilacaklar.Items[i].ToString(), font, Brushes.Black,
                                          leftMargin, topMargin + h * i, fmt);
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            {
                FontDialog fd = new FontDialog();
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    lbYapilacaklar.Font = fd.Font;
                }
            }
        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                lbYapilacaklar.ForeColor = cd.Color;
            }
        }

        private void btnZeminRenk_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                lbYapilacaklar.BackColor = cd.Color;
            }
        }
    }
}
