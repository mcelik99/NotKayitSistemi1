namespace NotKayitSistemi
{
    partial class FrmOgretmenDetay
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
            groupBox1 = new GroupBox();
            btnOgrenciKayit = new Button();
            label1 = new Label();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            txtMskNumara = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            btnGuncelle = new Button();
            label4 = new Label();
            txtSinav3 = new TextBox();
            txtSinav2 = new TextBox();
            txtsinav1 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            groupBox3 = new GroupBox();
            lblKalanSayisi = new Label();
            lblGecenSayisi = new Label();
            lblOrtalama = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnOgrenciKayit);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(txtMskNumara);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(283, 219);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ogrenci Ekle";
            // 
            // btnOgrenciKayit
            // 
            btnOgrenciKayit.Location = new Point(65, 148);
            btnOgrenciKayit.Name = "btnOgrenciKayit";
            btnOgrenciKayit.Size = new Size(154, 29);
            btnOgrenciKayit.TabIndex = 6;
            btnOgrenciKayit.Text = "Ogrenci Kaydet";
            btnOgrenciKayit.UseVisualStyleBackColor = true;
            btnOgrenciKayit.Click += btnOgrenciKayit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 37);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 0;
            label1.Text = "Numara:";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(115, 103);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(141, 27);
            txtSoyad.TabIndex = 5;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(115, 70);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(141, 27);
            txtAd.TabIndex = 4;
            // 
            // txtMskNumara
            // 
            txtMskNumara.Location = new Point(115, 37);
            txtMskNumara.Name = "txtMskNumara";
            txtMskNumara.Size = new Size(141, 27);
            txtMskNumara.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 106);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 2;
            label3.Text = "Soyad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 73);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 1;
            label2.Text = "Ad:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnGuncelle);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtSinav3);
            groupBox2.Controls.Add(txtSinav2);
            groupBox2.Controls.Add(txtsinav1);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(313, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(283, 219);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sinav Notlari ";
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(84, 148);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(121, 29);
            btnGuncelle.TabIndex = 6;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 37);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 0;
            label4.Text = "Sinav1";
            // 
            // txtSinav3
            // 
            txtSinav3.Location = new Point(115, 103);
            txtSinav3.Name = "txtSinav3";
            txtSinav3.Size = new Size(141, 27);
            txtSinav3.TabIndex = 5;
            // 
            // txtSinav2
            // 
            txtSinav2.Location = new Point(115, 70);
            txtSinav2.Name = "txtSinav2";
            txtSinav2.Size = new Size(141, 27);
            txtSinav2.TabIndex = 4;
            // 
            // txtsinav1
            // 
            txtsinav1.Location = new Point(115, 37);
            txtsinav1.Name = "txtsinav1";
            txtsinav1.Size = new Size(141, 27);
            txtsinav1.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 106);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 2;
            label5.Text = "Sinav3";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 73);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 1;
            label6.Text = "Sinav2";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblKalanSayisi);
            groupBox3.Controls.Add(lblGecenSayisi);
            groupBox3.Controls.Add(lblOrtalama);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(613, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(259, 219);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sinav Notlari ";
            // 
            // lblKalanSayisi
            // 
            lblKalanSayisi.AutoSize = true;
            lblKalanSayisi.Location = new Point(165, 106);
            lblKalanSayisi.Name = "lblKalanSayisi";
            lblKalanSayisi.Size = new Size(25, 20);
            lblKalanSayisi.TabIndex = 3;
            lblKalanSayisi.Text = "00";
            // 
            // lblGecenSayisi
            // 
            lblGecenSayisi.AutoSize = true;
            lblGecenSayisi.Location = new Point(165, 73);
            lblGecenSayisi.Name = "lblGecenSayisi";
            lblGecenSayisi.Size = new Size(25, 20);
            lblGecenSayisi.TabIndex = 3;
            lblGecenSayisi.Text = "00";
            // 
            // lblOrtalama
            // 
            lblOrtalama.AutoSize = true;
            lblOrtalama.Location = new Point(165, 37);
            lblOrtalama.Name = "lblOrtalama";
            lblOrtalama.Size = new Size(25, 20);
            lblOrtalama.TabIndex = 3;
            lblOrtalama.Text = "00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(53, 37);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 0;
            label7.Text = "Ortalama:";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(41, 106);
            label8.Name = "label8";
            label8.Size = new Size(86, 20);
            label8.TabIndex = 2;
            label8.Text = "KalanSayisi:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(41, 73);
            label9.Name = "label9";
            label9.Size = new Size(90, 20);
            label9.TabIndex = 1;
            label9.Text = "GecenSayisi:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(12, 248);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(860, 280);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "groupBox4";
            groupBox4.Enter += groupBox4_Enter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(854, 254);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // FrmOgretmenDetay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 520);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmOgretmenDetay";
            Text = "FrmOgretmenDetay";
            Load += FrmOgretmenDetay_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnOgrenciKayit;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private TextBox txtMskNumara;
        private GroupBox groupBox2;
        private Button btnGuncelle;
        private Label label4;
        private TextBox txtSinav3;
        private TextBox txtSinav2;
        private TextBox txtsinav1;
        private Label label5;
        private Label label6;
        private GroupBox groupBox3;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label lblKalanSayisi;
        private Label lblGecenSayisi;
        private Label lblOrtalama;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
    }
}