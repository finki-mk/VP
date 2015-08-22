using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Convertor
{
    public partial class AddConvertor : Form
    {
        public Convertor Result { get; set; }

        public AddConvertor()
        {
            InitializeComponent();
        }

        private void tbFrom_Validating(object sender, CancelEventArgs e)
        {
            if (tbFrom.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbFrom, "Полето од е задолжително!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbFrom, null);
            }
        }

        private void tbTo_Validating(object sender, CancelEventArgs e)
        {
            if (tbTo.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbTo, "Полето до е задолжително!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbTo, null);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Result = new Convertor();
            Result.From = tbFrom.Text;
            Result.To = tbTo.Text;
            Result.Multiplier = nudMultiplier.Value;
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void nudMultiplier_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudMultiplier_Validating(object sender, CancelEventArgs e)
        {
            if (nudMultiplier.Value == 0)
            {
                errorProvider1.SetError(nudMultiplier, "Вредноста мора да биде поголема од 0!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(nudMultiplier, null);
                e.Cancel = false;
            }
        }
    }
}
