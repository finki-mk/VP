using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orders
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1:#.##} ден", Name, Price);
        }
    }
}
