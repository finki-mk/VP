using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace F1Race
{
    public partial class AddDriver : Form
    {
        public Driver Result { get; set; }

        public AddDriver()
        {
            InitializeComponent();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbName, "Името е задолжително");
            }
            else
            {
                errorProvider1.SetError(tbName, null);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Result = new Driver();
            Result.Name = tbName.Text;
            Result.Age = (int)nudAge.Value;
            Result.IsFirst = cbFirst.Checked;
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
