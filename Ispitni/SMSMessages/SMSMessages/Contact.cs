using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMSMessages
{
    class Contact
    {
        public string Number { get; set; }
        public string Name { get; set; }


        public Contact()
        {
            Messages = new List<string>();
        }

        public List<string> Messages { get; set; }

        public bool Match(string text)
        {
            text = text.ToLower();
            return Number.ToLower().Contains(text) || Name.ToLower().Contains(text);
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} ({2})", Number, Name, Messages.Count);
        }
    }
}
