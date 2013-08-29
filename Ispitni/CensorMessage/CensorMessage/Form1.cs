using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CensorMessage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblCount.Text = "";
            clbStopWords.Items.Add("лето");
            clbStopWords.Items.Add("плажа");
            clbStopWords.Items.Add("авион");
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            NewWord nw = new NewWord();
            if (nw.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                clbStopWords.Items.Add(nw.Word);
            }
        }

        private void tbMessage_TextChanged(object sender, EventArgs e)
        {
            int len = 160 - tbMessage.Text.Trim().Length;
            if (len < 0)
            {
                lblCount.ForeColor = Color.Red;
                btnSend.Enabled = false;
            }
            else
            {
                lblCount.ForeColor = Color.Black;
                btnSend.Enabled = true;
            }
            lblCount.Text = string.Format("{0}", len);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string text = tbMessage.Text.Trim();
            foreach (object o in clbStopWords.CheckedItems)
            {
                text = text.Replace(o.ToString(), wordToStars(o.ToString()));
            }
            MessageBox.Show(text);
        }       

        string wordToStars(string word)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < word.Length; ++i)
            {
                sb.Append("*");
            }
            return sb.ToString();
        }
    }
}
