using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Zadaca2
{
    [Serializable]
    public class CirclesDoc
    {
        public List<Circle> Circles { get; set; }

        public CirclesDoc()
        {
            Circles = new List<Circle>();
        }

        public void Draw(Graphics g)
        {
            for (int i = 0; i < Circles.Count; i++)
            {
                Circles[i].Draw(g);
            }
        }

        public void AddCircle(Point point, int width, int height)
        {
            Circle c = new Circle(point, width, height);
            Circles.Add(c);
        }

        public void ChanngeColor()
        {
            for (int i = 0; i < Circles.Count; i++)
            {
                Circles[i].ChangeColor();
            }
        }
    }
}
