using Microsoft.EntityFrameworkCore;
using OgrKayitApp.Data;
using OgrKayitApp.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OgrKayitApp.Forms
{
    public partial class OgrenciKayitForm : Form
    {
        public OgrenciKayitForm()
        {
            InitializeComponent();
        }

       
        private void OgrenciKayitForm_Load(object sender, EventArgs e)
        {
            SiniflariDoldur();
            Listele();
        }

        
        void SiniflariDoldur()
        {
            using (var ctx = new OkulContext())
            {
                var sinifListesi = ctx.Siniflar.ToList();

                cbSiniflar.DataSource = sinifListesi;
                cbSiniflar.DisplayMember = "SinifAdi"; 
                cbSiniflar.ValueMember = "SinifId";   
            }
        }

       
        void Listele()
        {
            using (var ctx = new OkulContext())
            {
                
               
                var liste = ctx.Ogrenciler.Include(x => x.Sinif)
                               .Select(x => new
                               {
                                   Id = x.OgrenciId,
                                   Ad = x.Ad,
                                   Soyad = x.Soyad,
                                   Numara = x.Numara,
                                   Sinif = x.Sinif.SinifAdi 
                               }).ToList();

                dataGridView1.DataSource = liste;
            }
        }

        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (var ctx = new OkulContext())
            {
                Ogrenci ogr = new Ogrenci();
                ogr.Ad = txtAd.Text;
                ogr.Soyad = txtSoyad.Text;
                ogr.Numara = txtNumara.Text;

                
                if (cbSiniflar.SelectedValue != null)
                {
                    ogr.SinifId = (int)cbSiniflar.SelectedValue;
                }
                else
                {
                    MessageBox.Show("Lütfen bir sınıf seçiniz!");
                    return;
                }

                ctx.Ogrenciler.Add(ogr);
                ctx.SaveChanges();
            }
            MessageBox.Show("Öğrenci Eklendi");
            Listele();
            Temizle();
        }

        
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
                using (var ctx = new OkulContext())
                {
                    var silinecek = ctx.Ogrenciler.Find(id);
                    ctx.Ogrenciler.Remove(silinecek);
                    ctx.SaveChanges();
                }
                Listele();
            }
        }

       
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
                using (var ctx = new OkulContext())
                {
                    var ogr = ctx.Ogrenciler.Find(id);
                    ogr.Ad = txtAd.Text;
                    ogr.Soyad = txtSoyad.Text;
                    ogr.Numara = txtNumara.Text;
                    ogr.SinifId = (int)cbSiniflar.SelectedValue;

                    ctx.SaveChanges();
                }
                Listele();
                Temizle();
            }
        }

       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtAd.Text = dataGridView1.SelectedRows[0].Cells["Ad"].Value.ToString();
                txtSoyad.Text = dataGridView1.SelectedRows[0].Cells["Soyad"].Value.ToString();
                txtNumara.Text = dataGridView1.SelectedRows[0].Cells["Numara"].Value.ToString();

                
                cbSiniflar.Text = dataGridView1.SelectedRows[0].Cells["Sinif"].Value.ToString();
            }
        }

        void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtNumara.Clear();
        }
    }
}