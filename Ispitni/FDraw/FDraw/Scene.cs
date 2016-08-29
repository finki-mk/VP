using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Diagnostics;

namespace FDraw
{
    [Serializable]
    class Scene
    {
        private Point startPosition;
        private Point currentPosition;
        private Color color;
        Shape selected;
        List<Shape> shapes;

        public Scene()
        {
            shapes = new List<Shape>();
            color = Color.Blue;
            selected = null;
        }

        public void MouseDown(Point position)
        {
            startPosition = position;
            foreach (Shape shape in shapes)
            {
                if (shape.Select(position))
                {
                    selected = shape;
                    return;
                }
            }
        }

        public void MouseUp(Point point)
        {
            if (selected != null)
            {
                selected = null;
                startPosition = Point.Empty;
                return;
            }
            Rectangle rectangle = new Rectangle();
            rectangle.Position = getPosition();
            rectangle.Width = getWidth();
            rectangle.Height = getHeight();
            rectangle.Color = color;
            shapes.Add(rectangle);
            startPosition = Point.Empty;
        }


        public void Move(Point point, bool controlDown)
        {
            if (selected != null)
            {
                selected.Move(point.X - startPosition.X, point.Y - startPosition.Y);
                startPosition = point;
                return;
            }
            if (controlDown)
            {
                int dx = startPosition.X - point.X;
                int dy = startPosition.Y - point.Y;
                int offset = Math.Max(Math.Abs(dx), Math.Abs(dy));
                int xm = dx < 0 ? 1 : -1;
                int ym = dy < 0 ? 1 : -1;
                currentPosition = new Point(startPosition.X + offset * xm, startPosition.Y + offset * ym);
            }
            else
            {
                currentPosition = point;
            }
        }

        public void Draw(Graphics g)
        {
            foreach (Shape shape in shapes)
            {
                shape.Draw(g);
            }
            if (selected == null && !startPosition.IsEmpty)
            {
                Pen pen = new Pen(Color.Black, 2);
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                Point position = getPosition();
                g.DrawRectangle(pen, position.X, position.Y, getWidth(), getHeight());
                pen.Dispose();
            }
        }

        Point getPosition()
        {
            return new Point(Math.Min(currentPosition.X, startPosition.X), Math.Min(currentPosition.Y, startPosition.Y));
        }

        int getWidth()
        {
            return Math.Abs(currentPosition.X - startPosition.X);
        }
        int getHeight()
        {
            return Math.Abs(currentPosition.Y - startPosition.Y);
        }

        public void ChangeColor(Color color)
        {
            this.color = color;
        }
        public int Count
        {
            get
            {
                return shapes.Count;
            }
        }
    }
}
