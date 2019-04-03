using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporKompleksi
{
    public class Users:Database
    {
        public Users(string kullaniciAdi, string sifre, string adi, string soyadi, string telefon)
        {
            KullaniciAdi = kullaniciAdi;
            Sifre = sifre;
            Adi = adi;
            Soyadi = soyadi;
            Telefon = telefon;
        }
        public Users()
        {

        }

        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Telefon { get; set; }
        

    }
}
