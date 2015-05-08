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
    public partial class Form1 : Form
    {
        Exam selectedExam;
        public Form1()
        {
            InitializeComponent();
            Exam c = new Exam("Јуни", 2014);
            lbExams.Items.Add(c);
            c = new Exam("Август", 2013);
            lbExams.Items.Add(c);
            c = new Exam("Јануари", 2015);
            lbExams.Items.Add(c);
            c = new Exam("Јуни", 2013);
            lbExams.Items.Add(c);
            c = new Exam("Август", 2012);
            lbExams.Items.Add(c);            
        }

        private void btnAddConference_Click(object sender, EventArgs e)
        {
            ExamForm form = new ExamForm();
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lbExams.Items.Add(form.Exam);
            }
        }

        private void lbConferences_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteExam.Enabled = lbExams.SelectedIndex != -1;
            if (lbExams.SelectedIndex != -1)
            {
                selectedExam = lbExams.SelectedItem as Exam;
                tbDescription1.Text = selectedExam.Problem1.Description;
                nudPoints1.Value = selectedExam.Problem1.Points;
                tbDescription2.Text = selectedExam.Problem2.Description;
                nudPoints2.Value = selectedExam.Problem2.Points;

            }
            else
            {
                selectedExam = null;
            }
        }

        private void btnDeleteConference_Click(object sender, EventArgs e)
        {
            if (lbExams.SelectedIndex == -1) return;
            if (MessageBox.Show("Дали сте сигурни?", "Избриши испит?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                lbExams.Items.RemoveAt(lbExams.SelectedIndex);
                tbDescription1.Clear();
                tbDescription2.Clear();
                nudPoints1.ResetText();
                nudPoints2.ResetText();
            }
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            if (selectedExam == null) return;
            selectedExam.Problem1.Description = tbDescription1.Text;
            selectedExam.Problem1.Points = (int)nudPoints1.Value;
            MessageBox.Show("Зачувано");
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            if (selectedExam == null) return;
            selectedExam.Problem2.Description = tbDescription2.Text;
            selectedExam.Problem2.Points = (int)nudPoints2.Value;
            MessageBox.Show("Зачувано");
        }
    }
}
