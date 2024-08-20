namespace _042_Foreach_Döngüsü
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
            this.lbMeyveler = new System.Windows.Forms.ListBox();
            this.btnYaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMeyveler
            // 
            this.lbMeyveler.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbMeyveler.FormattingEnabled = true;
            this.lbMeyveler.ItemHeight = 24;
            this.lbMeyveler.Items.AddRange(new object[] {
            "elma",
            "armut",
            "şeftali",
            "çilek",
            "muz",
            "kiraz"});
            this.lbMeyveler.Location = new System.Drawing.Point(89, 69);
            this.lbMeyveler.Name = "lbMeyveler";
            this.lbMeyveler.Size = new System.Drawing.Size(176, 196);
            this.lbMeyveler.TabIndex = 0;
            // 
            // btnYaz
            // 
            this.btnYaz.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYaz.Location = new System.Drawing.Point(289, 133);
            this.btnYaz.Name = "btnYaz";
            this.btnYaz.Size = new System.Drawing.Size(121, 46);
            this.btnYaz.TabIndex = 1;
            this.btnYaz.Text = "Ekrana yaz";
            this.btnYaz.UseVisualStyleBackColor = true;
            this.btnYaz.Click += new System.EventHandler(this.btnYaz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnYaz);
            this.Controls.Add(this.lbMeyveler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbMeyveler;
        private System.Windows.Forms.Button btnYaz;
    }
}

