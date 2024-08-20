namespace _043_Dizilere_Giriş
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
            this.btnDiziYaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDiziYaz
            // 
            this.btnDiziYaz.Location = new System.Drawing.Point(85, 165);
            this.btnDiziYaz.Name = "btnDiziYaz";
            this.btnDiziYaz.Size = new System.Drawing.Size(167, 54);
            this.btnDiziYaz.TabIndex = 0;
            this.btnDiziYaz.Text = "Dizi Yaz ve Topla";
            this.btnDiziYaz.UseVisualStyleBackColor = true;
            this.btnDiziYaz.Click += new System.EventHandler(this.btnDiziYaz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDiziYaz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDiziYaz;
    }
}

