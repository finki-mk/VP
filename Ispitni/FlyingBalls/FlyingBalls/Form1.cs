using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace FlyingBalls
{
    public partial class Form1 : Form
    {
        private BallsDoc ballsDoc;
        private int generateBall;
        private Random random;
        private string FileName;
        private Timer timer;

        public Form1()
        {
            InitializeComponent();
            ballsDoc = new BallsDoc();
            generateBall = 0;
            random = new Random();
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            DoubleBuffered = true;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (generateBall % 10 == 0)
            {
                int y = random.Next(2 * Ball.RADIUS, Height - (Ball.RADIUS * 2));
                int x = -Ball.RADIUS;
                ballsDoc.AddBall(new Point(x, y));
            }
            ++generateBall;
            ballsDoc.Move(Width);
            Invalidate(true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            ballsDoc.Draw(e.Graphics);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            ballsDoc.Hit(e.Location);
            Invalidate(true);
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            lblHits.Text = string.Format("Hits: {0}", ballsDoc.Hits);
            lblMissed.Text = string.Format("Misses: {0}", ballsDoc.Missed);
        }

        private void saveFile()
        {
            if (FileName == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Balls doc file (*.bls)|*.bls";
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
                    formatter.Serialize(fileStream, ballsDoc);
                }
            }
        }
        private void openFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Balls doc file (*.bls)|*.bls";
            openFileDialog.Title = "Open balls doc file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                try
                {
                    using (FileStream fileStream = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formater = new BinaryFormatter();
                        ballsDoc = (BallsDoc)formater.Deserialize(fileStream);
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

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ballsDoc = new BallsDoc();
            Invalidate(true);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            ballsDoc = new BallsDoc();
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

        private void lblPause_Click(object sender, EventArgs e)
        {
            ballsDoc.Paused = !ballsDoc.Paused;
            if (ballsDoc.Paused)
            {
                timer.Stop();
                lblPause.Text = "Continue";
            }
            else
            {
                timer.Start();
                lblPause.Text = "Pause";
            }
        }
    }
}
