using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SportsBets
{
    class Game
    {
        public Team HomeTeam { get; set; }
        public Team GuestTeam { get; set; }
        public float[] Coefitients { get; set; }
        public string Code { get; set; }
        public Game()
        {
            Coefitients = new float[3];
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}-{2} {3:0.00} {4:0.00} {5:0.00}", 
                Code, HomeTeam.Name, GuestTeam.Name, Coefitients[0], Coefitients[1], Coefitients[2]);
        }
    }
}
