namespace _51_Faktoriyel_Form
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
            this.rbFaktoriyel = new System.Windows.Forms.RadioButton();
            this.rbKombinasyon = new System.Windows.Forms.RadioButton();
            this.rbPermutasyon = new System.Windows.Forms.RadioButton();
            this.txtN = new System.Windows.Forms.TextBox();
            this.labN = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.labR = new System.Windows.Forms.Label();
            this.txtR = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rbFaktoriyel
            // 
            this.rbFaktoriyel.AutoSize = true;
            this.rbFaktoriyel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbFaktoriyel.Location = new System.Drawing.Point(131, 90);
            this.rbFaktoriyel.Name = "rbFaktoriyel";
            this.rbFaktoriyel.Size = new System.Drawing.Size(118, 28);
            this.rbFaktoriyel.TabIndex = 0;
            this.rbFaktoriyel.TabStop = true;
            this.rbFaktoriyel.Text = "Faktöriyel";
            this.rbFaktoriyel.UseVisualStyleBackColor = true;
            this.rbFaktoriyel.CheckedChanged += new System.EventHandler(this.rbFaktoriyel_CheckedChanged);
            // 
            // rbKombinasyon
            // 
            this.rbKombinasyon.AutoSize = true;
            this.rbKombinasyon.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbKombinasyon.Location = new System.Drawing.Point(131, 136);
            this.rbKombinasyon.Name = "rbKombinasyon";
            this.rbKombinasyon.Size = new System.Drawing.Size(150, 28);
            this.rbKombinasyon.TabIndex = 1;
            this.rbKombinasyon.TabStop = true;
            this.rbKombinasyon.Text = "Kombinasyon";
            this.rbKombinasyon.UseVisualStyleBackColor = true;
            this.rbKombinasyon.CheckedChanged += new System.EventHandler(this.rbKombinasyon_CheckedChanged);
            // 
            // rbPermutasyon
            // 
            this.rbPermutasyon.AutoSize = true;
            this.rbPermutasyon.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPermutasyon.Location = new System.Drawing.Point(131, 181);
            this.rbPermutasyon.Name = "rbPermutasyon";
            this.rbPermutasyon.Size = new System.Drawing.Size(147, 28);
            this.rbPermutasyon.TabIndex = 2;
            this.rbPermutasyon.TabStop = true;
            this.rbPermutasyon.Text = "Permutasyon";
            this.rbPermutasyon.UseVisualStyleBackColor = true;
            this.rbPermutasyon.CheckedChanged += new System.EventHandler(this.rbPermutasyon_CheckedChanged);
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtN.Location = new System.Drawing.Point(466, 82);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(173, 32);
            this.txtN.TabIndex = 3;
            // 
            // labN
            // 
            this.labN.AutoSize = true;
            this.labN.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labN.Location = new System.Drawing.Point(349, 90);
            this.labN.Name = "labN";
            this.labN.Size = new System.Drawing.Size(80, 24);
            this.labN.TabIndex = 4;
            this.labN.Text = "Sayı (n)";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(466, 181);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(173, 48);
            this.btnHesapla.TabIndex = 5;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // labR
            // 
            this.labR.AutoSize = true;
            this.labR.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labR.Location = new System.Drawing.Point(349, 128);
            this.labR.Name = "labR";
            this.labR.Size = new System.Drawing.Size(76, 24);
            this.labR.TabIndex = 7;
            this.labR.Text = "Sayı (r)";
            // 
            // txtR
            // 
            this.txtR.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtR.Location = new System.Drawing.Point(466, 128);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(173, 32);
            this.txtR.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labR);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.labN);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.rbPermutasyon);
            this.Controls.Add(this.rbKombinasyon);
            this.Controls.Add(this.rbFaktoriyel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbFaktoriyel;
        private System.Windows.Forms.RadioButton rbKombinasyon;
        private System.Windows.Forms.RadioButton rbPermutasyon;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label labN;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label labR;
        private System.Windows.Forms.TextBox txtR;
    }
}

