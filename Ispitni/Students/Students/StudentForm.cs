using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Students
{
    public partial class StudentForm : Form
    {
        public Student Student { get; set; }
        public StudentForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Student = new Student();
            Student.FirstName = tbFirstName.Text;
            Student.LastName = tbLastName.Text;
            Student.Number = tbNumber.Text;
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        bool validateNonEmptyControl(Control control, string message)
        {
            bool isValid = control.Text.Trim().Length > 0;
            errorProvider1.SetError(control, isValid ? null : message);
            return isValid;
        }

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !validateNonEmptyControl(tbFirstName, "Enter first name");
        }

        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !validateNonEmptyControl(tbLastName, "Enter last name");
        }

        private void tbNumber_Validating(object sender, CancelEventArgs e)
        {
            bool isValid = isValidNumber(tbNumber.Text);
            e.Cancel = !isValid;
            errorProvider1.SetError(tbNumber, isValid ? null : "Invalid number");
        }

        bool isValidNumber(string number)
        {
            if (number.Length == 6)
            {
                bool allDigits = true;
                for (int i = 0; i < number.Length; ++i)
                {
                    if(!Char.IsDigit(number[i]))
                    {
                        allDigits = false;
                        break;
                    }
                }
                if (allDigits)
                {
                    return number[0] == '1';
                }
            }
            return false;
        }
    }
}
