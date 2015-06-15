using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SlidingBalls
{
    [Serializable]
    public class Ball
    {
        public readonly float RADIUS = 30;

        public Color Color { get; set; }

        public Point Position { get; set; }

        public Ball(System.Drawing.Color color, Point position)
        {
            this.Color = color;
            this.Position = position;
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            g.FillEllipse(b, Position.X - RADIUS, Position.Y - RADIUS, RADIUS * 2, RADIUS * 2);
            b.Dispose();
        }

        public bool Touches(Ball b)
        {
            return (Position.X - b.Position.X) * (Position.X - b.Position.X) + (Position.Y - b.Position.Y) * (Position.Y - b.Position.Y) <= RADIUS * RADIUS * 4;
        }

        public bool Touches(Point position)
        {
            return (Position.X - position.X) * (Position.X - position.X) + (Position.Y - position.Y) * (Position.Y - position.Y) <= RADIUS * RADIUS;
        }

        public bool OutOfBounds(int width, int height)
        {
            if (Position.X + RADIUS < 0 || Position.X - RADIUS > width) return true;
            if (Position.Y + RADIUS < 0 || Position.Y - RADIUS > height) return true;
            return false;
        }

    }
}
