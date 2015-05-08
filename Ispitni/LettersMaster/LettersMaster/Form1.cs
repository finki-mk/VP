using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shooter
{
    public partial class Form1 : Form
    {
        Timer timer;
        Timer timerMove;
        LettersDoc lettersDoc;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            lettersDoc = new LettersDoc();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            timerMove = new Timer();
            timerMove.Interval = 100;
            timerMove.Tick += timerMove_Tick;
            timer.Start();
            timerMove.Start();
        }

        void timerMove_Tick(object sender, EventArgs e)
        {
            lettersDoc.Move();
            Invalidate(true);
        }

        void timer_Tick(object sender, EventArgs e)
        {
            lettersDoc.AddLetter(this.Width, this.Height);
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            lettersDoc.Draw(e.Graphics);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            lettersDoc.Hit(e.KeyChar);
            Invalidate(true);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            lblResult.Text = string.Format("Points: {0}, Missed: {1}", lettersDoc.Points, lettersDoc.Misses);
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < 26; ++i)
            {
                sb.Append(string.Format("{0} : {1} ", (char)('A' + i), lettersDoc.Count[i]));
            }
            lbStats.Text = sb.ToString();
        }
    }
}
