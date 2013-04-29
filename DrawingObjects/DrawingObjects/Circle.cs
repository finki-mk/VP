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

        public Circle(float x, float y, float radius, Brush brush) : base(x, y, brush)
        {
            Radius = radius;
        }



        public override void Draw(Graphics g)
        {
            g.FillEllipse(Brush, X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
            if (Selected)
            {
                g.DrawEllipse(SelectedPen, X - Radius, Y - Radius, 2 * Radius, 2 * Radius); 
            }
        }

        public override bool IsHit(float x, float y)
        {
            double d = Math.Sqrt((X - x) * (X - x) + (Y - y) * (Y - y));
            return d <= Radius;            
        }

    }
}
