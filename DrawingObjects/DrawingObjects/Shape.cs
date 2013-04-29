using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DrawingObjects
{
    public abstract class Shape
    {
        public float X { get; set; }
        public float Y { get; set; }

        public bool Selected { get; set; }

        public Brush Brush { get; set; }

        public Pen SelectedPen { get; set; }

        public Shape(float x, float y, Brush brush)
        {
            X = x;
            Y = y;
            Brush = brush;
            SelectedPen = new Pen(Color.Red, 3);
        }

        public abstract void Draw(Graphics g);

        public abstract bool IsHit(float x, float y);

        public void Move(float dx, float dy)
        {
            X += dx;
            Y += dy;
        }
    }
}
