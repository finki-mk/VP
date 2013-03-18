using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SongsAndAlbums
{
    class SongNotFoundException : Exception
    {
        public SongNotFoundException(string name)
            : base(string.Format("Song {0} was not found!", name))
        { }
    }
}
