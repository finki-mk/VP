using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Polygons
{
    [Serializable]
    public class PolygonDoc
    {
        public List<Polygon> Polygons { get; set; }

        [NonSerialized]
        public bool IsChanged;

        public PolygonDoc()
        {
            Polygons = new List<Polygon>();
            IsChanged = false;
        }

        public void AddPolygon(Polygon polygon)
        {
            Polygons.Add(polygon);
            IsChanged = true;
        }

        public void Draw(Graphics g)
        {
            foreach (Polygon polygon in Polygons)
            {
                polygon.Draw(g);
            }
        }

        public void Move(int dx, int dy)
        {
            foreach (Polygon polygon in Polygons)
            {
                polygon.Move(dx, dy);
            }
        }
    }
}
