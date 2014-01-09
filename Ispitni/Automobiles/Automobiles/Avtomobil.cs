using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zadaca1
{
    public class Avtomobil
    {
        public Marka Marka { get; set; }

        public string Model { get; set; }

        public double Potrosuvacka { get; set; }

        public int Cena { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} ({2:0.0}) : {3}", Marka.Ime, Model, Potrosuvacka, Cena);
        }
    }
}
