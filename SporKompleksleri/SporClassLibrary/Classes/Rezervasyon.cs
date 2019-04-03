using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporKompleksi
{
    public class Rezervasyon : Database
    {
        public Rezervasyon(Users user, Saha saha, string tarih, string saat)
        {
            User = user;
            Saha = saha;
            Tarih = tarih;
            Saat = saat;
        }

        //public Rezervasyon(Users kullaniciAdi,  string adi, string soyAdi, string numara, string tarih, string saat)
        //{
        //    User = kullaniciAdi;
        //    Adi = adi;
        //    SoyAdi = soyAdi;
        //    Numara = numara;
        //    Tarih = tarih;
        //    Saat = saat;

        //}

        public Users User { get; set; }
        public Saha Saha { get; set; }
        public string Tarih { get; set; }
        public string Saat { get; set; }
    }
}
