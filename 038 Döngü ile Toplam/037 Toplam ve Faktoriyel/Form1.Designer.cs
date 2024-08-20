namespace _037_Toplam_ve_Faktoriyel
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
            this.lbSayilar = new System.Windows.Forms.ListBox();
            this.btnToplam = new System.Windows.Forms.Button();
            this.btnEnbuyuk = new System.Windows.Forms.Button();
            this.btnOrtalama = new System.Windows.Forms.Button();
            this.btnEnKucuk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labEnKucuk = new System.Windows.Forms.Label();
            this.labEnbuyuk = new System.Windows.Forms.Label();
            this.labOrtalama = new System.Windows.Forms.Label();
            this.labToplam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbSayilar
            // 
            this.lbSayilar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSayilar.FormattingEnabled = true;
            this.lbSayilar.ItemHeight = 24;
            this.lbSayilar.Items.AddRange(new object[] {
            "2",
            "5",
            "3",
            "4",
            "10",
            "9",
            "7"});
            this.lbSayilar.Location = new System.Drawing.Point(55, 59);
            this.lbSayilar.Name = "lbSayilar";
            this.lbSayilar.Size = new System.Drawing.Size(211, 292);
            this.lbSayilar.TabIndex = 0;
            // 
            // btnToplam
            // 
            this.btnToplam.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToplam.Location = new System.Drawing.Point(272, 59);
            this.btnToplam.Name = "btnToplam";
            this.btnToplam.Size = new System.Drawing.Size(211, 47);
            this.btnToplam.TabIndex = 1;
            this.btnToplam.Text = "Toplamı Bul";
            this.btnToplam.UseVisualStyleBackColor = true;
            this.btnToplam.Click += new System.EventHandler(this.btnToplam_Click);
            // 
            // btnEnbuyuk
            // 
            this.btnEnbuyuk.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnbuyuk.Location = new System.Drawing.Point(272, 165);
            this.btnEnbuyuk.Name = "btnEnbuyuk";
            this.btnEnbuyuk.Size = new System.Drawing.Size(211, 47);
            this.btnEnbuyuk.TabIndex = 2;
            this.btnEnbuyuk.Text = "En büyük Bul";
            this.btnEnbuyuk.UseVisualStyleBackColor = true;
            this.btnEnbuyuk.Click += new System.EventHandler(this.btnEnbuyuk_Click);
            // 
            // btnOrtalama
            // 
            this.btnOrtalama.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrtalama.Location = new System.Drawing.Point(272, 112);
            this.btnOrtalama.Name = "btnOrtalama";
            this.btnOrtalama.Size = new System.Drawing.Size(211, 47);
            this.btnOrtalama.TabIndex = 3;
            this.btnOrtalama.Text = "Ortalama Bul";
            this.btnOrtalama.UseVisualStyleBackColor = true;
            this.btnOrtalama.Click += new System.EventHandler(this.btnOrtalama_Click);
            // 
            // btnEnKucuk
            // 
            this.btnEnKucuk.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnKucuk.Location = new System.Drawing.Point(272, 218);
            this.btnEnKucuk.Name = "btnEnKucuk";
            this.btnEnKucuk.Size = new System.Drawing.Size(211, 47);
            this.btnEnKucuk.TabIndex = 4;
            this.btnEnKucuk.Text = "En Küçük Bul";
            this.btnEnKucuk.UseVisualStyleBackColor = true;
            this.btnEnKucuk.Click += new System.EventHandler(this.btnEnKucuk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(504, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Toplam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(504, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ortalama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(504, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "En Büyük";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(504, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "En Küçük";
            // 
            // labEnKucuk
            // 
            this.labEnKucuk.AutoSize = true;
            this.labEnKucuk.BackColor = System.Drawing.Color.LightCoral;
            this.labEnKucuk.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labEnKucuk.Location = new System.Drawing.Point(617, 181);
            this.labEnKucuk.Name = "labEnKucuk";
            this.labEnKucuk.Size = new System.Drawing.Size(21, 24);
            this.labEnKucuk.TabIndex = 12;
            this.labEnKucuk.Text = "0";
            // 
            // labEnbuyuk
            // 
            this.labEnbuyuk.AutoSize = true;
            this.labEnbuyuk.BackColor = System.Drawing.Color.Aqua;
            this.labEnbuyuk.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labEnbuyuk.Location = new System.Drawing.Point(617, 145);
            this.labEnbuyuk.Name = "labEnbuyuk";
            this.labEnbuyuk.Size = new System.Drawing.Size(21, 24);
            this.labEnbuyuk.TabIndex = 11;
            this.labEnbuyuk.Text = "0";
            // 
            // labOrtalama
            // 
            this.labOrtalama.AutoSize = true;
            this.labOrtalama.BackColor = System.Drawing.Color.LawnGreen;
            this.labOrtalama.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labOrtalama.Location = new System.Drawing.Point(617, 111);
            this.labOrtalama.Name = "labOrtalama";
            this.labOrtalama.Size = new System.Drawing.Size(21, 24);
            this.labOrtalama.TabIndex = 10;
            this.labOrtalama.Text = "0";
            // 
            // labToplam
            // 
            this.labToplam.AutoSize = true;
            this.labToplam.BackColor = System.Drawing.Color.Yellow;
            this.labToplam.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labToplam.Location = new System.Drawing.Point(617, 72);
            this.labToplam.Name = "labToplam";
            this.labToplam.Size = new System.Drawing.Size(21, 24);
            this.labToplam.TabIndex = 9;
            this.labToplam.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.labEnKucuk);
            this.Controls.Add(this.labEnbuyuk);
            this.Controls.Add(this.labOrtalama);
            this.Controls.Add(this.labToplam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnKucuk);
            this.Controls.Add(this.btnOrtalama);
            this.Controls.Add(this.btnEnbuyuk);
            this.Controls.Add(this.btnToplam);
            this.Controls.Add(this.lbSayilar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSayilar;
        private System.Windows.Forms.Button btnToplam;
        private System.Windows.Forms.Button btnEnbuyuk;
        private System.Windows.Forms.Button btnOrtalama;
        private System.Windows.Forms.Button btnEnKucuk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labEnKucuk;
        private System.Windows.Forms.Label labEnbuyuk;
        private System.Windows.Forms.Label labOrtalama;
        private System.Windows.Forms.Label labToplam;
    }
}

