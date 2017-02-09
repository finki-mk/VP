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
        public Color PrimaryColor { get; set; }
        public Color SecondaryColor { get; set; }
        public int Radius { get; set; }

        public Circle(Point center, Color primary)
        {
            Center = center;
            PrimaryColor = primary;
            Radius = 50;
            SecondaryColor = Color.FromArgb(255 - primary.R, 255 - primary.G, 255 - primary.B);
        }

        public void Draw(Graphics g)
        {
            Brush primary = new SolidBrush(PrimaryColor);
            Brush secondary = new SolidBrush(SecondaryColor);
            g.FillPie(secondary, Center.X - Radius, Center.Y - Radius, Radius * 2, Radius * 2, 0, 180);
            g.FillPie(primary, Center.X - Radius, Center.Y - Radius, Radius * 2, Radius * 2, 180, 180);
            primary.Dispose();
            secondary.Dispose();
        }

        public void Pulse()
        {
            Color temp = PrimaryColor;
            PrimaryColor = SecondaryColor;
            SecondaryColor = temp;
        }
    }
}
