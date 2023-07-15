using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlacTakipSistemi.Models
{
    public class Ilac
    {
        public int ilacID { get; set; }

        public string ilacAdi { get; set; }

        public int gunlukAdet { get; set; }

        public string ilacTuru { get; set; }

        public int kullaniciID { get; set; }

    }
}
