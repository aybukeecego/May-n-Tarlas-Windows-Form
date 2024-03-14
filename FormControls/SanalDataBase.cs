using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormControls
{
    public  class SanalDataBase
    {

        public static List<Müşteri> Müşteriler { get; set; }
        static SanalDataBase() 
        {
            Müşteriler = new List<Müşteri>();
        }

        public static void Ekle(Müşteri müşteri) 
        {

            Müşteriler.Add(müşteri);
        }

    }
}
