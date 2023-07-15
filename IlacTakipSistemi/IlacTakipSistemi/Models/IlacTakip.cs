using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlacTakipSistemi.Models
{
    public class IlacTakip
    {
        public int ilacTakipID { get; set; }

        public string ilacAdı { get; set; }

        public DateTime Tarih { get; set; }
    }
}
