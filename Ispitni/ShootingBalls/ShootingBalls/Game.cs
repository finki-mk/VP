using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ShootingBalls
{
    [Serializable]
    class Game
    {
        private List<Ball> balls;

        private int width;
        private int height;
        private Random random;
        private int points;
        private Ball bomb;

        public Game(int width, int height)
        {
            this.width = width;
            this.height = height;
            this.random = new Random();
            this.balls = new List<Ball>();
            this.points = 0;
        }

        public void Generate()
        {
            Point position = new Point(random.Next(100, width - 100), random.Next(100, height - 100));
            Ball ball = new Ball(position, random);
            bool colide = false;
            foreach (Ball b in balls)
            {
                if (b.Colide(ball))
                {
                    colide = true;
                }
            }
            if (colide)
            {
                Generate();
            }
            else
            {
                balls.Add(ball);
            }
        }

        public void Bomb(Point point)
        {
            bomb = new Ball(point, 50, Color.Black);
        }

        public void Draw(Graphics g)
        {
            balls.ForEach(b => b.Draw(g));
            if (bomb != null)
            {
                bomb.Draw(g);
            }
        }

        public void Tick()
        {
            for (int i = balls.Count - 1; i >= 0; --i)
            {
                if (balls[i].Tick())
                {
                    balls.RemoveAt(i);
                }
                if (bomb != null)
                {
                    if (balls[i].Colide(bomb))
                    {
                        balls.RemoveAt(i);
                        points += 1;
                    }
                }
            }
            if (bomb != null)
            {
                bomb = null;
            }
        }

        public void Hit(Point position)
        {
            balls.ForEach(it =>
            {
                points += it.Hit(position);
            });
        }

        public int Points { get { return points; } }
    }
}
