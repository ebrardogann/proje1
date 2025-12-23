using System;
using System.Windows.Forms;

namespace OgrKayitApp.Forms
{
    public partial class MenuForm : Form
    {
        
        public MenuForm(string kullaniciAdi)
        {
            InitializeComponent();
            lblKullaniciBilgi.Text = "Hoşgeldin: " + kullaniciAdi;
        }

        
        private void btnSinifIslemleri_Click(object sender, EventArgs e)
        {
            

            SinifKayitForm frm = new SinifKayitForm();
            frm.ShowDialog();
        }

       
        private void btnOgrenciIslemleri_Click(object sender, EventArgs e)
        {
            OgrenciKayitForm frm = new OgrenciKayitForm();
            frm.ShowDialog();
        }

        
        private void btnListeleme_Click(object sender, EventArgs e)
        {
            OgrenciListelemeForm frm = new OgrenciListelemeForm();
            frm.ShowDialog();
        }

        
        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}