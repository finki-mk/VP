using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pregled
{
    public class Patient
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public List<Measurement> Measurements { get; set; }

        public Patient()
        {
            Measurements = new List<Measurement>();
        }

        public override string ToString()
        {
            return string.Format("{0} {1} kg {2} cm", Name, Weight, Height);
        }
    }
}
