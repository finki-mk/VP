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
    public partial class NewProduction : Form
    {
        public Production Production { get; set; }
        public Form1 Form1 { get; set; }

        public NewProduction()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }
            Production = new Production();
            Production.Name = tbName.Text;
            Production.Code = mtbCode.Text;
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

        private void mtbCode_Validating(object sender, CancelEventArgs e)
        {
            if (!mtbCode.MaskCompleted)
            {
                e.Cancel = true;
                errorProvider1.SetError(mtbCode, "Пополнете ги сите потребни податоци за кодот!");
            }
            else if (Form1.existsProduction(mtbCode.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(mtbCode, "Продукција со ваков код постои!");
            }
            else
            {
                errorProvider1.SetError(mtbCode, null);
            }
        }
    }
}
