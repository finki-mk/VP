using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ColorCircles
{
    [Serializable]
    public class CirclesDoc
    {
        public List<Circle> Circles;

        public CirclesDoc()
        {
            Circles = new List<Circle>();
        }

        public void Draw(Graphics g)
        {
            foreach (Circle r in Circles)
            {
                r.Draw(g);
            }
        }

        public void AddCircle(Point p, int radius, Color color)
        {
            Circle c = new Circle(p, radius, color);
            Circles.Add(c);
        }

        public void Select(Point p)
        {
            foreach (Circle r in Circles)
            {
                r.Select(p);
            }
        }

        public void DeleteSelected()
        {
            for (int i = Circles.Count - 1; i >= 0; --i)
            {
                if (Circles[i].IsSelected)
                {
                    Circles.RemoveAt(i);
                }
            }
        }
    }
}
