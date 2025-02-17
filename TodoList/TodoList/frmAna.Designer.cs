namespace TodoList
{
    partial class frmAna
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lbYapilacaklar = new System.Windows.Forms.ListBox();
            txtIs = new System.Windows.Forms.TextBox();
            txtZaman = new System.Windows.Forms.MaskedTextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btnHepsiniSil = new System.Windows.Forms.Button();
            btnSecileniSil = new System.Windows.Forms.Button();
            btnKaydet = new System.Windows.Forms.Button();
            btnEkle = new System.Windows.Forms.Button();
            btnDosyaAc = new System.Windows.Forms.Button();
            btnYazdir = new System.Windows.Forms.Button();
            btnFont = new System.Windows.Forms.Button();
            btnRenk = new System.Windows.Forms.Button();
            btnZeminRenk = new System.Windows.Forms.Button();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            SuspendLayout();
            // 
            // lbYapilacaklar
            // 
            lbYapilacaklar.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            lbYapilacaklar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbYapilacaklar.FormattingEnabled = true;
            lbYapilacaklar.ItemHeight = 16;
            lbYapilacaklar.Location = new System.Drawing.Point(47, 104);
            lbYapilacaklar.Name = "lbYapilacaklar";
            lbYapilacaklar.Size = new System.Drawing.Size(263, 212);
            lbYapilacaklar.TabIndex = 0;
            // 
            // txtIs
            // 
            txtIs.BackColor = System.Drawing.Color.Yellow;
            txtIs.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtIs.Location = new System.Drawing.Point(117, 27);
            txtIs.Name = "txtIs";
            txtIs.Size = new System.Drawing.Size(164, 23);
            txtIs.TabIndex = 1;
            // 
            // txtZaman
            // 
            txtZaman.BackColor = System.Drawing.Color.FromArgb(255, 192, 128);
            txtZaman.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtZaman.Location = new System.Drawing.Point(117, 60);
            txtZaman.Mask = "00:00";
            txtZaman.Name = "txtZaman";
            txtZaman.Size = new System.Drawing.Size(100, 23);
            txtZaman.TabIndex = 3;
            txtZaman.Text = "1000";
            txtZaman.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(40, 34);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 16);
            label1.TabIndex = 4;
            label1.Text = "İş Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(43, 63);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(50, 16);
            label2.TabIndex = 5;
            label2.Text = "Zaman,";
            // 
            // btnHepsiniSil
            // 
            btnHepsiniSil.Location = new System.Drawing.Point(316, 107);
            btnHepsiniSil.Name = "btnHepsiniSil";
            btnHepsiniSil.Size = new System.Drawing.Size(88, 23);
            btnHepsiniSil.TabIndex = 6;
            btnHepsiniSil.Text = "Hepsini Sil";
            btnHepsiniSil.UseVisualStyleBackColor = true;
            btnHepsiniSil.Click += btnHepsiniSil_Click;
            // 
            // btnSecileniSil
            // 
            btnSecileniSil.Location = new System.Drawing.Point(316, 134);
            btnSecileniSil.Name = "btnSecileniSil";
            btnSecileniSil.Size = new System.Drawing.Size(89, 23);
            btnSecileniSil.TabIndex = 7;
            btnSecileniSil.Text = "SeçileniSil";
            btnSecileniSil.UseVisualStyleBackColor = true;
            btnSecileniSil.Click += btnSecileniSil_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new System.Drawing.Point(316, 163);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new System.Drawing.Size(89, 23);
            btnKaydet.TabIndex = 8;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new System.Drawing.Point(304, 31);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new System.Drawing.Size(75, 23);
            btnEkle.TabIndex = 9;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnDosyaAc
            // 
            btnDosyaAc.Location = new System.Drawing.Point(316, 192);
            btnDosyaAc.Name = "btnDosyaAc";
            btnDosyaAc.Size = new System.Drawing.Size(88, 23);
            btnDosyaAc.TabIndex = 10;
            btnDosyaAc.Text = "Dosya Aç";
            btnDosyaAc.UseVisualStyleBackColor = true;
            btnDosyaAc.Click += btnDosyaAc_Click;
            // 
            // btnYazdir
            // 
            btnYazdir.Location = new System.Drawing.Point(316, 221);
            btnYazdir.Name = "btnYazdir";
            btnYazdir.Size = new System.Drawing.Size(88, 23);
            btnYazdir.TabIndex = 11;
            btnYazdir.Text = "Yazdır";
            btnYazdir.UseVisualStyleBackColor = true;
            btnYazdir.Click += btnYazdir_Click;
            // 
            // btnFont
            // 
            btnFont.Location = new System.Drawing.Point(40, 322);
            btnFont.Name = "btnFont";
            btnFont.Size = new System.Drawing.Size(75, 23);
            btnFont.TabIndex = 12;
            btnFont.Text = "Font";
            btnFont.UseVisualStyleBackColor = true;
            btnFont.Click += btnFont_Click;
            // 
            // btnRenk
            // 
            btnRenk.Location = new System.Drawing.Point(117, 322);
            btnRenk.Name = "btnRenk";
            btnRenk.Size = new System.Drawing.Size(100, 23);
            btnRenk.TabIndex = 13;
            btnRenk.Text = "Yazı Rengi";
            btnRenk.UseVisualStyleBackColor = true;
            btnRenk.Click += btnRenk_Click;
            // 
            // btnZeminRenk
            // 
            btnZeminRenk.Location = new System.Drawing.Point(223, 322);
            btnZeminRenk.Name = "btnZeminRenk";
            btnZeminRenk.Size = new System.Drawing.Size(87, 23);
            btnZeminRenk.TabIndex = 14;
            btnZeminRenk.Text = "Zemin Rengi";
            btnZeminRenk.UseVisualStyleBackColor = true;
            btnZeminRenk.Click += btnZeminRenk_Click;
            // 
            // frmAna
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(428, 368);
            Controls.Add(btnZeminRenk);
            Controls.Add(btnRenk);
            Controls.Add(btnFont);
            Controls.Add(btnYazdir);
            Controls.Add(btnDosyaAc);
            Controls.Add(btnEkle);
            Controls.Add(btnKaydet);
            Controls.Add(btnSecileniSil);
            Controls.Add(btnHepsiniSil);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtZaman);
            Controls.Add(txtIs);
            Controls.Add(lbYapilacaklar);
            Name = "frmAna";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Yapılacaklar Listesi";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox lbYapilacaklar;
        private System.Windows.Forms.TextBox txtIs;
        private System.Windows.Forms.MaskedTextBox txtZaman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHepsiniSil;
        private System.Windows.Forms.Button btnSecileniSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnDosyaAc;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnRenk;
        private System.Windows.Forms.Button btnZeminRenk;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
