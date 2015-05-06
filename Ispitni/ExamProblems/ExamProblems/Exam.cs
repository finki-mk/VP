using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamProblems
{
    public class Exam
    {    
        public string Month { get; set; }
        public int Year { get; set; }
        public Problem Problem1 { get; set; }
        public Problem Problem2 { get; set; }

        public Exam(string month, int year)
        {
            Month = month;
            Year = year;
            Problem1 = new Problem();
            Problem2 = new Problem();
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", Month, Year);
        }

    }
}
