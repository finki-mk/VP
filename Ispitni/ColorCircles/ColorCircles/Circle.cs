using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ColorCircles
{
    [Serializable]
    public class Circle
    {
        public int Radius { get; set; }

        public Point Point { get; set; }
        public Color Color { get; set; }
        public bool IsSelected { get; set; }

        public Circle(Point point, int radius, Color color)
        {
            Point = point;
            Color = color;
            Radius = radius;
            IsSelected = false;
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            if (IsSelected)
            {
                Pen pen = new Pen(Brushes.Red, 5);
                g.DrawEllipse(pen, Point.X - Radius, Point.Y - Radius, Radius * 2, Radius * 2);
                pen.Dispose();
            }
            g.FillEllipse(b, Point.X - Radius, Point.Y - Radius, Radius * 2, Radius * 2);
            b.Dispose();
        }

        public void Select(Point point)
        {
            if (Distance(point, Point) <= Radius * Radius)
            {
                IsSelected = !IsSelected;
            }            
        }

        public static float Distance(Point p1, Point p2)
        {
            return (p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y);
        }
    }
}
