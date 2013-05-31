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

namespace Zadaca2
{
    public partial class Form1 : Form
    {
        private CirclesDoc circlesDoc;
        private Point previousPoint;
        private Point currentPoint;
        private string FileName;
        private int x, y;
        private int width, height;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            newDoc();
            timer1.Start();
        }

        private void newDoc()
        {
            circlesDoc = new CirclesDoc();
            previousPoint = Point.Empty;
            currentPoint = Point.Empty;
            FileName = "Untitled";
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (previousPoint.IsEmpty)
            {
                previousPoint = e.Location;
            }
            else
            {
                circlesDoc.AddCircle(new Point(x, y), width, height);
                previousPoint = Point.Empty;
                currentPoint = Point.Empty;
            }
            Invalidate(true);
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
            circlesDoc.Draw(e.Graphics);
            if (!previousPoint.IsEmpty)
            {               
                Pen linePen = new Pen(Color.Black, 1);
                linePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                e.Graphics.DrawEllipse(linePen, x, y, width, height);
                linePen.Dispose();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            circlesDoc.ChanngeColor();
            Invalidate();
        }

        private void saveFile()
        {
            if (FileName == "Untitled")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Circles doc file (*.cir)|*.cir";
                saveFileDialog.Title = "Save circles doc";
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
                    formatter.Serialize(fileStream, circlesDoc);
                }                
            }
        }
        private void openFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Circles doc file (*.cir)|*.cir";
            openFileDialog.Title = "Open circles doc file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                try
                {
                    using (FileStream fileStream = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formater = new BinaryFormatter();
                        circlesDoc = (CirclesDoc)formater.Deserialize(fileStream);
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

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            newDoc();
            Invalidate(true);
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newDoc();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("Elipses: {0}", circlesDoc.Circles.Count);
        }
    }
}
