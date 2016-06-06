using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BDPZespolowy.Models
{
    public class Pokoj
    {
        public int ID { get; set; }
        public int Pokoj_Numer { get; set; }
        public bool Pokoj_Dostępnosc { get; set; }
        public int Pokoj_IloscMiejsc { get; set; }
        public string Pokoj_Typ { get; set; }
    }
}
