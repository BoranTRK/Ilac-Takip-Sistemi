namespace IlacTakipSistemi
{
    partial class Form1
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
            lblKullaniciKodu = new System.Windows.Forms.Label();
            txtKullaniciKodu = new System.Windows.Forms.TextBox();
            btnGirisYap = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblKullaniciKodu
            // 
            lblKullaniciKodu.AutoSize = true;
            lblKullaniciKodu.Location = new System.Drawing.Point(32, 33);
            lblKullaniciKodu.Name = "lblKullaniciKodu";
            lblKullaniciKodu.Size = new System.Drawing.Size(83, 15);
            lblKullaniciKodu.TabIndex = 0;
            lblKullaniciKodu.Text = "Kullanıcı Kodu";
            // 
            // txtKullaniciKodu
            // 
            txtKullaniciKodu.Location = new System.Drawing.Point(131, 30);
            txtKullaniciKodu.Name = "txtKullaniciKodu";
            txtKullaniciKodu.Size = new System.Drawing.Size(169, 23);
            txtKullaniciKodu.TabIndex = 1;
            // 
            // btnGirisYap
            // 
            btnGirisYap.Location = new System.Drawing.Point(178, 59);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new System.Drawing.Size(75, 23);
            btnGirisYap.TabIndex = 2;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(364, 94);
            Controls.Add(btnGirisYap);
            Controls.Add(txtKullaniciKodu);
            Controls.Add(lblKullaniciKodu);
            Name = "Form1";
            Text = "İlaç Takip Sistemine Hoş Geldiniz";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblKullaniciKodu;
        private System.Windows.Forms.TextBox txtKullaniciKodu;
        private System.Windows.Forms.Button btnGirisYap;
    }
}
