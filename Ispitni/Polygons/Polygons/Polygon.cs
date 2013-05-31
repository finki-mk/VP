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
        public List<Point> Points;

        public bool IsClosed;

        public Color Color;

        public Polygon(Color color)
        {
            Points = new List<Point>();
            Color = color;
            IsClosed = false;
        }

        public void AddPoint(Point point)
        {
            Points.Add(point);
        }

        public void Draw(Graphics g)
        {
            if (Points.Count > 1)
            {
                Brush brush = new SolidBrush(Color);
                Pen pen = new Pen(brush);
                if (IsClosed)
                {
                    g.FillPolygon(brush, Points.ToArray());
                }
                else
                {
                    g.DrawLines(pen, Points.ToArray());
                }
                
                brush.Dispose();
                pen.Dispose();
            }            
        }

        public void Move(int dx, int dy)
        {
            for(int i = 0; i < Points.Count; i++)
            {
                Points[i] = new Point(Points[i].X + dx, Points[i].Y + dy);
            }
        }
    }
}
