using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zadaca1
{
    public class Marka
    {
        public string Ime { get; set; }

        public string Sifra { get; set; }

        public override string ToString()
        {
            return string.Format("{0} ({1})", Ime, Sifra);
        }
    }
}
