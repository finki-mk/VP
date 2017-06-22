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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnAddToGames_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNewTeam_Click(object sender, EventArgs e)
        {
            TeamForm form = new TeamForm();
            DialogResult result = form.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                lbTeams.Items.Add(form.Team);
            }
        }

    }
}
