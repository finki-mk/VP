using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Airports
{
    public partial class AddDestination : Form
    {
        public Destination Destination { get; set; }

        public AddDestination()
        {
            InitializeComponent();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbName, "");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbName, null);
                e.Cancel = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Destination = new Destination(tbName.Text.Trim(), (int)nudDistance.Value, (int)nudPrice.Value);
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

    }
}
