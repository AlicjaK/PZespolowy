using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BDPZespolowy.Models
{
    public class Stanowisko
    {
        public int ID { get; set; }
        public string Stanowisko_Nazwa { get; set; }
        public int Stanowisko_LPracowników { get; set; }
        public float Stanowisko_Wypłata { get; set; }
    }
}
