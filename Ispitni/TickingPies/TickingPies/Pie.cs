using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Zad2
{
    [Serializable]
    public class Pie
    {
        public Point Center { get; set; }

        private static readonly int RADIUS = 25;

        public int Tick { get; set; }

        public Color Color { get; set; }

        public Pie(Point center, Color color)
        {
            Center = center;
            Tick = 0;
            Color = color;
        }

        public void Draw(Graphics g)
        {   
            Brush b = new SolidBrush(Color);            
            g.FillPie(b, Center.X - RADIUS, Center.Y - RADIUS, 2 * RADIUS, 2 * RADIUS, 0, (int)((4 - Tick) * 90));
            b.Dispose();
        }
    }
}
