using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orders
{
    public class ProductItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public string Note { get; set; }
        public decimal Total
        {
            get
            {
                return Product.Price * Quantity;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} x {1} = {2} ден", Quantity, Product.Name, Total);
        }
    }
}
