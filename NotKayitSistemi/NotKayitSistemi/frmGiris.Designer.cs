namespace NotKayitSistemi
{
    partial class frmGiris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGirisYap = new Button();
            maskedTextBox1 = new MaskedTextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnGirisYap
            // 
            btnGirisYap.Location = new Point(166, 143);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(94, 29);
            btnGirisYap.TabIndex = 5;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click_1;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(207, 73);
            maskedTextBox1.Mask = "0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 27);
            maskedTextBox1.TabIndex = 4;
            maskedTextBox1.ValidatingType = typeof(int);
            maskedTextBox1.TextChanged += maskedTextBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 80);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 3;
            label1.Text = "Öğrenci Numara:";
            // 
            // frmGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 255);
            Controls.Add(btnGirisYap);
            Controls.Add(maskedTextBox1);
            Controls.Add(label1);
            Name = "frmGiris";
            Text = "Sistem Girişi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGirisYap;
        private MaskedTextBox maskedTextBox1;
        private Label label1;
    }
}