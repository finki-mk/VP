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
    public partial class Form1 : Form
    {
        public ShapesList Shapes;

        public Form1()
        {
            InitializeComponent();
            Shapes = new ShapesList();
        }

        private void starFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StarsForm form = new StarsForm();
            form.MdiParent = this;
            form.Show();
        }

        private void circleFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CirclesForm form = new CirclesForm();
            form.MdiParent = this;
            form.Show();
        }

        public void InvalidateAll()
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Invalidate();
            }
        }
    }
}
