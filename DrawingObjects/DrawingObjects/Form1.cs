using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrawingObjects
{
    public partial class Form1 : Form
    {
        private List<Shape> shapes;

        private SHAPE_TYPE CurrentType;

        private Brush Brush;
        private static readonly float SIZE = 30;
        private bool mouseDown;
        private Shape selectedShape;
        private float prevX;
        private float prevY;

        private enum SHAPE_TYPE
        {
            CIRCLE,
            SQUARE
        }

        public Form1()
        {
            InitializeComponent();
            shapes = new List<Shape>();
            CurrentType = SHAPE_TYPE.CIRCLE;
            Brush = new SolidBrush(Color.Blue);            
            this.DoubleBuffered = true;
        }

        private void DrawObjects(Graphics g)
        {
            g.Clear(Color.White);
            foreach (Shape shape in shapes)
            {
                shape.Draw(g);
            }
        }

        private void menuItemClicked(object sender, EventArgs e)
        {
            if (sender == circleToolStripMenuItem)
            {
                circleToolStripMenuItem.Checked = true;
                squareToolStripMenuItem.Checked = false;
                CurrentType = SHAPE_TYPE.CIRCLE;
            }
            if (sender == squareToolStripMenuItem)
            {
                squareToolStripMenuItem.Checked = true;
                circleToolStripMenuItem.Checked = false;
                CurrentType = SHAPE_TYPE.SQUARE;
            }
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Shape shape = null;
            if (CurrentType == SHAPE_TYPE.CIRCLE)
            {
                shape = new Circle(e.X, e.Y, SIZE, Brush);

            }
            else if (CurrentType == SHAPE_TYPE.SQUARE)
            {
                shape = new Square(e.X, e.Y, SIZE * 2, SIZE * 2, Brush);
            }
            shapes.Add(shape);
            Invalidate();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (Shape shape in shapes)
            {
                if (shape.IsHit(e.X, e.Y))
                {
                    shape.Selected = !shape.Selected;
                }
            }
            Invalidate();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            selectedShape = null;
            foreach (Shape shape in shapes)
            {
                if (shape.IsHit(e.X, e.Y))
                {
                    selectedShape = shape;
                }
            }
            prevX = e.X;
            prevY = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                if (selectedShape != null)
                {
                    float dx = e.X - prevX;
                    float dy = e.Y - prevY;
                    selectedShape.Move(dx, dy);
                }
                Invalidate();
                prevX = e.X;
                prevY = e.Y;
            }            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void pickColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            DialogResult result = colorDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                Brush = new SolidBrush(colorDialog.Color);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawObjects(e.Graphics);
        }
    }
}
