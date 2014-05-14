using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MDIExample
{
    class Star : Shape
    {
        
        public override void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color.Yellow);
            Rectangle rect = new Rectangle(Position.X - WIDTH / 2, Position.Y - WIDTH / 2, WIDTH,WIDTH);
            g.FillPolygon(brush, StarPoints(5, rect));
            brush.Dispose();
        }

        private PointF[] StarPoints(int num_points, Rectangle bounds)
        {
            // Make room for the points.
            PointF[] pts = new PointF[num_points];
            double rx = bounds.Width / 2;
            double ry = bounds.Height / 2;
            double cx = bounds.X + rx;
            double cy = bounds.Y + ry;

            // Start at the top.
            double theta = -Math.PI / 2;
            double dtheta = 4 * Math.PI / num_points;
            for (int i = 0; i < num_points; i++)
            {
                pts[i] = new PointF(
                (float)(cx + rx * Math.Cos(theta)),
                (float)(cy + ry * Math.Sin(theta)));
                theta += dtheta;
            }

            return pts;
        }
    }
}
