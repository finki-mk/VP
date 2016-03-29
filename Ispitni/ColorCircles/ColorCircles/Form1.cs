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

namespace ColorCircles
{
    public partial class Form1 : Form
    {
        private CirclesDoc doc;
        private Point currentPoint;
        private Point previousPoint;
        private Color currentColor;
        private string FileName;
        private int radius;

        public Form1()
        {
            InitializeComponent();
            newDoc();
            this.DoubleBuffered = true;
            currentColor = Color.Green;
        }

        private void newDoc()
        {
            doc = new CirclesDoc();
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
                    doc.AddCircle(previousPoint, radius, currentColor);
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
            radius = (int)Math.Sqrt(Circle.Distance(currentPoint, previousPoint));
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            doc.Draw(e.Graphics);
            if (!previousPoint.IsEmpty)
            {
                Pen linePen = new Pen(Color.Black, 3);
                linePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                e.Graphics.DrawEllipse(linePen, previousPoint.X - radius, previousPoint.Y - radius, radius * 2, radius * 2);
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
            if (e.KeyCode == Keys.Escape)
            {
                previousPoint = Point.Empty;
                Invalidate();
            }
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("Circles: {0}", doc.Circles.Count);
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
                saveFileDialog.Filter = "Circles doc file (*.crl)|*.crl";
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
                    formatter.Serialize(fileStream, doc);
                }
            }
        }
        private void openFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Circles doc file (*.crl)|*.crl";
            openFileDialog.Title = "Open Circles doc file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                try
                {
                    using (FileStream fileStream = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formater = new BinaryFormatter();
                        doc = (CirclesDoc)formater.Deserialize(fileStream);
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
