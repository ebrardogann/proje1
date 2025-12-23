using OgrKayitApp.Data;
using OgrKayitApp.Entities;
using OgrKayitApp.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OgrKayitApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

           
            using (var ctx = new OkulContext())
            {
               
                ctx.Database.EnsureCreated();

                if (!ctx.Kullanicilar.Any()) 
                {
                    ctx.Kullanicilar.Add(new Kullanici { KullaniciAdi = "admin", Sifre = "123" });
                    ctx.SaveChanges();
                }
            }
            
            Application.Run(new LoginForm());
        }
    }
}