using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ListBoxExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            lbRight.Items.Clear();
            foreach (string s in clbLeft.CheckedItems)
            {
                lbRight.Items.Add(s);
            }

            for (int i = 0; i < clbLeft.Items.Count; i++)
            {
                clbLeft.SetItemChecked(i, false);
            }
        }
    }
}
