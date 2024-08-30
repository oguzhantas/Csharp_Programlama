namespace _056_Metotla_Rasgele_Şifre_Üretme
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
            this.lbSifreler = new System.Windows.Forms.ListBox();
            this.btnUret = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKucukHarf = new System.Windows.Forms.TextBox();
            this.txtBuyukHarf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRakam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSembol = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbSifreler
            // 
            this.lbSifreler.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSifreler.FormattingEnabled = true;
            this.lbSifreler.ItemHeight = 24;
            this.lbSifreler.Location = new System.Drawing.Point(514, 35);
            this.lbSifreler.Name = "lbSifreler";
            this.lbSifreler.Size = new System.Drawing.Size(372, 292);
            this.lbSifreler.TabIndex = 0;
            // 
            // btnUret
            // 
            this.btnUret.BackColor = System.Drawing.Color.Bisque;
            this.btnUret.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUret.Location = new System.Drawing.Point(112, 200);
            this.btnUret.Name = "btnUret";
            this.btnUret.Size = new System.Drawing.Size(372, 56);
            this.btnUret.TabIndex = 1;
            this.btnUret.Text = "Rastgele Şifre Üret";
            this.btnUret.UseVisualStyleBackColor = false;
            this.btnUret.Click += new System.EventHandler(this.btnUret_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Küçük Harf(Adet)";
            // 
            // txtKucukHarf
            // 
            this.txtKucukHarf.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKucukHarf.Location = new System.Drawing.Point(308, 37);
            this.txtKucukHarf.Name = "txtKucukHarf";
            this.txtKucukHarf.Size = new System.Drawing.Size(100, 32);
            this.txtKucukHarf.TabIndex = 3;
            // 
            // txtBuyukHarf
            // 
            this.txtBuyukHarf.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuyukHarf.Location = new System.Drawing.Point(308, 75);
            this.txtBuyukHarf.Name = "txtBuyukHarf";
            this.txtBuyukHarf.Size = new System.Drawing.Size(100, 32);
            this.txtBuyukHarf.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Büyük Harf(Adet)";
            // 
            // txtRakam
            // 
            this.txtRakam.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRakam.Location = new System.Drawing.Point(308, 113);
            this.txtRakam.Name = "txtRakam";
            this.txtRakam.Size = new System.Drawing.Size(100, 32);
            this.txtRakam.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rakam(Adet)";
            // 
            // txtSembol
            // 
            this.txtSembol.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSembol.Location = new System.Drawing.Point(308, 151);
            this.txtSembol.Name = "txtSembol";
            this.txtSembol.Size = new System.Drawing.Size(100, 32);
            this.txtSembol.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sembol(Adet)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 356);
            this.Controls.Add(this.txtSembol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRakam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBuyukHarf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKucukHarf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUret);
            this.Controls.Add(this.lbSifreler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSifreler;
        private System.Windows.Forms.Button btnUret;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKucukHarf;
        private System.Windows.Forms.TextBox txtBuyukHarf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRakam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSembol;
        private System.Windows.Forms.Label label4;
    }
}

