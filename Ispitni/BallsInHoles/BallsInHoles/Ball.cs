using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace BallsInHoles
{
    [Serializable]
    public class Ball
    {
        public static readonly int RADIUS = 25;
        public Point Center { get; set; }
        public Color Color { get; set; }
        public bool IsInHole { get; set; }

        public double Velocity { get; set; }
        public double Angle { get; set; }

        private float velocityX;
        private float velocityY;


        public Ball(Point center, Color color)
        {
            Center = center;
            Color = color;
            IsInHole = false;
            
            Velocity = 10;
            Random r = new Random();
            Angle = r.NextDouble() * 2 * Math.PI;
            velocityX = (float)(Math.Cos(Angle) * Velocity);
            velocityY = (float)(Math.Sin(Angle) * Velocity);
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            g.FillEllipse(b, Center.X - RADIUS, Center.Y - RADIUS, RADIUS * 2, RADIUS * 2);
            b.Dispose();
        }

        public void Move(int left, int top, int width, int height)
        {
            int nextX = (int)(Center.X + velocityX);
            int nextY = (int)(Center.Y + velocityY);
            int lft = left + RADIUS;
            int rgt = left + width - RADIUS;
            int tp = top + RADIUS;
            int btm = top + height - RADIUS;

            if (nextX <= lft)
            {
                nextX = lft + (lft - nextX);
                velocityX = -velocityX;
            }
            if (nextX >= rgt)
            {
                nextX = rgt - (nextX - rgt);
                velocityX = -velocityX;

            }
            if (nextY <= tp)
            {
                nextY = tp + (tp - nextY);
                velocityY = -velocityY;
            }

            if (nextY >= btm)
            {
                nextY = btm - (nextY - btm);
                velocityY = -velocityY;
            }
            Center = new Point(nextX, nextY);
        }

        public bool InHole(Hole hole)
        {
            float d = (Center.X - hole.Center.X) * (Center.X - hole.Center.X) + (Center.Y - hole.Center.Y) * (Center.Y - hole.Center.Y);
            return d <= RADIUS * RADIUS;
        }

    }
}
