using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DrawingObjects
{
    public class Circle : Shape
    {
        public float Radius { get; set; }

        public Circle(float x, float y, float radius, Color color) : base(x, y, color)
        {
            Radius = radius;
        }



        public override void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            g.FillEllipse(b, X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
            if (Selected)
            {
                Pen pen = new Pen(Color.Red, 3);
                g.DrawEllipse(pen, X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
                pen.Dispose();
            }
            b.Dispose();

        }

        public override bool IsHit(float x, float y)
        {
            double d = Math.Sqrt((X - x) * (X - x) + (Y - y) * (Y - y));
            return d <= Radius;            
        }

    }
}
