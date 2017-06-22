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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            StudentForm form = new StudentForm();
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lbStudents.Items.Add(form.Student);
            }
        }

        private void lbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGenerate.Enabled = lbStudents.SelectedIndex != -1;
            if (lbStudents.SelectedIndex != -1)
            {
                Student student = lbStudents.SelectedItem as Student;
                showCourses(student);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Student selected = lbStudents.SelectedItem as Student;
            int count = (int)nudTotal.Value;
            Random random = new Random();
            selected.Courses.Clear();
            for (int i = 0; i < count; ++i)
            {
                Course course = new Course();
                course.Name = string.Format("Предмет {0}", i + 1);
                course.Grade = random.Next(6, 11);
                selected.Courses.Add(course);
            }
            showCourses(selected);
            findMaxAverage();
        }

        void showCourses(Student student)
        {
            lbDosier.Items.Clear();
            foreach (Course course in student.Courses)
            {
                lbDosier.Items.Add(course);
            }
            tbAverage.Text = string.Format("{0:0.00}", student.average());
        }

        void findMaxAverage()
        {
            double max = -1;
            foreach (object obj in lbStudents.Items)
            {
                Student s = obj as Student;
                if (s.average() > max)
                {
                    max = s.average();
                }
            }
            tbTopAverage.Text = string.Format("{0:0.00}", max);
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (lbStudents.SelectedIndex != -1)
            {
                if (MessageBox.Show("Дали сте сигурни?",
                    "Бриши студент", MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                {
                    lbStudents.Items.RemoveAt(lbStudents.SelectedIndex);
                    lbDosier.Items.Clear();
                    tbAverage.Clear();
                    findMaxAverage();
                }
            }
        }
    }
}
