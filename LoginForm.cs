using OgrKayitApp.Data;      
using OgrKayitApp.Entities;  
using System;
using System.Linq;
using System.Windows.Forms;

namespace OgrKayitApp.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string girilenAd = txtKullaniciAdi.Text.Trim(); 
            string girilenSifre = txtSifre.Text.Trim();

            if (string.IsNullOrEmpty(girilenAd) || string.IsNullOrEmpty(girilenSifre))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

           
            using (var ctx = new OkulContext())
            {
                
                var kullanici = ctx.Kullanicilar
                                   .FirstOrDefault(x => x.KullaniciAdi == girilenAd && x.Sifre == girilenSifre);

                if (kullanici != null)
                {
                    
                    MessageBox.Show("Giriş Başarılı! Hoşgeldin " + kullanici.KullaniciAdi);

                   

                    MenuForm menu = new MenuForm(kullanici.KullaniciAdi);
                    menu.Show();

                    this.Hide(); 
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre!");
                }
            }
        }
    }
}