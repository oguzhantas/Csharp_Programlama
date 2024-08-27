namespace _53_Otopark
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbAracListe = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lbAracFiyat = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdiSoyadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.cbSaat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBosalt = new System.Windows.Forms.Button();
            this.btnSecileniSil = new System.Windows.Forms.Button();
            this.lbTarife = new System.Windows.Forms.ListBox();
            this.labToplam = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbSaat);
            this.groupBox1.Controls.Add(this.txtPlaka);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAdiSoyadi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(58, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araç Bilgileri";
            // 
            // lbAracListe
            // 
            this.lbAracListe.BackColor = System.Drawing.Color.LightGreen;
            this.lbAracListe.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbAracListe.FormattingEnabled = true;
            this.lbAracListe.ItemHeight = 24;
            this.lbAracListe.Location = new System.Drawing.Point(70, 334);
            this.lbAracListe.Name = "lbAracListe";
            this.lbAracListe.Size = new System.Drawing.Size(456, 196);
            this.lbAracListe.TabIndex = 1;
            this.lbAracListe.SelectedIndexChanged += new System.EventHandler(this.lbAracListe_SelectedIndexChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(58, 249);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(468, 38);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lbAracFiyat
            // 
            this.lbAracFiyat.BackColor = System.Drawing.Color.Aqua;
            this.lbAracFiyat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbAracFiyat.FormattingEnabled = true;
            this.lbAracFiyat.ItemHeight = 24;
            this.lbAracFiyat.Location = new System.Drawing.Point(532, 331);
            this.lbAracFiyat.Name = "lbAracFiyat";
            this.lbAracFiyat.Size = new System.Drawing.Size(229, 196);
            this.lbAracFiyat.TabIndex = 3;
            this.lbAracFiyat.SelectedIndexChanged += new System.EventHandler(this.lbAracFiyat_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı Soyadı";
            // 
            // txtAdiSoyadi
            // 
            this.txtAdiSoyadi.Location = new System.Drawing.Point(199, 31);
            this.txtAdiSoyadi.Name = "txtAdiSoyadi";
            this.txtAdiSoyadi.Size = new System.Drawing.Size(176, 32);
            this.txtAdiSoyadi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Plaka ";
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(199, 70);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(176, 32);
            this.txtPlaka.TabIndex = 3;
            // 
            // cbSaat
            // 
            this.cbSaat.FormattingEnabled = true;
            this.cbSaat.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "10"});
            this.cbSaat.Location = new System.Drawing.Point(199, 108);
            this.cbSaat.Name = "cbSaat";
            this.cbSaat.Size = new System.Drawing.Size(176, 32);
            this.cbSaat.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Saat";
            // 
            // btnBosalt
            // 
            this.btnBosalt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBosalt.Location = new System.Drawing.Point(70, 533);
            this.btnBosalt.Name = "btnBosalt";
            this.btnBosalt.Size = new System.Drawing.Size(131, 38);
            this.btnBosalt.TabIndex = 6;
            this.btnBosalt.Text = "Boşalt";
            this.btnBosalt.UseVisualStyleBackColor = true;
            this.btnBosalt.Click += new System.EventHandler(this.btnBosalt_Click);
            // 
            // btnSecileniSil
            // 
            this.btnSecileniSil.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSecileniSil.Location = new System.Drawing.Point(206, 533);
            this.btnSecileniSil.Name = "btnSecileniSil";
            this.btnSecileniSil.Size = new System.Drawing.Size(143, 38);
            this.btnSecileniSil.TabIndex = 7;
            this.btnSecileniSil.Text = "Seçileni Sil";
            this.btnSecileniSil.UseVisualStyleBackColor = true;
            this.btnSecileniSil.Click += new System.EventHandler(this.btnSecileniSil_Click);
            // 
            // lbTarife
            // 
            this.lbTarife.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbTarife.FormattingEnabled = true;
            this.lbTarife.ItemHeight = 24;
            this.lbTarife.Items.AddRange(new object[] {
            "Otomobil - 50 TL",
            "SUV  - 60 TL",
            "Kamyonet - 75",
            "Panelvan - 100"});
            this.lbTarife.Location = new System.Drawing.Point(554, 35);
            this.lbTarife.Name = "lbTarife";
            this.lbTarife.Size = new System.Drawing.Size(207, 196);
            this.lbTarife.TabIndex = 8;
            // 
            // labToplam
            // 
            this.labToplam.AutoSize = true;
            this.labToplam.BackColor = System.Drawing.Color.Gold;
            this.labToplam.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labToplam.Location = new System.Drawing.Point(532, 530);
            this.labToplam.Name = "labToplam";
            this.labToplam.Size = new System.Drawing.Size(34, 36);
            this.labToplam.TabIndex = 9;
            this.labToplam.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(399, 533);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 36);
            this.label5.TabIndex = 10;
            this.label5.Text = "Toplam";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 599);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labToplam);
            this.Controls.Add(this.lbTarife);
            this.Controls.Add(this.btnSecileniSil);
            this.Controls.Add(this.btnBosalt);
            this.Controls.Add(this.lbAracFiyat);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lbAracListe);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSaat;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdiSoyadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbAracListe;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lbAracFiyat;
        private System.Windows.Forms.Button btnBosalt;
        private System.Windows.Forms.Button btnSecileniSil;
        private System.Windows.Forms.ListBox lbTarife;
        private System.Windows.Forms.Label labToplam;
        private System.Windows.Forms.Label label5;
    }
}

