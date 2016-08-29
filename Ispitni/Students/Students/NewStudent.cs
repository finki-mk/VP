using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class NewStudent : Form
    {
        public Student Student;

        public NewStudent()
        {
            InitializeComponent();
        }

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (tbFirstName.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbFirstName, "Името е задолжително");
            }
            else
            {
                errorProvider1.SetError(tbFirstName, null);
            }
        }

        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
            if (tbLastName.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbLastName, "Презимето е задолжително");
            }
            else
            {
                errorProvider1.SetError(tbLastName, null);
            }
        }

        private void tbNumber_Validating(object sender, CancelEventArgs e)
        {
            if (validateNumber(tbNumber.Text))
            {
                errorProvider1.SetError(tbNumber, null);
            }
            else
            {
                e.Cancel = true;
                errorProvider1.SetError(tbNumber, "Невалиден индекс");
            }
        }

        bool validateNumber(string number)
        {
            if (number.Trim().Length == 0) return false;
            foreach (char c in number)
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }
            return number[0] == '1' && number.Length == 6;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Student = new Student();
            Student.FirstName = tbFirstName.Text;
            Student.LastName = tbLastName.Text;
            Student.Number = tbNumber.Text;
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
