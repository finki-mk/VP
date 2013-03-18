using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SongsAndAlbums
{
    class Program
    {
        static void Main(string[] args)
        {
            Album album = new Album("Ime", 2000);
            album.AddSong("Pesna 1", 400, 4.5f);
            album.AddSong("Pesna 2", 300, 4.5f);
            Console.WriteLine(album);
            try
            {
                album.FindSong("Pesna X");
            }
            catch (SongNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
