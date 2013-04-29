using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DrawingObjects
{
    public class Square : Shape
    {
        public float Width { get; set; }

        public float Height { get; set; }

        public Square(float x, float y, float width, float height, Brush brush)
            : base(x, y, brush)
        {
            Width = width;
            Height = height;
        }

        public override void Draw(Graphics g)
        {
            g.FillRectangle(Brush, X - Width / 2, Y - Width / 2, Width, Height);
            if (Selected)
            {
                g.DrawRectangle(SelectedPen, X - Width / 2, Y - Width / 2, Width, Height);
            }
        }

        public override bool IsHit(float x, float y)
        {
            return Math.Abs(X - x) <= Width / 2 && Math.Abs(Y - y) <= Height / 2;
        }
    }
}
