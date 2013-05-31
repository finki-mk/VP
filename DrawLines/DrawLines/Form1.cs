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

namespace DrawLines
{
    public partial class Form1 : Form
    {
        private Point previusPoint;
        private Point currentPoint;
        private bool hasPosioner;

        private Pen dashedPen;
        private Pen solidPen;
        private LinesDoc linesDoc;
        private int width;

        private static readonly int THIN_LINE = 1;
        private static readonly int MEDIUM_LINE = 2;
        private static readonly int THICK_LINE = 3;

        private string FileName;

        public Form1()
        {
            InitializeComponent();
            currentPoint = new Point();
            dashedPen = new Pen(Color.Black, 1);
            dashedPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            solidPen = new Pen(Color.Black, 3);
            DoubleBuffered = true;
            hasPosioner = true;
            linesDoc = new LinesDoc();
            width = 3;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (previusPoint.IsEmpty)
            {
                previusPoint = new Point(e.X, e.Y);
            }
            else
            {
                Point current = new Point(e.X, e.Y);
                linesDoc.AddLine(previusPoint, current, width);
                previusPoint = current;
                Invalidate(true);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            currentPoint.X = e.X;
            currentPoint.Y = e.Y;
            Invalidate(true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            if (hasPosioner)
            {
                e.Graphics.DrawLine(dashedPen, currentPoint.X, 0, currentPoint.X, Height);
                e.Graphics.DrawLine(dashedPen, 0, currentPoint.Y, Width, currentPoint.Y);
            }
            linesDoc.DrawLines(e.Graphics);
            
        }

        private void positionerToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void positionerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            positionerToolStripMenuItem.Checked = !positionerToolStripMenuItem.Checked;
            hasPosioner = !hasPosioner;
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            width = MEDIUM_LINE;
        }

        private void thinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            width = THIN_LINE;
        }

        private void tickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            width = THICK_LINE;
        }
        // Always is invoked with Invalidate(true);
        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusTest.Text = "NEKOE NOVO";
            toolStripStatusNumberOfLines.Text = string.Format("Total lines: {0}", linesDoc.Lines.Count);
            toolStripStatusPosition.Text = string.Format("{0}, {1}", currentPoint.X, currentPoint.Y);
        }

        private void saveFile()
        {
            if (FileName == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Lines doc file (*.lin)|*.lin";
                saveFileDialog.Title = "Save lines doc";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileName = saveFileDialog.FileName;
                }
            }
            if (FileName != null)
            {
                using (FileStream fileStream = new FileStream(FileName, FileMode.Create))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, linesDoc);
                }
            }
        }
        private void openFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Lines doc file (*.lin)|*.lin";
            openFileDialog.Title = "Open lines file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                try
                {
                    using (FileStream fileStream = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formater = new BinaryFormatter();
                        linesDoc = (LinesDoc)formater.Deserialize(fileStream);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not read file: " + FileName);
                    FileName = null;
                    return;
                }
                Invalidate(true);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            linesDoc = new LinesDoc();
            Invalidate(true);
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            linesDoc = new LinesDoc();
            Invalidate(true);
        }
    }
}
