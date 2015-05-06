using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PulsingCirlces
{
    [Serializable]
    public class CircleDoc
    {
        public List<Circle> Circles { get; set; }

        public CircleDoc()
        {
            Circles = new List<Circle>();
        }

        public void AddCircle(Point center, Color color)
        {
            Circles.Add(new Circle(center, color));
        }

        public void Draw(Graphics g)
        {
            foreach (Circle c in Circles)
            {
                c.Draw(g);
            }
        }

        public void Pulse()
        {
            foreach (Circle c in Circles)
            {
                c.Pulse();
            }
        }
    }
}
