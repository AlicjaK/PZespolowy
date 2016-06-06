using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BDPZespolowy.Models
{
    public class Pracownik
    {

        public int Pracownik_PKid { get; set; }
        public int Adres_FKid { get; set; }
        public decimal Stanowisko_FKid { get; set; }
        public string Pracownik_Imie { get; set; }
        public string Pracownik_Nazwisko { get; set; }
        public int Pracownik_Pesel { get; set; }
        public int Pracownik_Nrtelefonu { get; set; }

    }
}
