using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SlidingBalls
{
    [Serializable]
    public class BallsDoc
    {
        public List<Ball> Balls;
        int touched;
        int width;
        int height;
        int dx;
        int dy;
        static readonly int MOVE_SPEED = 10;
        public BallsDoc(int width, int height)
        {
            Balls = new List<Ball>();
            touched = -1;
            this.width = width;
            this.height = height;
            dx = 0;
            dy = 0;
        }

        public void AddBall(Point position)
        {
            Random r = new Random();
            int x = r.Next(2);
            Ball ball = null;
            if (x == 0)
            {
                ball = new Ball(Color.Blue, position);
            }
            else if (x == 1)
            {
                ball = new Ball(Color.Green, position);
            }
            Balls.Add(ball);
        }

        public void AddRed(Point position)
        {
            Ball ball = new Ball(Color.Red, position);
            Balls.Add(ball);
        }

        public bool Click(Point position)
        {
            if (touched != -1) return false;
            for (int i = 0; i < Balls.Count; ++i)
            {
                if (Balls[i].Touches(position))
                {
                    touched = i;
                    break;
                }
            }
            if (touched != -1)
            {
                bool moving = Balls[touched].Color.Equals(Color.Red);
                if (moving)
                {
                    Random r = new Random();
                    int dir = r.Next(4);
                    if (dir == 0) dx = MOVE_SPEED;
                    else if (dir == 1) dx = -MOVE_SPEED;
                    else if (dir == 2) dy = MOVE_SPEED;
                    else if (dir == 3) dy = -MOVE_SPEED;
                }
                return moving;
            }
            return false;
        }

        public bool Move()
        {
            Balls[touched].Position = new Point(Balls[touched].Position.X + dx, Balls[touched].Position.Y + dy);
            for (int i = Balls.Count - 1; i >= 0; --i)
            {
                if (Balls[touched].Touches(Balls[i]))
                {
                    if (Balls[i].Color.Equals(Color.Green))
                    {
                        Balls.RemoveAt(i);
                        if (i < touched)
                        {
                            --touched;
                        }
                    }
                }
            }
            if (Balls[touched].OutOfBounds(width, height))
            {
                Balls.RemoveAt(touched);
                touched = -1;
                dx = 0;
                dy = 0;
                return true;
            }
            return false;
        }

        public void Draw(Graphics g)
        {
            foreach (Ball ball in Balls)
            {
                ball.Draw(g);
            }
        }
    }
}
