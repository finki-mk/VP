using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zadaca1
{
    public class Series
    {
        public Production Production { get; set; }

        public string Name { get; set; }

        public double Rating { get; set; }

        public int Seasons { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} ({2:0.0}) S: {3}", Production.Name, Name, Rating, Seasons);
        }
    }
}
