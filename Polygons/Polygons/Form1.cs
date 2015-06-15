using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
    }
}
