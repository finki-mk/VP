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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            NewStudent studentForm = new NewStudent();
            if (studentForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lbStudents.Items.Add(studentForm.Student);
                topAverage();
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Student student = lbStudents.SelectedItem as Student;
            student.Generate(nudTotal.Value);
            fillCourses(student);
            topAverage();
        }

        private void lbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGenerate.Enabled = lbStudents.SelectedIndex != -1;
            if(lbStudents.SelectedIndex == -1) 
            {
                return;
            }
            Student student = lbStudents.SelectedItem as Student;
            fillCourses(student);
        }

        void fillCourses(Student student)
        {
            lbDosier.Items.Clear();
            foreach(Course course in student.Courses)
            {
                lbDosier.Items.Add(course);
            }
            tbAverage.Text = string.Format("{0:0.00}", student.Average());
        }

        void topAverage()
        {
            decimal top = 0;
            foreach (object obj in lbStudents.Items)
            {
                Student student = obj as Student;
                if (student.Average() > top)
                {
                    top = student.Average();
                }
            }
            tbTopAverage.Text = string.Format("{0:0.00}", top);
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (lbStudents.SelectedIndex != -1)
            {
                if (MessageBox.Show("Дали сте сигурни дека сакате да го избришете овој студент?", "Избриши студент", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                {
                    lbStudents.Items.RemoveAt(lbStudents.SelectedIndex);
                    lbDosier.Items.Clear();
                    tbAverage.Text = "";
                    topAverage();
                }
            }
        }
    }
}
