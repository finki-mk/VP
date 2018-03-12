using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SportsBets
{
    public class Ticket
    {
        public Game game { get; set; }
        public int tip { get; set; }
        public override string ToString()
        {
            return string.Format("{0} vs {1}: {2}",game.Home.Name,game.Away.Name, tip == 0 ? "1" : tip == 1 ? "X" : "2");
        }
    }
}
