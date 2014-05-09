using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Busses
{
    public partial class NewBus : Form
    {
        public Bus Bus { get; set; }
        public NewBus()
        {
            InitializeComponent();
        }

        private void tbCity_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbName, "Името на автобусот е задолжително");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbName, null);
                e.Cancel = false;
            }
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbRegistrationNumber.Text.Trim().Length != 4)
            {
                errorProvider1.SetError(tbRegistrationNumber, "Регистрацијата треба да има точно 4 цифри");
                e.Cancel = true;
            }
            else
            {
                string sh = tbRegistrationNumber.Text.Trim();
                foreach (char c in sh)
                {
                    if (!Char.IsDigit(c))
                    {
                        errorProvider1.SetError(tbRegistrationNumber, "Регистрацијата треба да има точно 4 цифри");
                        e.Cancel = true;
                        return;
                    }
                }
                errorProvider1.SetError(tbRegistrationNumber, null);
                e.Cancel = false;
            }
        }

        private void btnSaveAiroport_Click(object sender, EventArgs e)
        {
            Bus = new Bus(tbRegistrationNumber.Text.Trim(), tbName.Text.Trim(), cbIsLocal.Checked);
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnDeleteAirport_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
