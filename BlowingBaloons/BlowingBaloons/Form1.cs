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

namespace BlowingBalloons
{
    public partial class Form1 : Form
    {
        private BalloonsDoc balloonsDoc;
        private Timer timer;
        private string FileName;

        public Form1()
        {
            InitializeComponent();
            balloonsDoc = new BalloonsDoc();
            this.DoubleBuffered = true;
            timer = new Timer();
            timer.Interval = 200;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            balloonsDoc.BlowBalloons();
            balloonsDoc.CheckForExplosions();
            Invalidate(true);
        }

     

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            balloonsDoc.AddBalloon(new Point(e.X, e.Y));
            Invalidate(true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            balloonsDoc.DrawBalloons(e.Graphics);
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {            
            toolStripTotalBalloons.Text = string.Format("Total: {0}", balloonsDoc.Balloons.Count);
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            balloonsDoc = new BalloonsDoc();
            Invalidate();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            balloonsDoc = new BalloonsDoc();
            Invalidate();
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
                saveFileDialog.Filter = "Balloons doc file (*.bal)|*.bal";
                saveFileDialog.Title = "Save balloons doc";
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
                    formatter.Serialize(fileStream, balloonsDoc);
                }
            }
        }
        private void openFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Balloons doc file (*.bal)|*.bal";
            openFileDialog.Title = "Open balloons file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                try
                {
                    using (FileStream fileStream = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formater = new BinaryFormatter();
                        balloonsDoc = (BalloonsDoc)formater.Deserialize(fileStream);
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

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            balloonsDoc.AddBalloon(new Point(e.X, e.Y));            
            Invalidate(true);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Save document and exit", "Save document?", MessageBoxButtons.YesNoCancel);
            if (result == System.Windows.Forms.DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                saveFile();
            }
        }

    }
}
