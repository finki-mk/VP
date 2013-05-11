using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace BallsChaos
{
    [Serializable]
    public class BallsDoc
    {
        public List<Ball> Balls { get; set; }

        public BallsDoc()
        {
            Balls = new List<Ball>();
        }

        public void Draw(Graphics g)
        {
            foreach (Ball ball in Balls)
            {
                ball.Draw(g);
            }
        }

        public void AddBall(Ball ball)
        {
            Balls.Add(ball);
        }

        public void MoveBalls(int left, int top, int width, int height)
        {
            foreach (Ball ball in Balls)
            {
                ball.Move(left, top, width, height);
            }
        }

        public void CheckColisions()
        {
            for (int i = 0; i < Balls.Count; i++)
            {
                for (int j = i + 1; j < Balls.Count; j++)
                {
                    if (Balls[i].IsColiding(Balls[j]))
                    {
                        Balls[i].IsColided = true;
                        Balls[j].IsColided = true;
                    }
                }
            }

            for (int i = Balls.Count - 1; i >= 0; i--)
            {
                if (Balls[i].IsColided)
                {
                    Balls.RemoveAt(i);
                }
            }
        }
    }
}
