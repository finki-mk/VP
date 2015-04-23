using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Drawing1
{
    public partial class Form1 : Form
    {

        Scene scene;
        Timer timer;
        public Form1()
        {
            InitializeComponent();
            scene = new Scene();
            //this.DoubleBuffered = true;
            timer = new Timer();
            timer.Interval = 50;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            
        }
        void timer_Tick(object sender, EventArgs e)
        {
            scene.Pulse(250);
            Invalidate();
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                scene.AddShape(e.Location, Scene.ShapeType.CIRCLE);
            else if (e.Button == System.Windows.Forms.MouseButtons.Right)
                scene.AddShape(e.Location, Scene.ShapeType.TRIANGLE);
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.Aquamarine);
            scene.Draw(e.Graphics);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            scene.Select(e.Location);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (scene.SelectedShape)
            {
                scene.MoveShape(e.Location);
                Invalidate();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (scene.SelectedShape)
            {
                scene.ClearSelected();
                Invalidate();
            }
        }

       
    }
}
