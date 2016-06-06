using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BDPZespolowy.Models
{
    public class Klient
    {
        public int ID { get; set; }
        //public int Zniżki_FKid { get; set; }
        public string Klient_Imie { get; set; }
        public string Klient_Nazwisko { get; set; }
        public int Klient_Pesel { get; set; }
        public int Klient_Nrtelefonu { get; set; }
    }
}
