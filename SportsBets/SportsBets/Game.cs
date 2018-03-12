using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SportsBets
{
    public class Game
    {
        public Team Home { get; set; }
        public Team Away { get; set; }
        public string Code { get; set; }
        public decimal[] Coeffietients { get; set; }

        public Game()
        {
            Coeffietients = new decimal[3];
        }
        public override string ToString()
        {
            return string.Format("{0} - {1} vs. {2}",Code,Home,Away);
        }
    }
}
