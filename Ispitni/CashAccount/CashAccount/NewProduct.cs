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
    public partial class NewProduct : Form
    {
        public Product Product { get; set; }

        public NewProduct()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product = new Product((int)nudCode.Value, tbName.Text, (float)nudPrice.Value);
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
            if (tbName.Text.Trim().Length > 0)
            {
                e.Cancel = false;
                errorProvider1.SetError(tbName, null);
            }
            else
            {
                e.Cancel = true;
                errorProvider1.SetError(tbName, "Името на продуктот е задолжително");
            }
        }




    }
}
