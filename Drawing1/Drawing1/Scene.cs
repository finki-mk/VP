using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Drawing1
{
    class Scene
    {
        private List<Shape> shapes;
        public Color CurrentColor { get; set; }
        private Shape selectedShape;
        private int selectedIndex;
        private Point previousPoint;

        public enum ShapeType {
            CIRCLE,
            TRIANGLE
        }

        public Scene()
        {
            shapes = new List<Shape>();
            CurrentColor = Color.Red;
            selectedShape = null;
        }

        public void Draw(Graphics g)
        {
            foreach (Shape shape in shapes)
            {
                shape.Draw(g);
            }
        }

        public void AddShape(Point position, ShapeType type)
        {
            Shape shape = null;
            if (type == ShapeType.CIRCLE)
                shape = new Circle(position, CurrentColor);
            else if (type == ShapeType.TRIANGLE)
                shape = new Triangle(position, CurrentColor,
                    new Point(position.X + 30, position.Y),
                    new Point(position.X, position.Y + 20));
            shapes.Add(shape);
        }

        // On mouse down
        public void Select(Point position)
        {

            foreach (Shape shape in shapes)
            {
                if (shape.Clicked(position))
                {
                    selectedShape = shape;
                    selectedShape.Selected = true;
                }
            }
            previousPoint = position;
        }

        public bool SelectedShape
        {
            get
            {
                return selectedShape != null;
            }
        }

        // On mouse move
        public void MoveShape(Point position)
        {
            int dx = position.X - previousPoint.X;
            int dy = position.Y - previousPoint.Y;
            selectedShape.Position = new Point(
                selectedShape.Position.X + dx,
                selectedShape.Position.Y + dy);
            previousPoint = position;
        }

        // On mouse up
        public void ClearSelected()
        {
            selectedShape.Selected = false;
            selectedShape = null;
            
        }

        public void Pulse(int percent)
        {
            foreach (Shape shape in shapes)
            {
                shape.Pulse(percent);
            }
        }



    }
}
