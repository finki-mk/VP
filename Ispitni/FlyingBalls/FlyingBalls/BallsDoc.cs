using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace FlyingBalls
{
    [Serializable]
    public class BallsDoc
    {
        public List<Ball> Balls { get; set; }

        public int Hits { get; set; }
        public int Missed { get; set; }
        public bool Paused { get; set; }

        public BallsDoc()
        {
            Balls = new List<Ball>();
            Hits = 0;
            Missed = 0;
            Paused = false;
        }

        public void AddBall(Point center)
        {
            Ball b = new Ball();
            b.Center = center;
            Balls.Add(b);
        }

        public void Hit(Point position)
        {
            foreach (Ball b in Balls)
            {
                b.Hit(position);
            }
            for (int i = Balls.Count - 1; i >= 0; --i)
            {
                if (Balls[i].State == 3)
                {
                    Balls.RemoveAt(i);
                    Hits++;
                }
            }
        }

        public void Move(int width)
        {
            foreach (Ball b in Balls)
            {
                b.Move();
                if (b.Center.X > width + Ball.RADIUS)
                {
                    b.State = -1;
                }                
            }
            for (int i = Balls.Count - 1; i >= 0; --i)
            {
                if (Balls[i].State == -1)
                {
                    Balls.RemoveAt(i);
                    Missed++;
                }
            }
        }

        public void Draw(Graphics g)
        {
            foreach (Ball b in Balls)
            {
                b.Draw(g);
            }
        }
    }
}
