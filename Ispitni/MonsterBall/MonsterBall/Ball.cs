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
        public Point Center { get; set; }
        public int Power { get; set; }
        public int Radius { get; set; }

        public double Velocity { get; set; }
        public double Angle { get; set; }

        private float velocityX;
        private float velocityY;

        private Color getColor()
        {
            if (Power < 5)
            {
                return Color.Red;
            }
            if (Power < 10)
            {
                return Color.Blue;
            }
            return Color.Black;
        }


        public Ball(Point center)
        {
            Center = center;
            Power = 0;
            Velocity = 10;
            Random r = new Random();
            Angle = r.NextDouble() * 2 * Math.PI;
            Radius = r.Next(20, 40);
            velocityX = (float)(Math.Cos(Angle) * Velocity);
            velocityY = (float)(Math.Sin(Angle) * Velocity);
        }

        public void Draw(Graphics g, Font font)
        {
            Brush b = new SolidBrush(getColor());
            Brush fb = new SolidBrush(Color.White);
            g.FillEllipse(b, Center.X - Radius, Center.Y - Radius, Radius * 2, Radius * 2);
            g.DrawString(string.Format("{0}", Power), font, fb, Center.X - Radius / 2, Center.Y - Radius / 2);
            fb.Dispose();
            b.Dispose();
        }

        public void Move(int left, int top, int width, int height)
        {
            int nextX = (int)(Center.X + velocityX);
            int nextY = (int)(Center.Y + velocityY);
            int lft = left + Radius;
            int rgt = left + width - Radius;
            int tp = top + Radius;
            int btm = top + height - Radius;

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

        public bool IsTouching(Ball ball)
        {
            float d = (Center.X - ball.Center.X) * (Center.X - ball.Center.X) + (Center.Y - ball.Center.Y) * (Center.Y - ball.Center.Y);
            return d <= (Radius + ball.Radius) * (Radius + ball.Radius);
        }

    }
}
