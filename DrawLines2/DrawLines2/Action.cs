using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrawLines2
{
    public class Action
    {
        public enum Type
        {
            ADD
        }

        public Line Line { get; set; }

        public Type ActionType { get; set; }
    }
}
