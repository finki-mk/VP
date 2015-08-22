using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Convertor
{
    public class Convertor
    {
        public string From { get; set; }
        public string To { get; set; }

        public decimal Multiplier { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1}", From, To);
        }
    }
}
