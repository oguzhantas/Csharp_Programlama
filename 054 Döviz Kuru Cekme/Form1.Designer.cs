namespace _054_Döviz_Kuru_Cekme
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
            this.components = new System.ComponentModel.Container();
            this.btnDovizCek = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSterlin = new System.Windows.Forms.Label();
            this.lbEuro = new System.Windows.Forms.Label();
            this.lbDolar = new System.Windows.Forms.Label();
            this.lbAltin = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labZaman = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDovizCek
            // 
            this.btnDovizCek.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDovizCek.Location = new System.Drawing.Point(580, 147);
            this.btnDovizCek.Name = "btnDovizCek";
            this.btnDovizCek.Size = new System.Drawing.Size(178, 36);
            this.btnDovizCek.TabIndex = 0;
            this.btnDovizCek.Text = "Döviz Kuru Çek";
            this.btnDovizCek.UseVisualStyleBackColor = true;
            this.btnDovizCek.Click += new System.EventHandler(this.btnDovizCek_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(589, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dolar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(589, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Euro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(589, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sterlin";
            // 
            // lbSterlin
            // 
            this.lbSterlin.AutoSize = true;
            this.lbSterlin.Location = new System.Drawing.Point(659, 86);
            this.lbSterlin.Name = "lbSterlin";
            this.lbSterlin.Size = new System.Drawing.Size(14, 16);
            this.lbSterlin.TabIndex = 6;
            this.lbSterlin.Text = "0";
            // 
            // lbEuro
            // 
            this.lbEuro.AutoSize = true;
            this.lbEuro.Location = new System.Drawing.Point(659, 54);
            this.lbEuro.Name = "lbEuro";
            this.lbEuro.Size = new System.Drawing.Size(14, 16);
            this.lbEuro.TabIndex = 5;
            this.lbEuro.Text = "0";
            // 
            // lbDolar
            // 
            this.lbDolar.AutoSize = true;
            this.lbDolar.Location = new System.Drawing.Point(659, 24);
            this.lbDolar.Name = "lbDolar";
            this.lbDolar.Size = new System.Drawing.Size(14, 16);
            this.lbDolar.TabIndex = 4;
            this.lbDolar.Text = "0";
            // 
            // lbAltin
            // 
            this.lbAltin.AutoSize = true;
            this.lbAltin.Location = new System.Drawing.Point(659, 116);
            this.lbAltin.Name = "lbAltin";
            this.lbAltin.Size = new System.Drawing.Size(14, 16);
            this.lbAltin.TabIndex = 8;
            this.lbAltin.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(589, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Altın";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labZaman
            // 
            this.labZaman.AutoSize = true;
            this.labZaman.Location = new System.Drawing.Point(605, 405);
            this.labZaman.Name = "labZaman";
            this.labZaman.Size = new System.Drawing.Size(0, 16);
            this.labZaman.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labZaman);
            this.Controls.Add(this.lbAltin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbSterlin);
            this.Controls.Add(this.lbEuro);
            this.Controls.Add(this.lbDolar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDovizCek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDovizCek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbSterlin;
        private System.Windows.Forms.Label lbEuro;
        private System.Windows.Forms.Label lbDolar;
        private System.Windows.Forms.Label lbAltin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labZaman;
    }
}

