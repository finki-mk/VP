using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pregled
{
    public partial class PatientForm : Form
    {
        public Patient Patient { get; set; }

        public PatientForm()
        {
            InitializeComponent();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            bool valid = tbName.Text.Trim().Length > 0;
            e.Cancel = !valid;
            errorProvider1.SetError(tbName, valid ? null : "Внеси име и презиме");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Patient = new Patient();
            Patient.Name = tbName.Text;
            Patient.Weight = (int)nudWeight.Value;
            Patient.Height = (int)nudHeight.Value;
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
