using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace BallsInHoles
{
    [Serializable]
    public class BallsDoc
    {
        public List<Ball> Balls { get; set; }
        Random random;
        Font font;

        public BallsDoc()
        {
            Balls = new List<Ball>();
            font = new Font("Arial", 20);
            random = new Random();
        }

        public void Draw(Graphics g)
        {
            foreach (Ball ball in Balls)
            {
                ball.Draw(g, font);
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
            for (int i = 0; i < Balls.Count; ++i)
            {
                for (int j = i + 1; j < Balls.Count; ++j)
                {
                    if (i != j && Balls[i].IsTouching(Balls[j]))
                    {
                        if (Balls[i].Radius > Balls[j].Radius)
                        {
                            Balls[i].Power += 1;
                            Balls[j].Power -= 1;
                        }
                        else if (Balls[i].Radius < Balls[j].Radius)
                        {
                            Balls[j].Power += 1;
                            Balls[i].Power -= 1;
                        }
                    }
                }
            }
            for (int i = Balls.Count - 1; i >= 0; i--)
            {
                if (Balls[i].Power < 0)
                {
                    Balls.RemoveAt(i);
                }
            }
        }
    }
}
