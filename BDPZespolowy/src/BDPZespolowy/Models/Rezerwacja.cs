using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BDPZespolowy.Models
{
    public class Rezerwacja
    {
        public int Rezerwacja_PKid { get; set; }
        public int Pokój_FKid { get; set; }
        public int Klient_FKid { get; set; }
        public int Terminy_FKid { get; set; }
        public int Cennik_FKid { get; set; }
        public int Rezerwacja_NrRezerwacji_ { get; set; }
        public float Rezerwacja_OstatKwota { get; set; }
    }
}
