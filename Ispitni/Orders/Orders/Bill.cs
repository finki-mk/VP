using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orders
{
    public class Bill
    {
        public DateTime Time { get; set; }
        public decimal Total { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} - {2} ден", Time.ToShortDateString(), Time.ToLongTimeString(), Total);
        }
    }
}
