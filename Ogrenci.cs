using System;

namespace OgrKayitApp.Entities
{
    public class Ogrenci
    {
        public int OgrenciId { get; set; }   
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Numara { get; set; }

      
        public int SinifId { get; set; }

        
        public virtual Sinif Sinif { get; set; }
    }
}