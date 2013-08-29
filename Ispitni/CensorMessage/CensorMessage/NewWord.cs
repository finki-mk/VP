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
    public partial class NewWord : Form
    {
        public string Word { get; set; }

        public NewWord()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Word = tbWord.Text.Trim();
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (tbWord.Text.Trim().Length <= 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbWord, "Зборот не смее да биде празен!");
            }
            else
            {
                errorProvider1.SetError(tbWord, null);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }
    }
}
