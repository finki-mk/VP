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
        private ShapesList shapesList;

        private SHAPE_TYPE CurrentType;
        private Color currentColor;
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
            shapesList = new ShapesList();
            CurrentType = SHAPE_TYPE.CIRCLE;
            currentColor = Color.Blue;
            this.DoubleBuffered = true;
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
            
            if (CurrentType == SHAPE_TYPE.CIRCLE)
            {
                shapesList.AddShape(e.X, e.Y, currentColor, ShapesList.SHAPE_TYPE.CIRCLE);
            }
            else if (CurrentType == SHAPE_TYPE.SQUARE)
            {
                shapesList.AddShape(e.X, e.Y, currentColor, ShapesList.SHAPE_TYPE.SQUARE);
            }
            
            Invalidate();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            shapesList.Select(e.X, e.Y);
            Invalidate();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            selectedShape = shapesList.Select(e.X, e.Y);
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
                    Invalidate();
                }                
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
                currentColor = colorDialog.Color;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            shapesList.Draw(e.Graphics);
        }
    }
}
