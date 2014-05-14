using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MDIExample
{
    public abstract class Shape
    {
        public Point Position;
        public static readonly int WIDTH = 60;

        public Shape()
        {
        }

        public abstract void Draw(Graphics g);
    }
}
