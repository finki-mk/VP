using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Zadaca2
{
    [Serializable]
    public class Ball
    {
        public static readonly int RADIUS = 25;
        public static readonly int SPEED = 10;

        public Point Center { get; set; }

        public bool IsMoving { get; set; }

        public bool MovingDown { get; set; }

        public Color Color { get; set; }

        public Ball(Point center, Color color)
        {
            Center = center;
            Color = color;
            MovingDown = true;
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            g.FillEllipse(b, Center.X - RADIUS, Center.Y - RADIUS, 2 * RADIUS, 2 * RADIUS);
            b.Dispose();
        }

        public void Move(int height)
        {
            if (MovingDown)
            {
                Center = new Point(Center.X, Center.Y + SPEED);
            }
            else
            {
                Center = new Point(Center.X, Center.Y - SPEED);
            }
            if (Center.Y + RADIUS >= height - 50)
            {
                MovingDown = false;
            } else if (Center.Y - RADIUS <= 50)
            {
                MovingDown = true;
            }
        }
    }
}
