using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Zad2
{
    [Serializable]
    public class PieDoc
    {
        public List<Pie> Pies { get; set; }

        public PieDoc()
        {
            Pies = new List<Pie>();
        }

        public void AddPie(Point point, Color color)
        {
            Pie p = new Pie(point, color);
            Pies.Add(p);
        }

        public void DrawPies(Graphics g)
        {
            foreach (Pie p in Pies)
            {
                p.Draw(g);
            }
        }

        public void Tick()
        {
            for (int i = Pies.Count - 1; i >= 0; i--)
            {
                Pies[i].Tick++;
                if (Pies[i].Tick == 4)
                {
                    Pies.RemoveAt(i);
                }
            }
        }
    }
}
