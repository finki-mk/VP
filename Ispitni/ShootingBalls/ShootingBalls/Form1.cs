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

namespace ShootingBalls
{
    public partial class Form1 : Form
    {
        private Game game;
        private Timer timer;
        private int counter;
        private string FileName;

        public Form1()
        {
            InitializeComponent();
            game = new Game(Width, Height);
            timer = new Timer();
            timer.Interval = 500;
            timer.Tick += new EventHandler(timer_Tick);
            counter = 0;
            timer.Start();
            DoubleBuffered = true;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (++counter % 2 == 0)
            {
                game.Generate();
            }
            game.Tick();
            Invalidate(true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            game.Draw(e.Graphics);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                game.Hit(e.Location);
            }
            else if(e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                game.Bomb(e.Location);
            }
            Invalidate(true);
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("Points: {0}", game.Points);
        }

        private void saveFile()
        {
            if (FileName == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Game file (*.gf)|*.gf";
                saveFileDialog.Title = "Save game file";
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
                    formatter.Serialize(fileStream, game);
                }
            }
        }
        private void openFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Game file (*.gf)|*.gf";
            openFileDialog.Title = "Game file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                try
                {
                    using (FileStream fileStream = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formater = new BinaryFormatter();
                        game = (Game)formater.Deserialize(fileStream);
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

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }
    }
}
