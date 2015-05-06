using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PulsingCirlces
{
    [Serializable]
    public class Circle
    {
        public Point Center { get; set; }
        public Color Color { get; set; }
        public int Radius { get; set; }
        public int OriginalRadius { get; set; }
        private int percent;

        public Circle(Point center, Color color)
        {
            Center = center;
            Color = color;
            Radius = 30;
            OriginalRadius = Radius;
            percent = 0;
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            g.FillEllipse(b, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
            b.Dispose();
        }

        public void Pulse()
        {
            percent += 10;
            Radius = OriginalRadius + (int)(OriginalRadius * percent * 0.01);
            if (percent == 100)
            {
                percent = 0;
            }
        }
    }
}
