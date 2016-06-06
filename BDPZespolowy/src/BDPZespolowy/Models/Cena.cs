using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BDPZespolowy.Models
{
    public class Cena
    {
        public int ID { get; set; }
        public float Cena_Netto { get; set; }
        public float Cena_Vat { get; set; }
    }
}
