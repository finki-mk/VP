using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrawLines2
{
    public partial class Form1 : Form
    {
        LinesDocument document;

        public Form1()
        {
            InitializeComponent();
            document = new LinesDocument(Width, Height);
            normalToolStripMenuItem.Checked = true;
            DoubleBuffered = true;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            document.AddLine(e.Location);
            Invalidate(true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            document.Draw(e.Graphics);
        }

        private void thinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            document.Thicknes = 1;
            thinToolStripMenuItem.Checked = true;
            thickToolStripMenuItem.Checked = false;
            normalToolStripMenuItem.Checked = false;
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            document.Thicknes = 2;
            thinToolStripMenuItem.Checked = false;
            thickToolStripMenuItem.Checked = false;
            normalToolStripMenuItem.Checked = true;
        }

        private void thickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            document.Thicknes = 3;
            thinToolStripMenuItem.Checked = false;
            thickToolStripMenuItem.Checked = true;
            normalToolStripMenuItem.Checked = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            document.UpdateLocation(e.Location);
            Invalidate(true);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                document.Move(0, -5);
            }
            else if (e.KeyCode == Keys.Down)
            {
                document.Move(0, 5);
            }
            else if (e.KeyCode == Keys.Left)
            {
                document.Move(-5, 0);
            }
            else if (e.KeyCode == Keys.Right)
            {
                document.Move(5, 0);
            }
            Invalidate();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == 
                System.Windows.Forms.DialogResult.OK)
            {
                document.CurrentColor = colorDialog.Color;
            }
        }

        private void positionerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            document.Positioner = positionerToolStripMenuItem.Checked;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            document = new LinesDocument(Width, Height);
            Invalidate(true);
        }

        private void toolStripStatusLabelLines_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabelLines.Text = string.Format("Lines: {0}", document.GetLinesCount());
            toolStripStatusLabel1.Text = string.Format("X: {0}, Y: {1}", document.CurrentLocation.X, document.CurrentLocation.Y);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            document.Undo();
            Invalidate(true);
        }

       
    }
}
