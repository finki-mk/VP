using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace FDraw
{
    [Serializable]
    class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public override void Draw(Graphics g)
        {
            Brush solid = new SolidBrush(Color);
            g.FillRectangle(solid, Position.X, Position.Y, Width, Height);
            solid.Dispose();
        }

        public override bool Select(Point point)
        {
            return point.X >= Position.X && point.X <= Position.X + Width && point.Y >= Position.Y && point.Y <= Position.Y + Height;
        }
    }
}
