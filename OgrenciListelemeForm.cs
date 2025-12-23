using OgrKayitApp.Data;
using System;
using System.Data; 
using System.Linq;
using System.Windows.Forms;

namespace OgrKayitApp.Forms
{
    public partial class OgrenciListelemeForm : Form
    {
        public OgrenciListelemeForm()
        {
            InitializeComponent();
        }

       
        private void OgrenciListelemeForm_Load(object sender, EventArgs e)
        {
            Listele(); 
        }

       

      
        void Listele(string arananKelime = "")
        {
            using (var ctx = new OkulContext())
            {
                
                
                var sorgu = from o in ctx.Ogrenciler
                            join s in ctx.Siniflar on o.SinifId equals s.SinifId
                            select new
                            {
                                Ad = o.Ad,
                                Soyad = o.Soyad,
                                Numara = o.Numara,
                                Sinif = s.SinifAdi 
                            };

                
                if (!string.IsNullOrEmpty(arananKelime))
                {
                    
                    sorgu = sorgu.Where(x => x.Ad.Contains(arananKelime) || x.Numara.Contains(arananKelime));
                }

                
                dataGridView1.DataSource = sorgu.ToList();
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
           
           
            string arananKelime = txtArama.Text.Trim();

            
            Listele(arananKelime);
        }
    }
}