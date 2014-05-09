using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Polygons
{
    public partial class Form1 : Form
    {
        Color currentColor;
        PolygonDoc doc;
        Point previousPoint;
        Point firstPoint;
        Point currentPoint;
        Polygon polygon;
        public Form1()
        {
            InitializeComponent();
            
            this.DoubleBuffered = true;
            currentColor = Color.Blue;
            doc = new PolygonDoc();
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (firstPoint.IsEmpty)
            {
                firstPoint = e.Location;
                polygon = new Polygon(currentColor);
                polygon.AddPoint(firstPoint);
                previousPoint = firstPoint;
            }
            else
            {
                previousPoint = e.Location;
                if (closeToFirstPoint(firstPoint, previousPoint))
                {
                    polygon.IsClosed = true;
                    doc.AddPolygon(polygon);
                    polygon = null;
                    firstPoint = Point.Empty;
                    previousPoint = Point.Empty;
                }
                else
                { 
                    polygon.AddPoint(previousPoint);
                }
            }           
            
            Invalidate();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            currentPoint = e.Location;
            Invalidate();
        }

        bool closeToFirstPoint(Point firstPoint, Point currentPoint)
        {
            return ((firstPoint.X - currentPoint.X) * (firstPoint.X - currentPoint.X) +
                (firstPoint.Y - currentPoint.Y) * (firstPoint.Y - currentPoint.Y)) <= 10 * 10;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            if (!previousPoint.IsEmpty)
            {
                Pen dashedPen = new Pen(Color.Black, 2);
                dashedPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                e.Graphics.DrawLine(dashedPen, previousPoint, currentPoint);
                dashedPen.Dispose();
            }

            if (polygon != null)
            {
                polygon.Draw(e.Graphics);
            }

            if (closeToFirstPoint(firstPoint, currentPoint))
            {
                Pen dashedPen = new Pen(Color.Black, 1);
                dashedPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                e.Graphics.DrawRectangle(dashedPen, firstPoint.X - 5, firstPoint.Y - 5, 10, 10);
                dashedPen.Dispose();
            }

            doc.Draw(e.Graphics);
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                doc.Move(0, -20);
            }
            if (e.KeyCode == Keys.Down)
            {
                doc.Move(0, 20);
            }

            if (e.KeyCode == Keys.Left)
            {
                doc.Move(-20, 0);
            }

            if (e.KeyCode == Keys.Right)
            {
                doc.Move(20, 0);
            }
            Invalidate();
        }



        
    }
}
