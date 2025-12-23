namespace OgrKayitApp.Forms
{
    partial class MenuForm
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
            lblKullaniciBilgi = new Label();
            btnSinifIslemleri = new Button();
            btnOgrenciIslemleri = new Button();
            btnListeleme = new Button();
            SuspendLayout();
            // 
            // lblKullaniciBilgi
            // 
            lblKullaniciBilgi.AutoSize = true;
            lblKullaniciBilgi.Location = new Point(349, 25);
            lblKullaniciBilgi.Name = "lblKullaniciBilgi";
            lblKullaniciBilgi.Size = new Size(97, 20);
            lblKullaniciBilgi.TabIndex = 0;
            lblKullaniciBilgi.Text = "Hoşgeldiniz...";
            // 
            // btnSinifIslemleri
            // 
            btnSinifIslemleri.Location = new Point(271, 61);
            btnSinifIslemleri.Name = "btnSinifIslemleri";
            btnSinifIslemleri.Size = new Size(232, 28);
            btnSinifIslemleri.TabIndex = 1;
            btnSinifIslemleri.Text = "SINIF KAYIT İŞLEMLERİ";
            btnSinifIslemleri.UseVisualStyleBackColor = true;
            btnSinifIslemleri.Click += btnSinifIslemleri_Click;
            // 
            // btnOgrenciIslemleri
            // 
            btnOgrenciIslemleri.Location = new Point(271, 109);
            btnOgrenciIslemleri.Name = "btnOgrenciIslemleri";
            btnOgrenciIslemleri.Size = new Size(232, 28);
            btnOgrenciIslemleri.TabIndex = 2;
            btnOgrenciIslemleri.Text = "ÖĞRENCİ KAYIT İŞLEMLERİ";
            btnOgrenciIslemleri.UseVisualStyleBackColor = true;
            btnOgrenciIslemleri.Click += btnOgrenciIslemleri_Click;
            // 
            // btnListeleme
            // 
            btnListeleme.Location = new Point(271, 156);
            btnListeleme.Name = "btnListeleme";
            btnListeleme.Size = new Size(232, 28);
            btnListeleme.TabIndex = 3;
            btnListeleme.Text = "ÖĞRENCİ LİSTELEME";
            btnListeleme.UseVisualStyleBackColor = true;
            btnListeleme.Click += btnListeleme_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnListeleme);
            Controls.Add(btnOgrenciIslemleri);
            Controls.Add(btnSinifIslemleri);
            Controls.Add(lblKullaniciBilgi);
            Name = "MenuForm";
            Text = "MenuForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKullaniciBilgi;
        private Button btnSinifIslemleri;
        private Button btnOgrenciIslemleri;
        private Button btnListeleme;
    }
}