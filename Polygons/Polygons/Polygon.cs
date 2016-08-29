using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Polygons
{
    [Serializable]
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
            Brush b = new SolidBrush(Color);
            Pen p = new Pen(Color.Black, 1);
            if (IsClosed)
            {
                g.FillPolygon(b, Points.ToArray());
            }
            else
            {
             
                g.DrawLines(p, Points.ToArray());
                //for (int i = 0; i < Points.Count - 1; ++i)
                //{
                //    g.DrawLine(p, Points[i], Points[i + 1]);
                //}
                
            }
            b.Dispose();
            p.Dispose();
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
