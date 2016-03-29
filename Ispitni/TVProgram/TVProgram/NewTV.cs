using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zadaca1
{
    public partial class NewTV : Form
    {
        public TV TV { get; set; }
        public Form1 Form1 { get; set; }

        public NewTV()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }
            TV = new TV();
            TV.Name = tbName.Text;
            TV.Number = (int)nudNumber.Value;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbName, "Името не смее да биде празно!");
            }
            else
            {
                errorProvider1.SetError(tbName, null);
            }
        }

        private void nudNumber_Validating(object sender, CancelEventArgs e)
        {
            if (Form1.existsProduction((int)nudNumber.Value))
            {
                e.Cancel = true;
                errorProvider1.SetError(nudNumber, "Телевизија со овој број постои!");
            }
            else
            {
                errorProvider1.SetError(nudNumber, null);
            }
        }
    }
}
