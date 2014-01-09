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

namespace ColorRectangles
{
    public partial class Form1 : Form
    {
        private RectanglesDoc doc;
        private Point currentPoint;
        private Point previousPoint;
        private Color currentColor;
        private string FileName;
        private int x, y;
        private int width, height;

        public Form1()
        {
            InitializeComponent();
            newDoc();
            this.DoubleBuffered = true;
            currentColor = Color.Green;
        }

        private void newDoc()
        {
            doc = new RectanglesDoc();
            previousPoint = Point.Empty;
            currentPoint = Point.Empty;
            FileName = "Untitled";
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (previousPoint.IsEmpty)
                {
                    previousPoint = e.Location;
                }
                else
                {
                    doc.AddRectangle(new Point(x, y), width, height, currentColor);
                    previousPoint = Point.Empty;
                    currentPoint = Point.Empty;
                }
                Invalidate(true);
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                doc.Select(e.Location);
                Invalidate();
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            currentPoint = e.Location;
            x = previousPoint.X;
            y = previousPoint.Y;
            if (x > currentPoint.X) x = currentPoint.X;
            if (y > currentPoint.Y) y = currentPoint.Y;
            width = Math.Abs(previousPoint.X - currentPoint.X);
            height = Math.Abs(previousPoint.Y - currentPoint.Y);
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            doc.Draw(e.Graphics);
            if (!previousPoint.IsEmpty)
            {
                Pen linePen = new Pen(Color.Black, 1);
                linePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                e.Graphics.DrawRectangle(linePen, x, y, width, height);
                linePen.Dispose();
            }
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                doc.DeleteSelected();
                Invalidate(true);
            }
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("Rectangles: {0}", doc.Rectangles.Count);
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                currentColor = cd.Color;
            }
        }

        private void saveFile()
        {
            if (FileName == "Untitled")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Rectanges doc file (*.rct)|*.rct";
                saveFileDialog.Title = "Save rectanges doc";
                saveFileDialog.FileName = FileName;
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
                    formatter.Serialize(fileStream, doc);
                }
            }
        }
        private void openFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Rectanges doc file (*.rct)|*.rct";
            openFileDialog.Title = "Open rectanges doc file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                try
                {
                    using (FileStream fileStream = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formater = new BinaryFormatter();
                        doc = (RectanglesDoc)formater.Deserialize(fileStream);
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

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newDoc();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            newDoc();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveFile();
        }
    }
}
