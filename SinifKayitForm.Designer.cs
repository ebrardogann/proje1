namespace OgrKayitApp.Forms
{
    partial class SinifKayitForm
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
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            txtSinifAdi = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(169, 51);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(68, 20);
            lblAd.TabIndex = 0;
            lblAd.Text = "Sınıf Adı:";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(404, 12);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(90, 28);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(404, 67);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(90, 28);
            btnGuncelle.TabIndex = 2;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(404, 122);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(90, 28);
            btnSil.TabIndex = 3;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // txtSinifAdi
            // 
            txtSinifAdi.Location = new Point(243, 48);
            txtSinifAdi.Name = "txtSinifAdi";
            txtSinifAdi.Size = new Size(120, 26);
            txtSinifAdi.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(206, 234);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 49;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(288, 180);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // SinifKayitForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(txtSinifAdi);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(lblAd);
            Name = "SinifKayitForm";
            Text = "SinifKayitForm";
            Load += SinifKayitForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAd;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private TextBox txtSinifAdi;
        private DataGridView dataGridView1;
    }
}