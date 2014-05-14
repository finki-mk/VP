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
        private Color currentColor;
        private PolygonDoc polygonDoc;
        private Point startPoint;
        private Point previousPoint;
        private Point currentPoint;
        private Polygon currentPolygon;
        private double distance;
        private bool drawSquare;
        private string FileName;

        public Form1()
        {
            InitializeComponent();
            newDoc();
            this.DoubleBuffered = true;
            currentColor = Color.Blue;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (startPoint.IsEmpty)
            {
                startPoint = e.Location;
                currentPolygon = new Polygon(currentColor);
                currentPolygon.AddPoint(startPoint);
                previousPoint = startPoint;
            }
            else
            {
                if (drawSquare)
                {
                    currentPolygon.IsClosed = true;
                    startPoint = Point.Empty;
                    previousPoint = Point.Empty;
                    drawSquare = false;
                    if (currentPolygon.Points.Count >= 3)
                    {
                        polygonDoc.AddPolygon(currentPolygon);
                        setTitle();
                    }
                }
                else
                {
                    currentPolygon.AddPoint(e.Location);
                    previousPoint = e.Location;
                }
            }
            Invalidate(true);
        }

        private double distanceSquared(Point p1, Point p2)
        {
            return (p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            if (currentPolygon != null)
            {
                currentPolygon.Draw(e.Graphics);
            }
            polygonDoc.Draw(e.Graphics);
            Pen squarePen = new Pen(Color.Black, 2);
            squarePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Pen linePen = new Pen(Color.Black, 1);
            linePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            if (drawSquare)
            {
                e.Graphics.DrawRectangle(squarePen, startPoint.X - 5, startPoint.Y - 5, 10, 10);
            }
            if (!startPoint.IsEmpty)
            {
                e.Graphics.DrawLine(linePen, previousPoint, currentPoint);
            }
            squarePen.Dispose();
            linePen.Dispose();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!startPoint.IsEmpty)
            {
                distance = distanceSquared(e.Location, startPoint);
                drawSquare = (distance <= 25);
            }
            currentPoint = e.Location;
            Invalidate(true);
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                currentColor = colorDialog.Color;
            }
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            toolStripTotalPolygons.Text = string.Format("# Polygons: {0}", polygonDoc.Polygons.Count);
            toolStripCurrentPosition.Text = string.Format("{0}, {1}", currentPoint.X, currentPoint.Y);
        }

        private void saveFile()
        {
            if (FileName == "Untitled")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Polygons doc file (*.pgn)|*.pgn";
                saveFileDialog.Title = "Save polygons doc";
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
                    formatter.Serialize(fileStream, polygonDoc);
                }
                polygonDoc.IsChanged = false;
                setTitle();
            }
        }
        private void openFile()
        {
            askToSave();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Polygons doc file (*.pgn)|*.pgn";
            openFileDialog.Title = "Open polygons doc file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                try
                {
                    using (FileStream fileStream = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formater = new BinaryFormatter();
                        polygonDoc = (PolygonDoc)formater.Deserialize(fileStream);
                    }
                    setTitle();
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

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }
        private void newDoc()
        {
            askToSave();
            FileName = "Untitled";
            polygonDoc = new PolygonDoc();
            currentPolygon = null;
            startPoint = Point.Empty;
            previousPoint = Point.Empty;
            setTitle();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newDoc();
            Invalidate(true);
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

        private void askToSave()
        {
            if (polygonDoc != null && polygonDoc.IsChanged)
            {
                DialogResult result = MessageBox.Show("Save document changes?", "Save document?", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    saveFile();
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            askToSave();
        }

        private void setTitle()
        {
            this.Text = string.Format("Draw Polygons - {0}{1}", FileName, polygonDoc.IsChanged ? "*" : "");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if (polygonDoc != null)
                {
                    polygonDoc.Move(0, 5);
                }
            }
            if (e.KeyCode == Keys.Up)
            {
                if (polygonDoc != null)
                {
                    polygonDoc.Move(0, -5);
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                if (polygonDoc != null)
                {
                    polygonDoc.Move(5, 0);
                }
            }
            if (e.KeyCode == Keys.Left)
            {
                if (polygonDoc != null)
                {
                    polygonDoc.Move(-5, 0);
                }
            }
            Invalidate(true);
        }
    }
}