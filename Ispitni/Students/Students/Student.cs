using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Students
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

        public double average()
        {
            double total = 0;
            foreach (Course course in Courses)
            {
                total += course.Grade;
            }
            if (Courses.Count > 0)
            {
                return total / Courses.Count;
            }
            return 0;

            //return Courses.Select(c => c.Grade).Average();
        }

        public override string ToString()
        {
            return string.Format("{0} {1} : {2}", FirstName, LastName,
                Number);
        }
    }
}
