
using Microsoft.EntityFrameworkCore;
using OgrKayitApp.Entities;

namespace OgrKayitApp.Data
{
    public class OkulContext : DbContext
    {
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Sinif> Siniflar { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=OkulDB;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Ogrenci>(entity =>
            {
               
                entity.ToTable("Ogrenciler");

                
                entity.HasKey(e => e.OgrenciId);

                
                entity.Property(e => e.Ad)
                      .HasColumnType("varchar")  
                      .HasMaxLength(30)         
                      .IsRequired();             

             
                entity.Property(e => e.Soyad)
                      .HasColumnType("varchar")
                      .HasMaxLength(30)
                      .IsRequired();

                
                entity.HasOne(d => d.Sinif)
                      .WithMany(p => p.Ogrenciler)
                      .HasForeignKey(d => d.SinifId)
                      .OnDelete(DeleteBehavior.Cascade); 
            });

          
            modelBuilder.Entity<Sinif>(entity =>
            {
                entity.ToTable("Siniflar");

                entity.HasKey(e => e.SinifId);

                
                entity.Property(e => e.SinifAdi)
                      .HasColumnType("varchar")
                      .HasMaxLength(10)
                      .IsRequired();
            });

         
            modelBuilder.Entity<Kullanici>(entity =>
            {
                entity.ToTable("Kullanicilar");

                entity.HasKey(e => e.KullaniciId); 

                
                entity.Property(e => e.KullaniciAdi)
                      .HasColumnType("varchar")
                      .HasMaxLength(20)
                      .IsRequired();

                
                entity.Property(e => e.Sifre)
                      .HasColumnType("varchar")
                      .HasMaxLength(20)
                      .IsRequired();
            });
        }
    }
}