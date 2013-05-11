using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace BlowingBalloons
{
    [Serializable]
    public class Balloon
    {
        public Point Center { get; set; }

        public int Radius { get; set; }

        public Color Color { get; set; }

        public bool Flag { get; set; }

        public Balloon(Point center, int radius)
        {
            Center = center;
            Radius = radius;
            Random r = new Random();
            Color = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
            Flag = false;
        }

        public bool IsTouching(Balloon ballon)
        {
            double distance = (Center.X - ballon.Center.X) * (Center.X - ballon.Center.X) + (Center.Y - ballon.Center.Y) * (Center.Y - ballon.Center.Y);
            return distance <= ((Radius + ballon.Radius) * (Radius + ballon.Radius));
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillEllipse(brush, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
            brush.Dispose();
        }
    }
}
