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

        public Square(float x, float y, float width, float height, Color color)
            : base(x, y, color)
        {
            Width = width;
            Height = height;
        }

        public override void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            g.FillRectangle(b, X - Width / 2, Y - Width / 2, Width, Height);
            if (Selected)
            {
                Pen p = new Pen(Color.Red, 3);
                g.DrawRectangle(p, X - Width / 2, Y - Width / 2, Width, Height);
                p.Dispose();
            }
            b.Dispose();
        }

        public override bool IsHit(float x, float y)
        {
            return Math.Abs(X - x) <= Width / 2 && Math.Abs(Y - y) <= Height / 2;
        }
    }
}
