using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BDPZespolowy.Models
{
    public class Adres
    {
        public int Adres_PKid { get; set; }
        public string Adres_Kraj { get; set; }
        public string Adres_Ulica { get; set; }
        public int Adres_KodPocztowy { get; set; }
        public string Adres_Miasto { get; set; }
        public int Adres_Nrmieszkania { get; set; }
        public int Adres_Nrdomu { get; set; }
    }
}
