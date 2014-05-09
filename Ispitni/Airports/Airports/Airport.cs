using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Airports
{
    public class Airport
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Short { get; set; }
        public List<Destination> Destinations;

        public Airport(string name, string city, string sh)
        {
            Name = name;
            City = city;
            Short = sh;
            Destinations = new List<Destination>();
        }

        public void AddDestination(Destination destination)
        {
            Destinations.Add(destination);
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", Short, Name, City);
        }
    }
}
