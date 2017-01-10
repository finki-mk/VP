using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMSMessages
{
    public partial class Message : Form
    {
        public string MessageText { get; set; }
        static readonly int MAX = 60;

        public Message()
        {
            InitializeComponent();
            setCount();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            MessageText = tbMessage.Text;
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        void setCount()
        {
            int len = tbMessage.Text.Length;
            int left = MAX - len;
            lblCount.Text = string.Format("{0}", left);
            btnSend.Enabled = len > 5 && len <= MAX;
            if (left < 0)
            {
                lblCount.ForeColor = Color.Red;
            }
            else
            {
                lblCount.ForeColor = Color.Green;
            }
        }

        private void tbMessage_TextChanged(object sender, EventArgs e)
        {
            setCount();
        }
    }
}
