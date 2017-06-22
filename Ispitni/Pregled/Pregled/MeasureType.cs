using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pregled
{
    public class MeasureType
    {
        public string Name { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public override string ToString()
        {
            return string.Format("{0}: {1} - {2}", Name, Min, Max);
        }
    }
}
