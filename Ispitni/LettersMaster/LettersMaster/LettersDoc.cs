using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Shooter
{
    public class LettersDoc
    {
        public List<LetterCircle> Letters { get; set; }
        public int Points { get; set; }
        public int Misses { get; set; }
        private Random random;
        //public Dictionary<char, int> Count { get; set; }
        public int[] Count;

        public LettersDoc()
        {
            Letters = new List<LetterCircle>();
            Points = 0;
            Misses = 0;
            random = new Random();
            Count = new int[26];
            //Count = new Dictionary<char, int>();
        }

        public void AddLetter(int width, int height)
        {
            LetterCircle lc = new LetterCircle(random, width, height);
            Count[lc.Letter - 'A']++;
            Letters.Add(lc);
        }

        public void Draw(Graphics g)
        {
            foreach (LetterCircle lc in Letters)
            {
                lc.Draw(g);
            }
        }

        public void Move()
        {
            foreach (LetterCircle lc in Letters)
            {
                lc.Move();
            }
            for (int i = Letters.Count - 1; i >= 0; --i)
            {
                LetterCircle l = Letters[i];
                if (l.ShouldDie())
                {
                    Misses++;
                    Letters.RemoveAt(i);
                }
                else
                    if (l.IsHit)
                    {
                        Letters.RemoveAt(i);
                    }
            }
        }

        public void Hit(char c)
        {
            foreach (LetterCircle lc in Letters)
            {
                if (lc.Letter == Char.ToUpper(c))
                {
                    Points++;
                    lc.IsHit = true;
                    break;
                }
            }
        }
    }
}
