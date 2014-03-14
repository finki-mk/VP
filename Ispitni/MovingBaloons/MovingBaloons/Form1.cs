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
        private BallDoc BallDoc;

        private static readonly int PADDING = 50;

        private Color currentColor;

        private string FileName;

        public Form1()
        {
            InitializeComponent();
            BallDoc = new BallDoc();
            currentColor = Color.Red;
            DoubleBuffered = true;
            timer1.Start();
        }

        private void tsbAddBall_Click(object sender, EventArgs e)
        {
            BallDoc.AddBall(new Point(PADDING + BallDoc.Balls.Count * (2 * Ball.RADIUS + 25), Height / 2), currentColor);
            Invalidate(true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            BallDoc.DrawBalls(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BallDoc.Tick(Height);
            Invalidate(true);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            BallDoc.StartMoving(e.Location);
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("{0}", BallDoc.Balls.Count);
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                currentColor = colorDialog.Color;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BallDoc = new BallDoc();
            Invalidate(true);
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            BallDoc = new BallDoc();
            Invalidate(true);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void saveFile()
        {
            if (FileName == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Balls doc file (*.bll)|*.bll";
                saveFileDialog.Title = "Save balls doc";
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
                    formatter.Serialize(fileStream, BallDoc);
                }
            }
        }
        private void openFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Balls doc file (*.bll)|*.bll";
            openFileDialog.Title = "Open balls doc file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                try
                {
                    using (FileStream fileStream = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formater = new BinaryFormatter();
                        BallDoc = (BallDoc)formater.Deserialize(fileStream);
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

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openFile();
        }
    }
}
