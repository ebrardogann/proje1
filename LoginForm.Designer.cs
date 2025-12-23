namespace OgrKayitApp.Forms
{
    partial class LoginForm
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
            btnGiris = new Button();
            lblKullanici = new Label();
            lblSifre = new Label();
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            SuspendLayout();
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(386, 203);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(90, 28);
            btnGiris.TabIndex = 0;
            btnGiris.Text = "GİRİŞ YAP";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // lblKullanici
            // 
            lblKullanici.AutoSize = true;
            lblKullanici.Location = new Point(274, 122);
            lblKullanici.Name = "lblKullanici";
            lblKullanici.Size = new Size(95, 20);
            lblKullanici.TabIndex = 1;
            lblKullanici.Text = "Kullanıcı Adı:";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(318, 157);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(42, 20);
            lblSifre.TabIndex = 2;
            lblSifre.Text = "Şifre:";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(375, 119);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(120, 26);
            txtKullaniciAdi.TabIndex = 3;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(375, 151);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(120, 26);
            txtSifre.TabIndex = 4;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(lblSifre);
            Controls.Add(lblKullanici);
            Controls.Add(btnGiris);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGiris;
        private Label lblKullanici;
        private Label lblSifre;
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
    }
}