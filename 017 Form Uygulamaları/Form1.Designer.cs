namespace _017_Form_Uygulamaları
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
            this.btnMerhaba = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMerhaba
            // 
            this.btnMerhaba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnMerhaba.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMerhaba.ForeColor = System.Drawing.Color.White;
            this.btnMerhaba.Location = new System.Drawing.Point(263, 184);
            this.btnMerhaba.Name = "btnMerhaba";
            this.btnMerhaba.Size = new System.Drawing.Size(219, 68);
            this.btnMerhaba.TabIndex = 0;
            this.btnMerhaba.Text = "Merhaba";
            this.btnMerhaba.UseVisualStyleBackColor = false;
            this.btnMerhaba.Click += new System.EventHandler(this.btnMerhaba_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMerhaba);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Merhaba C# ile Görsel Programlama";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMerhaba;
    }
}

