using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zadaca1
{
    public class TV
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public List<TVProgram> Program { get; set; }

        public TV()
        {
            Program = new List<TVProgram>();
        }

        public TV(string name, int number)
        {
            Name = name;
            Number = number;
            Program = new List<TVProgram>();
        }

        public override string ToString()
        {
            return string.Format("{0}. {1}", Number, Name);
        }
    }
}
