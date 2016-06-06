using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BDPZespolowy.Models
{
    public class Pokoj
    {
        public int Pokój_Pkid { get; set; }
        public int Pokój_Numer { get; set; }
        public bool Pokój_Dostępność { get; set; }
        public int Pokój_IlośćMiejsc { get; set; }
        public string Pokój_Typ { get; set; }
    }
}
