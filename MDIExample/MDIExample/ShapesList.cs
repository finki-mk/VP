using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MDIExample
{
    public class ShapesList
    {
        public List<Shape> Shapes;
        static readonly int START_X = 10;
        static readonly int Y = 100;
        static readonly int OFFSET = 50;

        public ShapesList()
        {
            Shapes = new List<Shape>();
        }

        public void AddShape(Shape shape)
        {
            shape.Position = new Point(START_X + (Shapes.Count * (Shape.WIDTH + OFFSET)), Y);
            Shapes.Add(shape);
        }

        public void DrawShapes(Graphics g)
        {
            foreach (Shape s in Shapes)
            {
                s.Draw(g);
            }
        }
    }
}
