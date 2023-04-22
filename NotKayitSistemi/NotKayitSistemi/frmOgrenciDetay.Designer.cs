namespace NotKayitSistemi
{
    partial class frmOgrenciDetay
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
            label1 = new Label();
            lblAdSoyad = new Label();
            label3 = new Label();
            lblNumara = new Label();
            label5 = new Label();
            lblSinav1 = new Label();
            label7 = new Label();
            lblSinav2 = new Label();
            label9 = new Label();
            lblSinav3 = new Label();
            label11 = new Label();
            lblOrtalama = new Label();
            label13 = new Label();
            lblDurum = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 26);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad:";
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Location = new Point(119, 26);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(44, 20);
            lblAdSoyad.TabIndex = 1;
            lblAdSoyad.Text = "NULL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 67);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 2;
            label3.Text = "Numara:";
            // 
            // lblNumara
            // 
            lblNumara.AutoSize = true;
            lblNumara.Location = new Point(119, 67);
            lblNumara.Name = "lblNumara";
            lblNumara.Size = new Size(41, 20);
            lblNumara.TabIndex = 3;
            lblNumara.Text = "0000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 145);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 4;
            label5.Text = "Sınav1";
            // 
            // lblSinav1
            // 
            lblSinav1.AutoSize = true;
            lblSinav1.Location = new Point(119, 145);
            lblSinav1.Name = "lblSinav1";
            lblSinav1.Size = new Size(25, 20);
            lblSinav1.TabIndex = 5;
            lblSinav1.Text = "00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 177);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 6;
            label7.Text = "Sınav2";
            // 
            // lblSinav2
            // 
            lblSinav2.AutoSize = true;
            lblSinav2.Location = new Point(119, 177);
            lblSinav2.Name = "lblSinav2";
            lblSinav2.Size = new Size(25, 20);
            lblSinav2.TabIndex = 7;
            lblSinav2.Text = "00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(32, 214);
            label9.Name = "label9";
            label9.Size = new Size(52, 20);
            label9.TabIndex = 8;
            label9.Text = "Sınav3";
            // 
            // lblSinav3
            // 
            lblSinav3.AutoSize = true;
            lblSinav3.Location = new Point(119, 214);
            lblSinav3.Name = "lblSinav3";
            lblSinav3.Size = new Size(25, 20);
            lblSinav3.TabIndex = 9;
            lblSinav3.Text = "00";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(24, 257);
            label11.Name = "label11";
            label11.Size = new Size(71, 20);
            label11.TabIndex = 10;
            label11.Text = "Ortalama";
            // 
            // lblOrtalama
            // 
            lblOrtalama.AutoSize = true;
            lblOrtalama.Location = new Point(119, 257);
            lblOrtalama.Name = "lblOrtalama";
            lblOrtalama.Size = new Size(25, 20);
            lblOrtalama.TabIndex = 11;
            lblOrtalama.Text = "00";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(24, 293);
            label13.Name = "label13";
            label13.Size = new Size(54, 20);
            label13.TabIndex = 12;
            label13.Text = "Durum";
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Location = new Point(119, 293);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(44, 20);
            lblDurum.TabIndex = 13;
            lblDurum.Text = "NULL";
            // 
            // frmOgrenciDetay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 450);
            Controls.Add(lblDurum);
            Controls.Add(label13);
            Controls.Add(lblOrtalama);
            Controls.Add(label11);
            Controls.Add(lblSinav3);
            Controls.Add(label9);
            Controls.Add(lblSinav2);
            Controls.Add(label7);
            Controls.Add(lblSinav1);
            Controls.Add(label5);
            Controls.Add(lblNumara);
            Controls.Add(label3);
            Controls.Add(lblAdSoyad);
            Controls.Add(label1);
            Name = "frmOgrenciDetay";
            Text = "frmOgrenciDetay";
            Load += frmOgrenciDetay_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblAdSoyad;
        private Label label3;
        private Label lblNumara;
        private Label label5;
        private Label lblSinav1;
        private Label label7;
        private Label lblSinav2;
        private Label label9;
        private Label lblSinav3;
        private Label label11;
        private Label lblOrtalama;
        private Label label13;
        private Label lblDurum;
    }
}