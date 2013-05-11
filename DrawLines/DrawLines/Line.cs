using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DrawLines
{
    [Serializable]
    public class Line
    {
        public Point Start { get; set; }

        public Point End { get; set; }

        public int Width { get; set; }

        public Line(Point start, Point end, int width)
        {
            Start = start;
            End = end;
            Width = width;
        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black, Width);
            g.DrawLine(pen, Start, End);
            pen.Dispose();
        }
    }
}
