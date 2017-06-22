using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ShootingBalls
{
    [Serializable]
    public class Ball
    {
        private Point position;

        private Color color;

        private int radius;

        private static readonly Color[] COLORS = { Color.Orange, Color.Blue, Color.Green };
        private int colorIndex;
        private bool hit;
        private int points;
        
        public Ball(Point position, Random random)
        {
            this.position = position;
            this.colorIndex = random.Next(COLORS.Length);
            this.color = COLORS[colorIndex];
            this.radius = random.Next(40, 100);
            this.hit = false;
        }

        public Ball(Point position, int radius, Color color)
        {
            this.position = position;
            this.color = color;
            this.radius = radius;
            this.hit = false;
        }

        public int Hit(Point position)
        {
            hit = distance(this.position, position) <= radius * radius;
            points = 0;
            if (hit)
            {
                color = Color.Red;
                points = (colorIndex + 1) * 5;
            }
            return points;
        }

        public bool Colide(Ball ball)
        {
            int dist = distance(position, ball.position);
            return (radius + ball.radius) * (radius + ball.radius) >= dist;
        }

        private int distance(Point p1, Point p2)
        {
            return (p1.X - p2.X) * (p1.X - p2.X)
                + (p1.Y - p2.Y) * (p1.Y - p2.Y);
        }


        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(color);
            g.FillEllipse(brush, position.X - radius, position.Y - radius,
                2 * radius, 2 * radius);
            
            brush.Dispose();
        }

        public bool Tick()
        {
            if (hit) return true;
            colorIndex = (colorIndex + 1) % 3;
            color = COLORS[colorIndex];
            radius -= 5;
            return radius <= 10;
        }
    }
}
