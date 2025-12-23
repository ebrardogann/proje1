using Microsoft.EntityFrameworkCore; 
using OgrKayitApp.Data;
using OgrKayitApp.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OgrKayitApp.Forms
{
    public partial class SinifKayitForm : Form
    {
        public SinifKayitForm()
        {
            InitializeComponent();
        }

        
        private void SinifKayitForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

      
        void Listele()
        {
            using (var ctx = new OkulContext())
            {             
                dataGridView1.DataSource = ctx.Siniflar.ToList();
            }
        }

       
        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (var ctx = new OkulContext())
            {
                Sinif yeniSinif = new Sinif();
                yeniSinif.SinifAdi = txtSinifAdi.Text;

                ctx.Siniflar.Add(yeniSinif);
                ctx.SaveChanges();
            }
            MessageBox.Show("Sınıf Eklendi");
            Listele(); 
            txtSinifAdi.Clear(); 
        }

      
        private void btnSil_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                int secilenId = (int)dataGridView1.SelectedRows[0].Cells["SinifId"].Value;

                using (var ctx = new OkulContext())
                {
               
                    var silinecekVeri = ctx.Siniflar.Find(secilenId);

                    if (silinecekVeri != null)
                    {
                        ctx.Siniflar.Remove(silinecekVeri);
                        ctx.SaveChanges(); 
                        MessageBox.Show("Sınıf Silindi");
                        Listele();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek satırı seçin.");
            }
        }

       
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int secilenId = (int)dataGridView1.SelectedRows[0].Cells["SinifId"].Value;

                using (var ctx = new OkulContext())
                {
                    
                    var guncellenecekVeri = ctx.Siniflar.Find(secilenId);

                    
                    guncellenecekVeri.SinifAdi = txtSinifAdi.Text;

                   
                    ctx.SaveChanges();

                    MessageBox.Show("Sınıf Güncellendi");
                    Listele();
                }
            }
        }

        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtSinifAdi.Text = dataGridView1.SelectedRows[0].Cells["SinifAdi"].Value.ToString();
            }
        }
    }
}