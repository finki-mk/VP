using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Drawing1
{
    public abstract class Shape
    {
        public Point Position { get; set; }
        public Color Color { get; set; }
        public bool Selected { get; set; }

        public Shape(Point p, Color c)
        {
            Position = p;
            Color = c;
            Selected = false;
        }

        public abstract void Draw(Graphics g);

        public abstract bool Clicked(Point p);

        public abstract void Pulse(int percent);
    }
}
