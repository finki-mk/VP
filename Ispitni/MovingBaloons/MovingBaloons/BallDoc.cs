using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Zadaca2
{
    [Serializable]
    public class BallDoc
    {
        public List<Ball> Balls { get; set; }

        public BallDoc()
        {
            Balls = new List<Ball>();
        }

        public void AddBall(Point point, Color color)
        {
            Ball ball = new Ball(point, color);
            Balls.Add(ball);
        }

        public void DrawBalls(Graphics g)
        {
            foreach (Ball ball in Balls)
            {
                ball.Draw(g);
            }
        }

        public void Tick(int height)
        {
            foreach (Ball ball in Balls)
            {
                if (ball.IsMoving)
                {
                    ball.Move(height);
                }
            }
        }

        public void StartMoving(Point point)
        {
            foreach (Ball ball in Balls)
            {
                if (Distance(point, ball.Center) <= Ball.RADIUS)
                {
                    ball.IsMoving = !ball.IsMoving;
                }
            }
        }

        private double Distance(Point p1, Point p2)
        {
            return Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y));
        }
    
    }
}
