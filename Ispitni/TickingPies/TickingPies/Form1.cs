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

namespace Zad2
{
    public partial class Form1 : Form
    {
        private PieDoc doc;

        private Color currentColor;

        private string FileName;

        private bool isRunning;

        public Form1()
        {
            InitializeComponent();
            currentColor = Color.Blue;
            doc = new PieDoc();
            DoubleBuffered = true;
            isRunning = false;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            doc.DrawPies(e.Graphics);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            doc.AddPie(e.Location, currentColor);
            Invalidate(true);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            doc.Tick();
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
            doc = new PieDoc();
            Invalidate(true);
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            doc = new PieDoc();
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
        private void saveFile()
        {
            if (FileName == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Pies doc file (*.pie)|*.pie";
                saveFileDialog.Title = "Save pies doc";
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
            openFileDialog.Filter = "Pies doc file (*.pie)|*.pie";
            openFileDialog.Title = "Open pies doc file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                try
                {
                    using (FileStream fileStream = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formater = new BinaryFormatter();
                        doc = (PieDoc)formater.Deserialize(fileStream);
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

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusTotal.Text = string.Format("Total: {0}", doc.Pies.Count);
        }

        private void tsbStartStop_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                timer1.Stop();
                tsbStartStop.Text = "Старт";
            }
            else
            {
                timer1.Start();
                tsbStartStop.Text = "Стоп";
            }
            isRunning = !isRunning;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
