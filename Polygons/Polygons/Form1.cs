using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Polygons
{
    public partial class Form1 : Form
    {
        PolygonDoc polygons;
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            polygons = new PolygonDoc();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            polygons.Draw(e.Graphics);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            polygons.Click(e.Location);
            Invalidate();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            polygons.Move(e.Location);
            Invalidate();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Title = "Save file of polygons";
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                save(fileDialog.FileName);
            }
        }

        void save(string path)
        {
            using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, polygons);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Open polygons file to read";
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                open(fileDialog.FileName);
            }
        }

        void open(string path)
        {
            using (FileStream stream = new FileStream(path, FileMode.Open))
            {
                IFormatter formatter = new BinaryFormatter();
                polygons = (PolygonDoc)formatter.Deserialize(stream);
            }
        }

    }
}
