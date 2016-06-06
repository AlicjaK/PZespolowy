using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BDPZespolowy.Models
{
    public class Termin
    {
        public int Termin_PKid { get; set; }
        public string Termin_Od { get; set; }
        public string Termin_Do { get; set; }
        public int Termin_OdGodziny { get; set; }
        public int Termin_DoGodziny { get; set; }
    }
}
