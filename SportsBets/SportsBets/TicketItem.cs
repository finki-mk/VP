using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SportsBets
{
    class TicketItem
    {
        public Game Game { get; set; }
        public int Tip { get; set; }

        public override string ToString()
        {
            return string.Format("{0}: {1} {2} {3:0.00}", Game.Code, Game.HomeTeam.Name, Game.GuestTeam.Name, Game.Coefitients[Tip]);

        }
    }
}
