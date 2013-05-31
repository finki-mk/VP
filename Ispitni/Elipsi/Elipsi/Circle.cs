using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Zadaca2
{
    [Serializable]
    public class Circle
    {
        public int R { get; set; }

        public int G { get; set; }

        public int B { get; set; }

        public Point Point { get; set; }

        public int Height { get; set; }

        public int Width { get; set; }

        public Circle(Point point, int width, int height)
        {
            Point = point;
            Width = width;
            Height = height;
            Random r = new Random();
            R = r.Next(256);
            G = r.Next(256);
            B = r.Next(256);
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color.FromArgb(R, G, B));
            g.FillEllipse(b, Point.X, Point.Y, Width, Height);
            b.Dispose();
        }

        public void ChangeColor()
        {
            Random r = new Random();
            R += 5;
            G += 10;
            B += 15;
            R = R % 256;
            G = G % 256;
            B = B % 256;
        }
    }

}
