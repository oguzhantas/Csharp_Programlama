namespace _021_RadioButton_Hesap
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbYuzde1 = new System.Windows.Forms.RadioButton();
            this.rbYuzde10 = new System.Windows.Forms.RadioButton();
            this.rbYuzde20 = new System.Windows.Forms.RadioButton();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.Fiyat = new System.Windows.Forms.Label();
            this.labKDV = new System.Windows.Forms.Label();
            this.txtKDV = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbYuzde20);
            this.groupBox1.Controls.Add(this.rbYuzde10);
            this.groupBox1.Controls.Add(this.rbYuzde1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(72, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KDV Oranı Seçiniz";
            // 
            // rbYuzde1
            // 
            this.rbYuzde1.AutoSize = true;
            this.rbYuzde1.Location = new System.Drawing.Point(74, 47);
            this.rbYuzde1.Name = "rbYuzde1";
            this.rbYuzde1.Size = new System.Drawing.Size(57, 25);
            this.rbYuzde1.TabIndex = 0;
            this.rbYuzde1.TabStop = true;
            this.rbYuzde1.Text = "%1";
            this.rbYuzde1.UseVisualStyleBackColor = true;
            // 
            // rbYuzde10
            // 
            this.rbYuzde10.AutoSize = true;
            this.rbYuzde10.Location = new System.Drawing.Point(74, 88);
            this.rbYuzde10.Name = "rbYuzde10";
            this.rbYuzde10.Size = new System.Drawing.Size(66, 25);
            this.rbYuzde10.TabIndex = 1;
            this.rbYuzde10.TabStop = true;
            this.rbYuzde10.Text = "%10";
            this.rbYuzde10.UseVisualStyleBackColor = true;
            // 
            // rbYuzde20
            // 
            this.rbYuzde20.AutoSize = true;
            this.rbYuzde20.Location = new System.Drawing.Point(74, 129);
            this.rbYuzde20.Name = "rbYuzde20";
            this.rbYuzde20.Size = new System.Drawing.Size(66, 25);
            this.rbYuzde20.TabIndex = 2;
            this.rbYuzde20.TabStop = true;
            this.rbYuzde20.Text = "%20";
            this.rbYuzde20.UseVisualStyleBackColor = true;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFiyat.Location = new System.Drawing.Point(463, 108);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 28);
            this.txtFiyat.TabIndex = 1;
            // 
            // Fiyat
            // 
            this.Fiyat.AutoSize = true;
            this.Fiyat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Fiyat.Location = new System.Drawing.Point(346, 115);
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.Size = new System.Drawing.Size(46, 21);
            this.Fiyat.TabIndex = 2;
            this.Fiyat.Text = "Fiyat";
            // 
            // labKDV
            // 
            this.labKDV.AutoSize = true;
            this.labKDV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labKDV.Location = new System.Drawing.Point(349, 159);
            this.labKDV.Name = "labKDV";
            this.labKDV.Size = new System.Drawing.Size(95, 21);
            this.labKDV.TabIndex = 3;
            this.labKDV.Text = "KDV\'li Fiyat";
            // 
            // txtKDV
            // 
            this.txtKDV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKDV.Location = new System.Drawing.Point(463, 152);
            this.txtKDV.Name = "txtKDV";
            this.txtKDV.Size = new System.Drawing.Size(100, 28);
            this.txtKDV.TabIndex = 4;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(350, 216);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(225, 46);
            this.btnHesapla.TabIndex = 5;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtKDV);
            this.Controls.Add(this.labKDV);
            this.Controls.Add(this.Fiyat);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbYuzde20;
        private System.Windows.Forms.RadioButton rbYuzde10;
        private System.Windows.Forms.RadioButton rbYuzde1;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label Fiyat;
        private System.Windows.Forms.Label labKDV;
        private System.Windows.Forms.TextBox txtKDV;
        private System.Windows.Forms.Button btnHesapla;
    }
}

