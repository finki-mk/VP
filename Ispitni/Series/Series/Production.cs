using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zadaca1
{
    public class Production
    {
        public string Name { get; set; }

        public string Code { get; set; }

        public Production()
        {
        }

        public Production(string name, string code)
        {
            Name = name;
            Code = code;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1})", Name, Code);
        }
    }
}
