using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace NumbersMaster
{
    public partial class Form1 : Form
    {
        Timer timer;
        NumbersDoc numbersDoc;
        Timer timerGenerate;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            numbersDoc = new NumbersDoc();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            timerGenerate = new Timer();
            timerGenerate.Interval = 2000;
            timerGenerate.Tick += new EventHandler(timerGenerate_Tick);
            timerGenerate.Start();
        }

        void timerGenerate_Tick(object sender, EventArgs e)
        {
            numbersDoc.AddNumber(this.Width, this.Height);
            Invalidate(true);
        }

        void timer_Tick(object sender, EventArgs e)
        {
            numbersDoc.Tick();
            Invalidate(true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            numbersDoc.Draw(e.Graphics);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            numbersDoc.Hit(e.KeyValue - (int)'0');
            Invalidate(true);
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            lblResult.Text = string.Format("Hits: {0} Misses: {1}", numbersDoc.Hits, numbersDoc.Misses);
        }
    }
}
