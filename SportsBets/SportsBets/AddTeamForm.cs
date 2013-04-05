using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SportsBets
{
    public partial class AddTeamForm : Form
    {
        public Team Team { get; set; }

        public AddTeamForm()
        {
            InitializeComponent();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbName, "Внесете име на тимот!");
            }
            else
            {
                errorProvider1.SetError(tbName, null);
            }
        }

        private void tbCountry_Validating(object sender, CancelEventArgs e)
        {
            if (tbCountry.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbCountry, "Внесете држава на тимот!");
            }
            else
            {
                errorProvider1.SetError(tbCountry, null);
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Team = new Team(tbName.Text, tbCountry.Text);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
