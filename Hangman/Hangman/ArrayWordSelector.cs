using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangman
{
    class ArrayWordSelector : IWordSelector
    {
        private readonly string[] words = {
                                   "Argentina",
                                   "Australia",
                                   "Greenland",
                                   "Guatemala",
                                   "Indonesia",
                                   "Lithuania",
                                   "Macedonia",
                                   "Mauritius",
                                   "Nicaragua",
                                   "Venezuela"
                                 };
        private Random random;

        public ArrayWordSelector()
        {
            random = new Random();
        }
        public string pick()
        {
            int index = random.Next(words.Length);
            return words[index];
        }
    }
}
