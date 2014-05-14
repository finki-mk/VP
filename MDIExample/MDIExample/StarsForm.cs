using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MDIExample
{
    public partial class StarsForm : Form
    {
        //ShapesList Shapes;
        Form1 parent;
        public StarsForm()
        {
            InitializeComponent();
            //Shapes = new ShapesList();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            parent.Shapes.AddShape(new Star());
            Invalidate();
            parent.InvalidateAll();
        }

        private void StarsForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            parent.Shapes.DrawShapes(e.Graphics);
        }

        private void StarsForm_Load(object sender, EventArgs e)
        {
            parent = (Form1) this.MdiParent;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            parent.Shapes.Shapes.RemoveAt(parent.Shapes.Shapes.Count - 1);
            parent.InvalidateAll();
        }
    }
}
