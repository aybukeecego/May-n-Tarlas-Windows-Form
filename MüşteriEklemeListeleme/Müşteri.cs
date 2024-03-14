﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MüşteriEklemeListeleme
{
    public class Müşteri
    {
        public int Id { get; set; }
        public  string İsim { get; set; }
        public string Soyisim { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return İsim + " " + Soyisim;
        }


    }
}
