using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace FlyingBalls
{
    [Serializable]
    public class Ball
    {
        public static readonly int RADIUS = 30;

        public int State { get; set; }

        public Point Center { get; set; }

        public Ball()
        {
            Random r = new Random();
            State = r.Next(3);
        }

        public void Move()
        {
            Center = new Point(Center.X + 10, Center.Y);
        }

        public void Draw(Graphics g)
        {
            Brush b = null;
            if (State == 0)
            {
                b = new SolidBrush(Color.Green);
            }
            else if (State == 1)
            {
                b = new SolidBrush(Color.Blue);
            }
            else
            {
                b = new SolidBrush(Color.Red);
            }
            g.FillEllipse(b, Center.X - RADIUS, Center.Y - RADIUS, RADIUS * 2, RADIUS * 2);
            b.Dispose();

        }

        public bool Hit(Point position)
        {
            if (RADIUS * RADIUS >= (Center.X - position.X) * (Center.X - position.X) + (Center.Y - position.Y) * (Center.Y - position.Y))
            {
                State++;
                if (State == 3)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
