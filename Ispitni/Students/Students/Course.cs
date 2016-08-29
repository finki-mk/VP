using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Course
    {
        public string Name { get; set; }
        public int Grade { get; set; }

        public override string ToString()
        {
            return string.Format("{0} ({1})", Name, Grade);
        }

    }
}
