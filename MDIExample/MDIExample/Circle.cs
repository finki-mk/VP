using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MDIExample
{
    class Circle :  Shape
    {
        

        public override void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color.Red);
            g.FillEllipse(brush, Position.X - WIDTH /2, Position.Y - WIDTH / 2, WIDTH, WIDTH);
            brush.Dispose();
        }
    }
}
