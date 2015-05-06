using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace F1Race
{
    public class Lap
    {
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public override string ToString()
        {
            return string.Format("{0}:{1:00}", Minutes, Seconds);
        }

        public int Time
        {
            get
            {
                return Minutes * 60 + Seconds;
            }
        }
    }
}
