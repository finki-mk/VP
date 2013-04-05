using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountriesList
{
    class Country
    {
        public string Name { get; set; }
        public string Capital { get; set; }
        public string Code { get; set; }

        public Country(string name, string capital, string code)
        {
            Name = name;
            Capital = capital;
            Code = code;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1})", Name, Code);
        }
    }
}
