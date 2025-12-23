using System;
using System.Collections.Generic;

namespace OgrKayitApp.Entities
{
    public class Sinif
    {
        
        public Sinif()
        {
            this.Ogrenciler = new HashSet<Ogrenci>();
        }

        public int SinifId { get; set; }    
        public string SinifAdi { get; set; }  

       
       
        public virtual ICollection<Ogrenci> Ogrenciler { get; set; }
    }
}