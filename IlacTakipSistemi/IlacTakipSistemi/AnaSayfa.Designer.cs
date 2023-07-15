namespace IlacTakipSistemi
{
    partial class AnaSayfa
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
            lblSetCinsiyet = new System.Windows.Forms.Label();
            lblSetAge = new System.Windows.Forms.Label();
            lblCinsiyet = new System.Windows.Forms.Label();
            lblSetAdSoyad = new System.Windows.Forms.Label();
            lblSetTcNo = new System.Windows.Forms.Label();
            lblYas = new System.Windows.Forms.Label();
            lblAdSoyad = new System.Windows.Forms.Label();
            lblTcNo = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            btnIlacSil = new System.Windows.Forms.Button();
            btnIlacEkle = new System.Windows.Forms.Button();
            btnIlacAl = new System.Windows.Forms.Button();
            cmbxIlac = new System.Windows.Forms.ComboBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            ilacBilgiView = new System.Windows.Forms.DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ilacBilgiView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.OldLace;
            groupBox1.Controls.Add(lblSetCinsiyet);
            groupBox1.Controls.Add(lblSetAge);
            groupBox1.Controls.Add(lblCinsiyet);
            groupBox1.Controls.Add(lblSetAdSoyad);
            groupBox1.Controls.Add(lblSetTcNo);
            groupBox1.Controls.Add(lblYas);
            groupBox1.Controls.Add(lblAdSoyad);
            groupBox1.Controls.Add(lblTcNo);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(214, 157);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kullanıcı Bilgileri";
            // 
            // lblSetCinsiyet
            // 
            lblSetCinsiyet.AutoSize = true;
            lblSetCinsiyet.Location = new System.Drawing.Point(115, 124);
            lblSetCinsiyet.Name = "lblSetCinsiyet";
            lblSetCinsiyet.Size = new System.Drawing.Size(0, 15);
            lblSetCinsiyet.TabIndex = 7;
            // 
            // lblSetAge
            // 
            lblSetAge.AutoSize = true;
            lblSetAge.Location = new System.Drawing.Point(115, 92);
            lblSetAge.Name = "lblSetAge";
            lblSetAge.Size = new System.Drawing.Size(0, 15);
            lblSetAge.TabIndex = 6;
            // 
            // lblCinsiyet
            // 
            lblCinsiyet.AutoSize = true;
            lblCinsiyet.Location = new System.Drawing.Point(21, 124);
            lblCinsiyet.Name = "lblCinsiyet";
            lblCinsiyet.Size = new System.Drawing.Size(49, 15);
            lblCinsiyet.TabIndex = 5;
            lblCinsiyet.Text = "Cinsiyet";
            // 
            // lblSetAdSoyad
            // 
            lblSetAdSoyad.AutoSize = true;
            lblSetAdSoyad.Location = new System.Drawing.Point(115, 60);
            lblSetAdSoyad.Name = "lblSetAdSoyad";
            lblSetAdSoyad.Size = new System.Drawing.Size(0, 15);
            lblSetAdSoyad.TabIndex = 4;
            // 
            // lblSetTcNo
            // 
            lblSetTcNo.AutoSize = true;
            lblSetTcNo.Location = new System.Drawing.Point(115, 32);
            lblSetTcNo.Name = "lblSetTcNo";
            lblSetTcNo.Size = new System.Drawing.Size(0, 15);
            lblSetTcNo.TabIndex = 3;
            // 
            // lblYas
            // 
            lblYas.AutoSize = true;
            lblYas.Location = new System.Drawing.Point(21, 92);
            lblYas.Name = "lblYas";
            lblYas.Size = new System.Drawing.Size(24, 15);
            lblYas.TabIndex = 2;
            lblYas.Text = "Yaş";
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Location = new System.Drawing.Point(21, 60);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new System.Drawing.Size(57, 15);
            lblAdSoyad.TabIndex = 1;
            lblAdSoyad.Text = "Ad Soyad";
            // 
            // lblTcNo
            // 
            lblTcNo.AutoSize = true;
            lblTcNo.Location = new System.Drawing.Point(21, 31);
            lblTcNo.Name = "lblTcNo";
            lblTcNo.Size = new System.Drawing.Size(27, 15);
            lblTcNo.TabIndex = 0;
            lblTcNo.Text = "T.C.";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = System.Drawing.Color.OldLace;
            groupBox2.Controls.Add(btnIlacSil);
            groupBox2.Controls.Add(btnIlacEkle);
            groupBox2.Controls.Add(btnIlacAl);
            groupBox2.Controls.Add(cmbxIlac);
            groupBox2.Location = new System.Drawing.Point(257, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(233, 157);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "İlaç Al";
            // 
            // btnIlacSil
            // 
            btnIlacSil.Location = new System.Drawing.Point(79, 116);
            btnIlacSil.Name = "btnIlacSil";
            btnIlacSil.Size = new System.Drawing.Size(75, 23);
            btnIlacSil.TabIndex = 3;
            btnIlacSil.Text = "İlaç Sil";
            btnIlacSil.UseVisualStyleBackColor = true;
            btnIlacSil.Click += btnIlacSil_Click;
            // 
            // btnIlacEkle
            // 
            btnIlacEkle.Location = new System.Drawing.Point(128, 84);
            btnIlacEkle.Name = "btnIlacEkle";
            btnIlacEkle.Size = new System.Drawing.Size(75, 23);
            btnIlacEkle.TabIndex = 2;
            btnIlacEkle.Text = "İlaç Ekle";
            btnIlacEkle.UseVisualStyleBackColor = true;
            btnIlacEkle.Click += btnIlacEkle_Click;
            // 
            // btnIlacAl
            // 
            btnIlacAl.Location = new System.Drawing.Point(35, 84);
            btnIlacAl.Name = "btnIlacAl";
            btnIlacAl.Size = new System.Drawing.Size(75, 23);
            btnIlacAl.TabIndex = 1;
            btnIlacAl.Text = "İlaç Al";
            btnIlacAl.UseVisualStyleBackColor = true;
            btnIlacAl.Click += btnIlacAl_Click;
            // 
            // cmbxIlac
            // 
            cmbxIlac.FormattingEnabled = true;
            cmbxIlac.Location = new System.Drawing.Point(60, 52);
            cmbxIlac.Name = "cmbxIlac";
            cmbxIlac.Size = new System.Drawing.Size(121, 23);
            cmbxIlac.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = System.Drawing.Color.OldLace;
            groupBox3.Controls.Add(ilacBilgiView);
            groupBox3.Location = new System.Drawing.Point(12, 175);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(478, 134);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Günlük İlaç Bilgi";
            // 
            // ilacBilgiView
            // 
            ilacBilgiView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ilacBilgiView.Location = new System.Drawing.Point(6, 22);
            ilacBilgiView.Name = "ilacBilgiView";
            ilacBilgiView.RowTemplate.Height = 25;
            ilacBilgiView.Size = new System.Drawing.Size(466, 89);
            ilacBilgiView.TabIndex = 0;
            // 
            // AnaSayfa
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            ClientSize = new System.Drawing.Size(506, 321);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "AnaSayfa";
            Text = "AnaSayfa";
            Load += AnaSayfa_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ilacBilgiView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSetCinsiyet;
        private System.Windows.Forms.Label lblSetAge;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lblSetAdSoyad;
        private System.Windows.Forms.Label lblSetTcNo;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblTcNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnIlacEkle;
        private System.Windows.Forms.Button btnIlacAl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView ilacBilgiView;
        private System.Windows.Forms.Button btnIlacSil;
        public System.Windows.Forms.ComboBox cmbxIlac;
    }
}