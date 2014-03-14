using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zadaca1
{
    public class Item
    {
        public Product Product { get; set; }

        public int Quantity { get; set; }

        public Item(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return string.Format("{0} {1:0.00} X {2} = {3:0.00}", Product.Name, Product.Price, Quantity, Product.Price * Quantity);
        }

        public float Price()
        {
            return Product.Price * Quantity;
        }
    }
}
