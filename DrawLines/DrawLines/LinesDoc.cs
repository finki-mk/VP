using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DrawLines
{
    [Serializable]
    public class LinesDoc
    {
        public List<Line> Lines { get; set; }

        public LinesDoc()
        {
            Lines = new List<Line>();
        }

        public void AddLine(Point start, Point end, int width)
        {
            Line line = new Line(start, end, width);
            Lines.Add(line);
        }

        public void DrawLines(Graphics g)
        {
            foreach (Line line in Lines)
            {
                line.Draw(g);
            }
        }
    }
}
