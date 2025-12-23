namespace OgrKayitApp.Forms
{
    partial class OgrenciKayitForm
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
            lblAd = new Label();
            lblSoyad = new Label();
            lblNo = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtNumara = new TextBox();
            lblSinif = new Label();
            cbSiniflar = new ComboBox();
            btnEkle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(86, 27);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(31, 20);
            lblAd.TabIndex = 0;
            lblAd.Text = "Ad:";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(86, 77);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(53, 20);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "Soyad:";
            // 
            // lblNo
            // 
            lblNo.AutoSize = true;
            lblNo.Location = new Point(86, 125);
            lblNo.Name = "lblNo";
            lblNo.Size = new Size(65, 20);
            lblNo.TabIndex = 2;
            lblNo.Text = "Numara:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(181, 27);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(120, 26);
            txtAd.TabIndex = 3;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(181, 77);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(120, 26);
            txtSoyad.TabIndex = 4;
            // 
            // txtNumara
            // 
            txtNumara.Location = new Point(181, 122);
            txtNumara.Name = "txtNumara";
            txtNumara.Size = new Size(120, 26);
            txtNumara.TabIndex = 5;
            // 
            // lblSinif
            // 
            lblSinif.AutoSize = true;
            lblSinif.Location = new Point(86, 181);
            lblSinif.Name = "lblSinif";
            lblSinif.Size = new Size(89, 20);
            lblSinif.TabIndex = 6;
            lblSinif.Text = "Sınıf Seçimi:";
            // 
            // cbSiniflar
            // 
            cbSiniflar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSiniflar.FormattingEnabled = true;
            cbSiniflar.Location = new Point(181, 181);
            cbSiniflar.Name = "cbSiniflar";
            cbSiniflar.Size = new Size(145, 27);
            cbSiniflar.TabIndex = 7;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(374, 27);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(90, 28);
            btnEkle.TabIndex = 8;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(374, 77);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(90, 28);
            btnSil.TabIndex = 9;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(374, 125);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(90, 28);
            btnGuncelle.TabIndex = 10;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(480, 233);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 49;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(288, 180);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // OgrenciKayitForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(cbSiniflar);
            Controls.Add(lblSinif);
            Controls.Add(txtNumara);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(lblNo);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            Name = "OgrenciKayitForm";
            Text = "OgrenciKayitForm";
            Load += OgrenciKayitForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAd;
        private Label lblSoyad;
        private Label lblNo;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtNumara;
        private Label lblSinif;
        private ComboBox cbSiniflar;
        private Button btnEkle;
        private Button btnSil;
        private Button btnGuncelle;
        private DataGridView dataGridView1;
    }
}