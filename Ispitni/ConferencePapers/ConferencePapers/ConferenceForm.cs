using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConferencePapers
{
    public partial class ConferenceForm : Form
    {
        public Conference Conference { get; set; }

        public ConferenceForm()
        {
            InitializeComponent();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbName, "Името е задолжително");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbName, null);
                e.Cancel = false;
            }
        }

        private void ConferenceForm_Load(object sender, EventArgs e)
        {
            tbName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Conference = new Conference(tbName.Text, (int)nudYear.Value);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
