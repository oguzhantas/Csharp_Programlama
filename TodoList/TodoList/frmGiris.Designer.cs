namespace TodoList
{
    partial class frmGiris
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtKullanici = new System.Windows.Forms.TextBox();
            txtSifre = new System.Windows.Forms.TextBox();
            btnGiris = new System.Windows.Forms.Button();
            btnIptal = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(106, 26);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(161, 25);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Girişi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(52, 80);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(83, 16);
            label2.TabIndex = 1;
            label2.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(56, 115);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(37, 16);
            label3.TabIndex = 2;
            label3.Text = "Şifre";
            // 
            // txtKullanici
            // 
            txtKullanici.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtKullanici.Location = new System.Drawing.Point(159, 77);
            txtKullanici.Name = "txtKullanici";
            txtKullanici.Size = new System.Drawing.Size(148, 23);
            txtKullanici.TabIndex = 3;
            // 
            // txtSifre
            // 
            txtSifre.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSifre.Location = new System.Drawing.Point(159, 108);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new System.Drawing.Size(148, 23);
            txtSifre.TabIndex = 4;
            // 
            // btnGiris
            // 
            btnGiris.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnGiris.Location = new System.Drawing.Point(159, 148);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new System.Drawing.Size(148, 27);
            btnGiris.TabIndex = 5;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // btnIptal
            // 
            btnIptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnIptal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnIptal.Location = new System.Drawing.Point(78, 148);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new System.Drawing.Size(75, 27);
            btnIptal.TabIndex = 6;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = true;
            btnIptal.Click += btnIptal_Click;
            // 
            // frmGiris
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(377, 205);
            Controls.Add(btnIptal);
            Controls.Add(btnGiris);
            Controls.Add(txtSifre);
            Controls.Add(txtKullanici);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmGiris";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Kullanıcı Girişi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnIptal;
    }
}