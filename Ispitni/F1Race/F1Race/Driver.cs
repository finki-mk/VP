using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace F1Race
{
    public class Driver
    {
        public string Name { get; set; }
        public bool IsFirst { get; set; }
        public int Age { get; set; }

        public List<Lap> Laps { get; set; }

        public Driver()
        {
            Laps = new List<Lap>();
        }

        public override string ToString()
        {
            return string.Format("{0} ({1}) - {2}", Name, Age, IsFirst ? "F" : "S");
        }
    }
}
