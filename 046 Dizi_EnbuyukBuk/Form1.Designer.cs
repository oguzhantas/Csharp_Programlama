namespace _046_Dizi_EnbuyukBuk
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRastgeleUret = new System.Windows.Forms.Button();
            this.lbSayilar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnRastgeleUret
            // 
            this.btnRastgeleUret.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRastgeleUret.Location = new System.Drawing.Point(122, 32);
            this.btnRastgeleUret.Name = "btnRastgeleUret";
            this.btnRastgeleUret.Size = new System.Drawing.Size(210, 54);
            this.btnRastgeleUret.TabIndex = 0;
            this.btnRastgeleUret.Text = "Rastgele Sayı Üret";
            this.btnRastgeleUret.UseVisualStyleBackColor = true;
            this.btnRastgeleUret.Click += new System.EventHandler(this.btnRastgeleUret_Click);
            // 
            // lbSayilar
            // 
            this.lbSayilar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSayilar.FormattingEnabled = true;
            this.lbSayilar.ItemHeight = 24;
            this.lbSayilar.Location = new System.Drawing.Point(122, 101);
            this.lbSayilar.Name = "lbSayilar";
            this.lbSayilar.Size = new System.Drawing.Size(210, 292);
            this.lbSayilar.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbSayilar);
            this.Controls.Add(this.btnRastgeleUret);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRastgeleUret;
        private System.Windows.Forms.ListBox lbSayilar;
    }
}

