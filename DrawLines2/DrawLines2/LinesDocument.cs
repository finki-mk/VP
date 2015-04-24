using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DrawLines2
{
    class LinesDocument
    {

        List<Line> lines;
        public float Thicknes { get; set; }
        public Color CurrentColor { get; set; }
        Point previousLocation;
        Point currentLocation;
        public bool Positioner { get; set; }
        int width;
        int height;

        Stack<Action> actions;
        

        public LinesDocument(int width, int height)
        {
            Thicknes = 2;
            lines = new List<Line>();
            previousLocation = Point.Empty;
            Positioner = true;
            this.width = width;
            this.height = height;
            CurrentColor = Color.Black;
            actions = new Stack<Action>();
        }

        public void AddLine(Point location)
        {
            Action addAction = new Action();
            addAction.ActionType = Action.Type.ADD;
            if (!previousLocation.IsEmpty)
            {
                Line line = new Line(previousLocation, 
                    location, Thicknes, CurrentColor);
                lines.Add(line);
                addAction.Line = line;
                actions.Push(addAction);
            }
            previousLocation = location;

            
        }

        public void Draw(Graphics g)
        {
            foreach (Line line in lines)
            {
                line.Draw(g);
            }
            if (Positioner)
            {
                Pen pen = new Pen(Color.Gray, 1);
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                // Horisontal line
                g.DrawLine(pen, new Point(0, currentLocation.Y), 
                    new Point(width, currentLocation.Y));
                // Vertical line
                g.DrawLine(pen, new Point(currentLocation.X, 0), 
                    new Point(currentLocation.X, height));
                pen.Dispose();
            }
        }

        public void UpdateLocation(Point location)
        {
            currentLocation = location;
        }

        public int GetLinesCount()
        {
            return lines.Count;
        }

        public void Move(int dx, int dy)
        {
            foreach (Line line in lines)
            {
                line.Start = new Point(line.Start.X + dx, 
                    line.Start.Y + dy);
                line.End = new Point(line.End.X + dx, 
                    line.End.Y + dy);
                previousLocation = line.End;
            }
        }

        public Point CurrentLocation
        {
            get
            {
                return currentLocation;
            }
        }

        public void Undo()
        {
            if (actions.Count != 0)
            {
                Action action = actions.Pop();
                if (action.ActionType == Action.Type.ADD)
                {
                    lines.RemoveAt(lines.Count - 1);
                }
            }
        }
    }
}
