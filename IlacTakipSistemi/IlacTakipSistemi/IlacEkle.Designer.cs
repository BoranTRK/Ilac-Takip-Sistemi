namespace IlacTakipSistemi
{
    partial class IlacEkle
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
            groupBox1 = new System.Windows.Forms.GroupBox();
            cmbxIlacTuru = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            btnIlacEkle = new System.Windows.Forms.Button();
            cmbxGunlukAlim = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            txtIlacAdi = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbxIlacTuru);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnIlacEkle);
            groupBox1.Controls.Add(cmbxGunlukAlim);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtIlacAdi);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(256, 198);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "İlaç Ekle";
            // 
            // cmbxIlacTuru
            // 
            cmbxIlacTuru.FormattingEnabled = true;
            cmbxIlacTuru.Items.AddRange(new object[] { "Hap", "Krem", "Toz" });
            cmbxIlacTuru.Location = new System.Drawing.Point(116, 110);
            cmbxIlacTuru.Name = "cmbxIlacTuru";
            cmbxIlacTuru.Size = new System.Drawing.Size(106, 23);
            cmbxIlacTuru.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 113);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(47, 15);
            label3.TabIndex = 6;
            label3.Text = "İlaç Tipi";
            // 
            // btnIlacEkle
            // 
            btnIlacEkle.Location = new System.Drawing.Point(83, 156);
            btnIlacEkle.Name = "btnIlacEkle";
            btnIlacEkle.Size = new System.Drawing.Size(75, 23);
            btnIlacEkle.TabIndex = 5;
            btnIlacEkle.Text = "İlaç Ekle";
            btnIlacEkle.UseVisualStyleBackColor = true;
            btnIlacEkle.Click += btnIlacEkle_Click;
            // 
            // cmbxGunlukAlim
            // 
            cmbxGunlukAlim.FormattingEnabled = true;
            cmbxGunlukAlim.Items.AddRange(new object[] { "1", "2", "3", "4" });
            cmbxGunlukAlim.Location = new System.Drawing.Point(116, 69);
            cmbxGunlukAlim.Name = "cmbxGunlukAlim";
            cmbxGunlukAlim.Size = new System.Drawing.Size(106, 23);
            cmbxGunlukAlim.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 72);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(104, 15);
            label2.TabIndex = 2;
            label2.Text = "Günlük Alım Adeti";
            // 
            // txtIlacAdi
            // 
            txtIlacAdi.Location = new System.Drawing.Point(116, 30);
            txtIlacAdi.Name = "txtIlacAdi";
            txtIlacAdi.Size = new System.Drawing.Size(106, 23);
            txtIlacAdi.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 33);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "İlaç Adı";
            // 
            // IlacEkle
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(280, 222);
            Controls.Add(groupBox1);
            Name = "IlacEkle";
            Text = "IlacEkle";
            FormClosed += IlacEkle_FormClosed;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIlacAdi;
        private System.Windows.Forms.Button btnIlacEkle;
        private System.Windows.Forms.ComboBox cmbxGunlukAlim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbxIlacTuru;
        private System.Windows.Forms.Label label3;
    }
}