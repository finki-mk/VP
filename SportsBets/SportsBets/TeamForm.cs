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
    public partial class TeamForm : Form
    {
        public Team Team { get; set; }

        public TeamForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Form1 f = Parent as Form1;
            Team = new Team();
            Team.Name = tbName.Text;
            Team.Country = tbCountry.Text;
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
