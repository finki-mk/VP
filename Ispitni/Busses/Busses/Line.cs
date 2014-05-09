using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Busses
{
    public class Line
    {
        public string Destination { get; set; }
        public int StartHour { get; set; }
        public int StartMinute { get; set; }
        public int Price { get; set; }

        public Line(string destination, int startHour, int startMinute, int price)
        {
            Destination = destination;
            StartHour = startHour;
            StartMinute = startMinute;
            Price = price;
        }

        public override string ToString()
        {
            return string.Format("{0}:{1:00} - {2} - {3} Ден.", StartHour, StartMinute, Destination, Price);
        }
    }
}
