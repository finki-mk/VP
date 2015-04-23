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
        float radius;
        bool isBlowing;

        public Circle(Point p, Color c)
            : base(p, c)
        {
            radius = RADIUS;
        }

        public override void Draw(System.Drawing.Graphics g)
        {
            Brush b = new SolidBrush(Color);
            if (Selected)
            {
                Pen pen = new Pen(Color.Yellow);
                g.DrawEllipse(pen, Position.X - radius, Position.Y - radius, radius * 2, radius * 2);
                pen.Dispose();
            }
            g.FillEllipse(b, Position.X - radius, Position.Y - radius, radius * 2, radius * 2);
            b.Dispose();
        }

        public override bool Clicked(Point p)
        {
            return (p.X - Position.X) * (p.X - Position.X) + (p.Y - Position.Y) * (p.Y - Position.Y)
                <= radius * radius;
        }

        public override void Pulse(int percent)
        {
            if (isBlowing)
            {
                radius += 3;
                if (radius >= RADIUS * (1 + percent / 100.0))
                {
                    isBlowing = false;
                }
            }
            else
            {
                radius -= 3;
                if (radius <= RADIUS)
                {
                    isBlowing = true;
                }
            }
        }
    }
}
