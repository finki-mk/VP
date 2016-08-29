using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Polygons
{
    [Serializable]
    public class PolygonDoc
    {
        private List<Polygon> poligons;

        public Color Color { get; set; }

        private Point firstPoint;
        private Polygon currentPolygon;
        private Point currentPoint;
        private bool isHit;

        public PolygonDoc()
        {
            Color = Color.Blue;
            firstPoint = Point.Empty;
            poligons = new List<Polygon>();
            isHit = false;
        }

        public void Click(Point position)
        {
            if (firstPoint.IsEmpty)
            {
                firstPoint = position;
                currentPolygon = new Polygon(Color);
                currentPolygon.AddPoint(position);
            }
            else
            {
                currentPolygon.AddPoint(position);
                if (isHit)
                {
                    currentPolygon.IsClosed = true;
                    poligons.Add(currentPolygon);
                    currentPolygon = null;
                    firstPoint = Point.Empty;
                }
                
            }
        }

        public void Move(Point position)
        {
            currentPoint = position;
            isHit = false;
            if (currentPolygon != null)
            {
                if (currentPolygon.Points.Count > 2)
                {
                    isHit = distance(firstPoint, currentPoint) <= 5 * 5;
                }
            }
        }

        float distance(Point p1, Point p2)
        {
            return (p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y);
        }

        public void Draw(Graphics g)
        {
            foreach (Polygon p in poligons)
            {
                p.Draw(g);
            }
            if (currentPolygon != null)
            {
                if (currentPolygon.Points.Count > 1)
                {
                    currentPolygon.Draw(g);
                }
            }
            if (!firstPoint.IsEmpty)
            {
                Pen p = new Pen(Color.Black, 1);
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                g.DrawLine(p, currentPolygon.LastPoint, currentPoint);
                if (isHit)
                {
                    g.DrawEllipse(p, firstPoint.X - 5, firstPoint.Y - 5,
                        10, 10);
                }
                p.Dispose();

            }
            
        }

    }
}
