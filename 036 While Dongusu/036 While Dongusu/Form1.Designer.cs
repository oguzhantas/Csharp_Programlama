namespace _036_While_Dongusu
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
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnFor = new System.Windows.Forms.Button();
            this.btnDoWhile = new System.Windows.Forms.Button();
            this.btnDoWhileTek = new System.Windows.Forms.Button();
            this.btnForTek = new System.Windows.Forms.Button();
            this.btnWhileTek = new System.Windows.Forms.Button();
            this.btnDoWhileCift = new System.Windows.Forms.Button();
            this.btnForCift = new System.Windows.Forms.Button();
            this.btnCiftWhile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWhile
            // 
            this.btnWhile.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnWhile.Location = new System.Drawing.Point(129, 152);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(215, 41);
            this.btnWhile.TabIndex = 0;
            this.btnWhile.Text = "While (1-5 say)";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnFor
            // 
            this.btnFor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFor.Location = new System.Drawing.Point(350, 152);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(215, 41);
            this.btnFor.TabIndex = 1;
            this.btnFor.Text = "For (1-5 say)";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // btnDoWhile
            // 
            this.btnDoWhile.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoWhile.Location = new System.Drawing.Point(580, 152);
            this.btnDoWhile.Name = "btnDoWhile";
            this.btnDoWhile.Size = new System.Drawing.Size(215, 41);
            this.btnDoWhile.TabIndex = 2;
            this.btnDoWhile.Text = "Do While (1-5 say)";
            this.btnDoWhile.UseVisualStyleBackColor = true;
            this.btnDoWhile.Click += new System.EventHandler(this.btnDoWhile_Click);
            // 
            // btnDoWhileTek
            // 
            this.btnDoWhileTek.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoWhileTek.Location = new System.Drawing.Point(580, 209);
            this.btnDoWhileTek.Name = "btnDoWhileTek";
            this.btnDoWhileTek.Size = new System.Drawing.Size(215, 41);
            this.btnDoWhileTek.TabIndex = 5;
            this.btnDoWhileTek.Text = "Do While Tek (1-10 say)";
            this.btnDoWhileTek.UseVisualStyleBackColor = true;
            this.btnDoWhileTek.Click += new System.EventHandler(this.btnDoWhileTek_Click);
            // 
            // btnForTek
            // 
            this.btnForTek.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnForTek.Location = new System.Drawing.Point(350, 209);
            this.btnForTek.Name = "btnForTek";
            this.btnForTek.Size = new System.Drawing.Size(215, 41);
            this.btnForTek.TabIndex = 4;
            this.btnForTek.Text = "For Tek (1-10 say)";
            this.btnForTek.UseVisualStyleBackColor = true;
            this.btnForTek.Click += new System.EventHandler(this.btnForTek_Click);
            // 
            // btnWhileTek
            // 
            this.btnWhileTek.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnWhileTek.Location = new System.Drawing.Point(90, 209);
            this.btnWhileTek.Name = "btnWhileTek";
            this.btnWhileTek.Size = new System.Drawing.Size(254, 41);
            this.btnWhileTek.TabIndex = 3;
            this.btnWhileTek.Text = "While Tek Sayı (1-10 say)";
            this.btnWhileTek.UseVisualStyleBackColor = true;
            this.btnWhileTek.Click += new System.EventHandler(this.btnWhileTek_Click);
            // 
            // btnDoWhileCift
            // 
            this.btnDoWhileCift.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoWhileCift.Location = new System.Drawing.Point(580, 267);
            this.btnDoWhileCift.Name = "btnDoWhileCift";
            this.btnDoWhileCift.Size = new System.Drawing.Size(215, 41);
            this.btnDoWhileCift.TabIndex = 8;
            this.btnDoWhileCift.Text = "Do While Çift(1-10 say)";
            this.btnDoWhileCift.UseVisualStyleBackColor = true;
            this.btnDoWhileCift.Click += new System.EventHandler(this.btnDoWhileCift_Click);
            // 
            // btnForCift
            // 
            this.btnForCift.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnForCift.Location = new System.Drawing.Point(350, 267);
            this.btnForCift.Name = "btnForCift";
            this.btnForCift.Size = new System.Drawing.Size(215, 41);
            this.btnForCift.TabIndex = 7;
            this.btnForCift.Text = "For Çift (1-10 say)";
            this.btnForCift.UseVisualStyleBackColor = true;
            this.btnForCift.Click += new System.EventHandler(this.btnForCift_Click);
            // 
            // btnCiftWhile
            // 
            this.btnCiftWhile.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCiftWhile.Location = new System.Drawing.Point(90, 267);
            this.btnCiftWhile.Name = "btnCiftWhile";
            this.btnCiftWhile.Size = new System.Drawing.Size(254, 41);
            this.btnCiftWhile.TabIndex = 6;
            this.btnCiftWhile.Text = "While Çift Sayı (1-10 say)";
            this.btnCiftWhile.UseVisualStyleBackColor = true;
            this.btnCiftWhile.Click += new System.EventHandler(this.btnCiftWhile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 450);
            this.Controls.Add(this.btnDoWhileCift);
            this.Controls.Add(this.btnForCift);
            this.Controls.Add(this.btnCiftWhile);
            this.Controls.Add(this.btnDoWhileTek);
            this.Controls.Add(this.btnForTek);
            this.Controls.Add(this.btnWhileTek);
            this.Controls.Add(this.btnDoWhile);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.btnWhile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Button btnDoWhile;
        private System.Windows.Forms.Button btnDoWhileTek;
        private System.Windows.Forms.Button btnForTek;
        private System.Windows.Forms.Button btnWhileTek;
        private System.Windows.Forms.Button btnDoWhileCift;
        private System.Windows.Forms.Button btnForCift;
        private System.Windows.Forms.Button btnCiftWhile;
    }
}

