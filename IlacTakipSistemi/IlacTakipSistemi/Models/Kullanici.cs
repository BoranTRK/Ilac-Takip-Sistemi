using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlacTakipSistemi.Models
{
    public class Kullanici
    {
        public int kullaniciID { get; set; }

        public string kullaniciGirisKodu { get; set; }

        public string kullaniciAdSoyad { get; set; }

        public string kullaniciTcNo { get; set; }

        public int kullaniciYas { get; set; }

        public string kullaniciCinsiyet { get; set; }
        
    }
}
