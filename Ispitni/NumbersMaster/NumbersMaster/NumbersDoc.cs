using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace NumbersMaster
{
    public class NumbersDoc
    {
        public List<Number> Numbers { get; set;}
        public int Hits { get; set; }
        public int Misses { get; set; }

        public NumbersDoc()
        {
            Numbers = new List<Number>();
            Hits = 0;
            Misses = 0;
        }

        public void AddNumber(int width, int height)
        {
            Number n = new Number(width, height);
            Numbers.Add(n);
        }

        public void Draw(Graphics g)
        {
            foreach (Number n in Numbers)
            {
                n.Draw(g);
            }
        }

        public void Tick()
        {
            foreach (Number n in Numbers)
            {
                n.Tick();
            }
            for (int i = Numbers.Count - 1; i >= 0; --i)
            {
                Number n = Numbers[i];
                if (n.TimeAlive == 0)
                {
                    Numbers.RemoveAt(i);
                    ++Misses;
                    
                }
                if (n.IsHit)
                {
                    Numbers.RemoveAt(i);
                    ++Hits;
                }
            }
        }

        public void Hit(int code)
        {
            foreach (Number n in Numbers)
            {
                if (n.Digit == code)
                {
                    n.Hit();
                    break;
                }
            }
            for (int i = Numbers.Count - 1; i >= 0; --i)
            {
                Number n = Numbers[i];
                if (n.IsHit)
                {
                    Numbers.RemoveAt(i);
                    ++Hits;
                }
            }
        }
    }
}
