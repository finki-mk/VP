using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace PogodiGiTopcinjata
{
    public enum BallColor
    {
        orange, blue, green, red, black
    }

    class Balls
    {
        public Point point{
            set;
            get;
            }
        public int rad
        {
            set; get;
        }
    public Color color
        {
            set; get;
        }

        public Balls(Point p, int Rad)
        {
            Random rand = new Random();
            /*
            X = rand.Next() % (maxH - 200) + 100;
            Y = rand.Next() % (maxY - 200) + 100;
            */
            point = p;
            rad = Rad;
            int c = rand.Next() % 3;
            if (c == 0)
                color = Color.Blue;
            if (c == 1)
                color = Color.Green;
            if (c == 2)
                color = Color.Orange;
        }
    }
}
