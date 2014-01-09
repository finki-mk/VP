using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ColorRectangles
{
    [Serializable]
    public class RectanglesDoc
    {
        public List<Rectangle> Rectangles;

        public RectanglesDoc()
        {
            Rectangles = new List<Rectangle>();
        }

        public void Draw(Graphics g)
        {
            foreach (Rectangle r in Rectangles)
            {
                r.Draw(g);
            }
        }

        public void AddRectangle(Point p, int width, int height, Color color)
        {
            Rectangle r = new Rectangle(p, width, height, color);
            Rectangles.Add(r);
        }

        public void Select(Point p)
        {
            foreach (Rectangle r in Rectangles)
            {
                r.Select(p);
            }
        }

        public void DeleteSelected()
        {
            for (int i = Rectangles.Count - 1; i >= 0; --i)
            {
                if (Rectangles[i].IsSelected)
                {
                    Rectangles.RemoveAt(i);
                }
            }
        }
    }
}
