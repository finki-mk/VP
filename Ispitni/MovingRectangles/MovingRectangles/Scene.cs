using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MovingRectangles
{
    [Serializable]
    class Scene
    {
        public List<Rectangle> Rectangles { get; set; }

        public Scene()
        {
            Rectangles = new List<Rectangle>();
        }

        public void AddRectangle(int x, int y, Color color)
        {
            Rectangle r = new Rectangle();
            r.X = x - 50;
            r.Y = y - 25;
            r.Width = 100;
            r.Height = 50;
            r.Color = color;
            Rectangles.Add(r);
        }

        public void Draw(Graphics g)
        {
            foreach (Rectangle r in Rectangles)
            {
                r.Draw(g);
            }
        }

        public void Check(int width, int height)
        {
            for (int i = Rectangles.Count - 1; i >= 0; --i)
            {
                if (Rectangles[i].X > width)
                {
                    Rectangles.RemoveAt(i);
                }
                else
                    if (Rectangles[i].Y > height)
                    {
                        Rectangles.RemoveAt(i);
                    }
            }
        }

        public void StartMoving(int x, int y, Rectangle.MoveDirection direction)
        {
            foreach(Rectangle r in Rectangles)
            {
                if (r.IsHit(x, y))
                {
                    if (r.State == Rectangle.MoveDirection.STILL)
                    {
                        r.State = direction;
                    }
                }
            }
        }

        public void Move()
        {
            foreach (Rectangle r in Rectangles)
            {
                if (r.State == Rectangle.MoveDirection.DOWN)
                {
                    r.Down();
                }
                else if (r.State == Rectangle.MoveDirection.RIGHT)
                {
                    r.Right();
                }
            }
        }
    }
}
