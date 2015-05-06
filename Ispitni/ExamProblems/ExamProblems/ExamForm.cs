using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExamProblems
{
    public partial class ExamForm : Form
    {
        public Exam Exam { get; set; }

        public ExamForm()
        {
            InitializeComponent();
        }

        private void ConferenceForm_Load(object sender, EventArgs e)
        {
            nudYear.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Exam = new Exam(cbMonth.SelectedItem.ToString(), (int)nudYear.Value);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void cbMonth_Validating(object sender, CancelEventArgs e)
        {
            if (cbMonth.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbMonth, "Месецот е задолжителен");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(cbMonth, null);
                e.Cancel = false;
            }
        }
    }
}
