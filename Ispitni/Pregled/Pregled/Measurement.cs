using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pregled
{
    public class Measurement
    {
        public MeasureType Type { get; set; }
        public decimal Value { get; set; }

        public override string ToString()
        {
            return string.Format("{0}: {1}", Type, Value);
        }
    }
}
