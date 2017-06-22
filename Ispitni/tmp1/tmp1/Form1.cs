using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PogodiGiTopcinjata
{
    [Serializable]
    public partial class Form1 : Form
    {
        int Points;
        List<Balls> balls;
        Graphics graphics;
        public Form1()
        {
            InitializeComponent();
            Points = 0;
            balls = new List<Balls>();
            graphics = CreateGraphics();
           
        }

        private void ballGeneratorTimer_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            Point p = new Point();
            int rad = 0;
            //for (;;) {
                p = new Point(rand.Next() % (this.Height - 200) + 100, rand.Next() % (this.Height - 200) + 100);
                rad = rand.Next() % 61 + 40;
             /*   bool flag = false;
                foreach (Balls bl in balls)
                {
                    if (p.X + rad <= bl.point.X - bl.rad)
                        break;
                    if (p.Y + rad <= bl.point.Y - bl.rad)
                        break;
                    if (p.X - rad <= bl.point.X + bl.rad)
                        break;
                    if (p.Y - rad <= bl.point.Y + bl.rad)
                        break;
                    flag = true;
                }
                if (flag)
                    break;
            }*/
            balls.Add(new Balls(p, rad));
            
            
        }

        private void ballChangerTimer_Tick(object sender, EventArgs e)
        {
            Brush br;
            graphics.Clear(Color.White);
            List<Balls> tmp = new List<Balls>();
            //Invalidate();
            foreach (Balls bl in balls)
            {
                bl.rad -= 5;
                bl.point = new Point(bl.point.X + 2, bl.point.Y + 2);
                if (bl.rad <= 10 || bl.color == Color.Red)
                {
                    continue;
                }
                else {
                    br = new SolidBrush(bl.color);
                    graphics.FillEllipse(br, bl.point.X, bl.point.Y, bl.rad, bl.rad);
                    br.Dispose();
                    tmp.Add(bl);
                }
            }
            balls = tmp;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                foreach (Balls bl in balls)
                {
                    if (bl.point.X + bl.rad <= e.X && bl.point.X - bl.rad >= e.X)
                    //bl.point.Y + bl.rad <= e.Y && bl.point.Y - bl.rad >= e.Y)
                    {
                        bl.color = Color.Red;
                        break;
                    }
                }
            }
            
        }
    }
}
