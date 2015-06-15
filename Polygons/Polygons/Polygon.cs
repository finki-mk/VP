using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Polygons
{
    public class Polygon
    {
        public List<Point> Points { get; set; }

        public Color Color { get; set; }

        public bool IsClosed { get; set; }

        public Polygon(Color color)
        {
            Color = color;
            Points = new List<Point>();
            IsClosed = false;
        }

        public void AddPoint(Point p)
        {
            Points.Add(p);
        }

        public void Draw(Graphics g)
        {
            if (IsClosed)
            {
                Brush b = new SolidBrush(Color);
                g.FillPolygon(b, Points.ToArray());
                b.Dispose();
            }
            else
            {
                Pen p = new Pen(Color.Black, 1);
                g.DrawLines(p, Points.ToArray());
                //for (int i = 0; i < Points.Count - 1; ++i)
                //{
                //    g.DrawLine(p, Points[i], Points[i + 1]);
                //}
                p.Dispose();
            }
        }

        public Point LastPoint
        {
            get
            {
                return Points[Points.Count - 1];
            }
        }
      
    }
}
