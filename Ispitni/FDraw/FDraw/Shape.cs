using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace FDraw
{
    [Serializable]
    abstract class Shape
    {
        public Color Color { get; set; }
        public Point Position { get; set; }

        public abstract void Draw(Graphics g);

        public abstract bool Select(Point point);

        public void Move(int dx, int dy)
        {
            Position = new Point(Position.X + dx, Position.Y + dy);
        }
    }
}
