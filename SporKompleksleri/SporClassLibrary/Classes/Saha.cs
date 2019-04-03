using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporKompleksi
{
    public enum SahaTuru
    {
        Basketbol,
        Futbol,
        Voleybol
    }
    public  class Saha  : Database
    {
        private int _kapasite;

       
        public Saha(int kapasite,SahaTuru sahaTuru,string sahaAdi,string sahaAdresi)
        {
            Kapasite = kapasite;
            SahaTuru = sahaTuru;
            SahaAdi = sahaAdi;
            SahaninAdresi = sahaAdresi;
            
        }
        public int Kapasite
        {
            get
            { return _kapasite; }
            set
            {
                if (value > 0)
                {
                    _kapasite = value;
                }
                else
                    throw new IndexOutOfRangeException();

            }
        }
        public SahaTuru SahaTuru { get; set; }
        public string SahaAdi { get; set; }
        public string SahaninAdresi { get; set; }
        //public SahaTipi SahaTipi { get; set; }
       
        //public ZeminTuru ZeminTuru { get; set; }
        



    }
}
