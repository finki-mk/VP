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
        List<Shape> shapes;
        Color currentColor;
        public Form1()
        {
            InitializeComponent();
            shapes = new List<Shape>();
            currentColor = Color.Violet;
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Shape c = null;
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                c = new Circle(e.Location, currentColor);
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                c = new Triangle(e.Location, currentColor, new Point(e.Location.X + 20, e.Location.Y),
                    new Point(e.Location.X, e.Location.Y + 30));
            }
            shapes.Add(c);
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.Yellow);
            foreach (Shape s in shapes)
            {
                s.Draw(e.Graphics);
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            foreach (Shape s in shapes)
            {
                if (s.Clicked(e.Location))
                {
                    Color c = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
                    s.Color = c;
                    Invalidate();
                }
            }
        }

       
    }
}
