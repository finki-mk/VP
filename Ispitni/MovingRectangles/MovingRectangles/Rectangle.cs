using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MovingRectangles
{
    [Serializable]
    public class Rectangle
    {
        public enum MoveDirection
        {
            STILL,
            RIGHT,
            DOWN
        }
        public MoveDirection State = MoveDirection.STILL;
        public int X { get; set; }
        public int Y { get; set; }

        public int Width { get; set; }
        public int Height { get; set; }

        public Color Color { get; set; }

        private int up = 1;

        public void Draw(Graphics g)
        {
            Brush solid = new SolidBrush(Color);
            g.FillRectangle(solid, X, Y, Width, Height);
            solid.Dispose();
            up = 1;
        }

        public void Right()
        {
            X = X + Width;
            Y = Y + (Height - Width) * up;
            up *= -1;
            int tmp = Width;
            Width = Height;
            Height = tmp;
        }

        public void Down()
        {
            Y = Y + Height;
        }
        public bool IsHit(int x, int y)
        {
            return X <= x && x <= X + Width && y >= Y && y <= Y + Height;
        }
    }
}
