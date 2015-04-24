using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Drawing1
{
    public class Triangle : Shape
    {
        public Point P2 { get; set; }
        public Point P3 { get; set; }

        public Triangle(Point p, Color cc, Point p2, Point p3)
            : base(p, cc)
        {
            P2 = p2;
            P3 = p3;
        }

        public override void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            Point[] points = { Position, P2, P3};
            g.FillPolygon(b, points);
            b.Dispose();
        }

        public override bool Clicked(Point p)
        {
            return false;
        }

        public override void Pulse(int percent)
        {
            throw new NotImplementedException();
        }
    }
}
