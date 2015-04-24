using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DrawLines2
{
    public class Line
    {
        public Point Start { get; set; }
        public Point End { get; set; }
        public Color Color { get; set; }
        public float Thicknes { get; set; }

        public Line(Point s, Point e, float t, Color color)
        {
            Start = s;
            End = e;
            Thicknes = t;
            Color = color;
        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color, Thicknes);
            g.DrawLine(pen, Start, End);
            pen.Dispose();
        }
    }
}
