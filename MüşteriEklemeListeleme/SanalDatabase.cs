using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MüşteriEklemeListeleme
{
    public static class SanalDatabase
    {

        public static List<Müşteri> Müşteriler { get; set; }

        static SanalDatabase() 
        {
            List<Müşteri> Müşteriler = new List<Müşteri>();
        }
    }
}
