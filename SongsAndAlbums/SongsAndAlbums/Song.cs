using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SongsAndAlbums
{
    class Song
    {
        public string Name { get; set; }

        public int Duration { get; set; }

        public float Rating { get; set; }

        public Song(string name, int duration, float rating)
        {
            Name = name;
            Duration = duration;
            Rating = rating;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}:{2} {3}", Name, Duration / 60,
                Duration % 60, Rating);
        }
    }
}
