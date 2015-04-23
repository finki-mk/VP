using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Drawing1
{
    public class Circle : Shape
    {
        static readonly float RADIUS = 25;

        public Circle(Point p, Color c)
            : base(p, c)
        {
        }

        public override void Draw(System.Drawing.Graphics g)
        {
            Brush b = new SolidBrush(Color);
            g.FillEllipse(b, Position.X - RADIUS, Position.Y - RADIUS, RADIUS * 2, RADIUS * 2);
            b.Dispose();
        }

        public override bool Clicked(Point p)
        {
            return (p.X - Position.X) * (p.X - Position.X) + (p.Y - Position.Y) * (p.Y - Position.Y) 
                <= RADIUS * RADIUS;
        }
    }
}
