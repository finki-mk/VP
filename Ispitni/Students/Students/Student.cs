using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Number { get; set; }

        public List<Course> Courses { get; set; }

        public Student()
        {
            Courses = new List<Course>();
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", LastName, FirstName, Number);
        }

        public void Generate(decimal total)
        {
            int n = (int)total;
            Random rand = new Random();
            Courses.Clear();
            for (int i = 0; i < n; ++i)
            {
                Course course = new Course();
                course.Grade = rand.Next(6, 11);
                course.Name = string.Format("Предмет {0}", i + 1);
                Courses.Add(course);
            }
        }

        public decimal Average()
        {
            if (Courses.Count == 0) return 0;
            decimal total = 0;
            for (int i = 0; i < Courses.Count; ++i)
            {
                total += Courses[i].Grade;
            }
            return total * 1.0m / Courses.Count;
        }
    }
}
