using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace NumbersMaster
{
    public class Number
    {
        public static readonly int RADIUS = 30;
        public int Digit { get; set; }

        public int TimeAlive { get; set; }

        public Point Center { get; set; }
        public bool IsHit { get; set; }

        public Number(int width, int height)
        {
            Random r = new Random();
            Digit = r.Next(10);
            TimeAlive = 5;
            int x = r.Next(RADIUS, width - (2 * RADIUS));
            int y = r.Next(RADIUS, height - (2 * RADIUS));
            Center = new Point(x, y);
        }

        public void Draw(Graphics g)
        {
            if (TimeAlive <= 2)
            {
                g.FillEllipse(Brushes.Red, Center.X - RADIUS, Center.Y - RADIUS, RADIUS * 2, RADIUS * 2);
            }
            else
            {
                g.FillEllipse(Brushes.Aqua, Center.X - RADIUS, Center.Y - RADIUS, RADIUS * 2, RADIUS * 2);
            }
            Font f = new Font("Arial", 24);
            g.DrawString(string.Format("{0}", Digit), f, Brushes.Black, Center.X - 15, Center.Y - 15);
            f.Dispose();
        }

        public void Tick()
        {
            --TimeAlive;
        }

        public void Hit()
        {
            IsHit = true;
        }

    }
}
