using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BDPZespolowy.Models
{
    public class Raporty
    {
        public int Raporty_PKid { get; set; }
        public int Rezerwacja_Fkid { get; set; }
        public string Raporty_Typ { get; set; }
        public int Raporty_LZarobionychPieniędzy { get; set; }
    }
}
