using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConferencePapers
{
    public class Conference
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }

        public Conference(string title, int year)
        {
            Id = Guid.NewGuid().ToString();
            Title = title;
            Year = year;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", Year, Title);
        }

    }
}
