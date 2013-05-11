using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace BlowingBalloons
{
    [Serializable]
    public class BalloonsDoc
    {
        public List<Balloon> Balloons { get; set; }

        public BalloonsDoc()
        {
            Balloons = new List<Balloon>();
        }

        public void AddBalloon(Point point)
        {
            Random r = new Random();
            Balloon balloon = new Balloon(point, r.Next(20, 30));
            Balloons.Add(balloon);
        }

        public void BlowBalloons()
        {
            foreach (Balloon balloon in Balloons)
            {
                balloon.Radius += 5;
            }
        }

        public void CheckForExplosions()
        {
            for (int i = 0; i < Balloons.Count; i++)
            {
                for (int j = i + 1; j < Balloons.Count; j++)
                {
                    if (Balloons[i].IsTouching(Balloons[j]))
                    {
                        Balloons[i].Flag = true;
                        Balloons[j].Flag = true;
                    }
                }
            }
            for (int i = Balloons.Count - 1; i >= 0; i--)
            {
                if (Balloons[i].Flag)
                {
                    Balloons.RemoveAt(i);
                }
            }

        }

        public void DrawBalloons(Graphics g)
        {
            foreach (Balloon balloon in Balloons)
            {
                balloon.Draw(g);
            }
        }
    }
}
