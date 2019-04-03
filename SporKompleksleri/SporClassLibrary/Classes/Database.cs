using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporKompleksi 
{
    public class Database
    {
        private string kullaniciAdi;

        public Database()
        {
            ID = Guid.NewGuid().ToString();
            OlusturanKisi = "admin";
            OlusturulanTarih = DateTime.Now;

        }

        public string ID { get; set; }
        public string OlusturanKisi { get; set; }
        public DateTime OlusturulanTarih { get; set; }
        public string GuncelleyenKisi { get; set; }
        public DateTime GuncellenenTarih { get; set; }

        


    }
}
