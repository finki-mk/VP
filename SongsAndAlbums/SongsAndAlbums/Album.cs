using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SongsAndAlbums
{
    class Album
    {
        public string Name { get; set; }

        public int Year { get; set; }

        public List<Song> Songs { get; set; }

        public Album(string name, int year)
        {
            Name = name;
            Year = year;
            Songs = new List<Song>();
        }

        public void AddSong(Song song)
        {
            Songs.Add(song);
        }

        public void AddSong(string name, int duration, float rating)
        {
            Song song = new Song(name, duration, rating);
            Songs.Add(song);
        }

        public Song FindSong(string name)
        {
            foreach (Song song in Songs)
            {
                if (song.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return song;
                }
            }
            throw new SongNotFoundException(name);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append('\n');
            sb.Append(Year);
            sb.Append('\n');
            sb.Append("Songs:\n");
            int i = 1;
            foreach (Song song in Songs)
            {
                sb.Append(string.Format("{0}. ", i++));
                sb.Append(song);
                sb.Append('\n');
            }
            return sb.ToString();
        }
    }
}
