using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Weather
{
    public class Daily
    {
        public static readonly string[] MONTHS = {
                                                     "Јануари",
                                                     "Февруари",
                                                     "Март",
                                                     "Април",
                                                     "Мај",
                                                     "Јуни",
                                                     "Јули",
                                                     "Август",
                                                     "Септември",
                                                     "Октомври",
                                                     "Ноември",
                                                     "Декември"
                                                     };
        public int Day { get; set; }
        public int Month { get; set; }

        public int Min { get; set; }
        public int Max { get; set; }

        public string Date
        {
            get
            {
                return string.Format("{0} {1}", Day, MONTHS[Month]);
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", Day, MONTHS[Month]);
        }
    }
}
