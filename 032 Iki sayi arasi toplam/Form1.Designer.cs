namespace _032_Iki_sayi_arasi_toplam
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
            this.txtBaslangic = new System.Windows.Forms.TextBox();
            this.txtBitis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTopla = new System.Windows.Forms.Button();
            this.labSonuc = new System.Windows.Forms.Label();
            this.rbTek = new System.Windows.Forms.RadioButton();
            this.rbCift = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtBaslangic
            // 
            this.txtBaslangic.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBaslangic.Location = new System.Drawing.Point(208, 97);
            this.txtBaslangic.Name = "txtBaslangic";
            this.txtBaslangic.Size = new System.Drawing.Size(100, 32);
            this.txtBaslangic.TabIndex = 0;
            // 
            // txtBitis
            // 
            this.txtBitis.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBitis.Location = new System.Drawing.Point(208, 138);
            this.txtBitis.Name = "txtBitis";
            this.txtBitis.Size = new System.Drawing.Size(100, 32);
            this.txtBitis.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(72, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Başlangıç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(72, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bitiş";
            // 
            // btnTopla
            // 
            this.btnTopla.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTopla.Location = new System.Drawing.Point(67, 290);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(392, 50);
            this.btnTopla.TabIndex = 4;
            this.btnTopla.Text = "Topla";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // labSonuc
            // 
            this.labSonuc.AutoSize = true;
            this.labSonuc.BackColor = System.Drawing.Color.Yellow;
            this.labSonuc.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labSonuc.Location = new System.Drawing.Point(391, 97);
            this.labSonuc.Name = "labSonuc";
            this.labSonuc.Size = new System.Drawing.Size(68, 72);
            this.labSonuc.TabIndex = 5;
            this.labSonuc.Text = "0";
            // 
            // rbTek
            // 
            this.rbTek.AutoSize = true;
            this.rbTek.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbTek.Location = new System.Drawing.Point(208, 202);
            this.rbTek.Name = "rbTek";
            this.rbTek.Size = new System.Drawing.Size(130, 28);
            this.rbTek.TabIndex = 6;
            this.rbTek.TabStop = true;
            this.rbTek.Text = "Tek Sayılar";
            this.rbTek.UseVisualStyleBackColor = true;
            // 
            // rbCift
            // 
            this.rbCift.AutoSize = true;
            this.rbCift.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbCift.Location = new System.Drawing.Point(208, 236);
            this.rbCift.Name = "rbCift";
            this.rbCift.Size = new System.Drawing.Size(127, 28);
            this.rbCift.TabIndex = 7;
            this.rbCift.TabStop = true;
            this.rbCift.Text = "Çift Sayılar";
            this.rbCift.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 386);
            this.Controls.Add(this.rbCift);
            this.Controls.Add(this.rbTek);
            this.Controls.Add(this.labSonuc);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBitis);
            this.Controls.Add(this.txtBaslangic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBaslangic;
        private System.Windows.Forms.TextBox txtBitis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Label labSonuc;
        private System.Windows.Forms.RadioButton rbTek;
        private System.Windows.Forms.RadioButton rbCift;
    }
}

