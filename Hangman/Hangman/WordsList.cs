using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hangman
{
    public partial class WordsList : Form
    {
        public List<string> Words { get; set; }

        public WordsList()
        {
            InitializeComponent();
            Words = new List<string>();
        }

        private void tbWord_Validating(object sender, CancelEventArgs e)
        {
            if (tbWord.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbWord, "Внесете збор!");
            }
        }

        private void WordsList_Load(object sender, EventArgs e)
        {
            Password pwdDialog = new Password();
            if (pwdDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("Невалидна лозинка!");
                Close();
            }
        }

        private void WordsList_Leave(object sender, EventArgs e)
        {
            foreach (string s in clbWords.SelectedItems)
            {
                Words.Add(s);
            }
        }
    }
}
