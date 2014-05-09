using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DrawingObjects
{
    class ShapesList
    {
        public List<Shape> Shapes;
        public const float RADIUS = 40;
        public enum SHAPE_TYPE {
            CIRCLE,
            SQUARE
        }

        public ShapesList()
        {
            Shapes = new List<Shape>();
        }

        public void AddShape(float x, float y, Color color, SHAPE_TYPE type)
        {
            Shape s = null;
            if (type == SHAPE_TYPE.CIRCLE)
            {
                s = new Circle(x, y, RADIUS, color);
            }
            else if (type == SHAPE_TYPE.SQUARE)
            {
                s = new Square(x, y, RADIUS * 2, RADIUS * 2, color); 
            }
            Shapes.Add(s);
        }

        public void Draw(Graphics g)
        {
            foreach (Shape s in Shapes)
            {
                s.Draw(g);
            }
        }

        public Shape Select(float x, float y)
        {
            foreach (Shape s in Shapes)
            {
                if (s.IsHit(x, y))
                {
                    s.Selected = !s.Selected;
                    return s;
                }
            }
            return null;
        }
    }
}
