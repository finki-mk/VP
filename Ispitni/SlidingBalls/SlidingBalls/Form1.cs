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

namespace SlidingBalls
{
    public partial class Form1 : Form
    {
        BallsDoc doc;
        Timer timer;
        string FileName;
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            doc = new BallsDoc(this.Width, this.Height);
            timer = new Timer();
            timer.Interval = 50;
            timer.Tick += new EventHandler(timer_Tick);
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (doc.Move())
            {
                timer.Stop();
            }
            Invalidate(true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            doc.Draw(e.Graphics);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                doc.AddRed(e.Location);
                Invalidate(true);
                return;
            }
            if (doc.Click(e.Location))
            {
                timer.Start();
            }
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            doc.AddBall(e.Location);
            Invalidate(true);
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
                    formatter.Serialize(fileStream, doc);
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
                        doc = (BallsDoc)formater.Deserialize(fileStream);
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

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            doc = new BallsDoc(Width, Height);
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

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("Active: {0}", doc.Balls.Count);
        }


    }
}
