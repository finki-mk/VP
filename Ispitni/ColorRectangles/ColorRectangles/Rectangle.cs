using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ColorRectangles
{
    [Serializable]
    public class Rectangle
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public Point Point { get; set; }
        public Color Color { get; set; }
        public bool IsSelected { get; set; }

        public Rectangle(Point point, int width, int height, Color color)
        {
            Point = point;
            Width = width;
            Height = height;
            Color = color;
            IsSelected = false;
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            if (IsSelected)
            {
                Pen pen = new Pen(Brushes.Red, 2);
                g.DrawRectangle(pen, Point.X, Point.Y, Width, Height);
                pen.Dispose();
            }
            g.FillRectangle(b, Point.X, Point.Y, Width, Height);
            b.Dispose();
        }

        public void Select(Point point)
        {
            if (point.X >= Point.X && point.X <= Point.X + Width && point.Y >= Point.Y && point.Y <= Point.Y + Height)
            {
                IsSelected = !IsSelected;
            }            
        }
    }
}
