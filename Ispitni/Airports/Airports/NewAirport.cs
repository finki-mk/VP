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
    public partial class NewAirport : Form
    {
        public Airport Airport { get; set; }
        public NewAirport()
        {
            InitializeComponent();
        }

        private void tbCity_Validating(object sender, CancelEventArgs e)
        {
            if (tbCity.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbCity, "Името на градот е задолжително");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbCity, null);
                e.Cancel = false;
            }
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

        private void tbShort_Validating(object sender, CancelEventArgs e)
        {
            if (tbShort.Text.Trim().Length != 3)
            {
                errorProvider1.SetError(tbShort, "Кратенката треба да има точно 3 големи букви");
                e.Cancel = true;
            }
            else
            {
                string sh = tbShort.Text.Trim();
                foreach (char c in sh)
                {
                    if (Char.IsLower(c))
                    {
                        errorProvider1.SetError(tbShort, "Кратенката треба да има точно 3 големи букви");
                        e.Cancel = true;
                        return;
                    }
                }
                errorProvider1.SetError(tbShort, null);
                e.Cancel = false;
            }
        }

        private void btnSaveAiroport_Click(object sender, EventArgs e)
        {
            Airport = new Airport(tbName.Text.Trim(), tbCity.Text.Trim(), tbShort.Text.Trim());
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnDeleteAirport_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
