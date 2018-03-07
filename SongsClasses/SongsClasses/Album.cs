using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vizuelno_Aud2_2
{
    class Album
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public List<Song> pesni { get; set; }
        public Album() {
            pesni = new List<Song>();
        }
        public Album(string Name, int Year, List<Song> pesni)
        {
            this.pesni = pesni;
            this.Year = Year;
            this.Name = Name;
        }
        public void addSong(Song s)
        {
            pesni.Add(s);
        }
        public void removeSong(Song remove)
        {
            foreach (Song s in pesni)
            {
                if(s.Name.Equals(remove.Name))
                pesni.Remove(s);
            }
        }
        public Song findSong(String find)
        {
            foreach (Song s in pesni)
            {
                if (s.Name.Equals(find))
                    return s;
            }
            throw new SongNotFoundException();
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append("Name of album: " + Name+"\n");
            str.Append("Year of album: " + Year + "\n"+"Songs:\n");
            foreach(Song s in pesni)
            {
                str.Append(s);
            }
            return str.ToString();
        }


    }
}
