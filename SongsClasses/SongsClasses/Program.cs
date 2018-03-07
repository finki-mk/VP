using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vizuelno_Aud2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Song s = new Song("Bohemian Rapsody", 4.8, 250, @"C:\Users\Aleksandar\Desktop\queen\Queen Bohemian Rhapsody.mp3");
                Song s1 = new Song("I want to break free", 3.2, 280, @"C:\Users\Aleksandar\Desktop\queen\Queen - The Show Must Go On.mp3");
                Song s2 = new Song("The show must go on", 1.3, 110, @"C:\Users\Aleksandar\Desktop\queen\Queen -  We Are The Champions.mp3");

                Album album = new Album();
                album.Name = "Queen";
                album.Year = 1984;
                album.addSong(s);
                album.addSong(s1);
                album.addSong(s2);
                //Song bohemian = album.findSong("Bohemian Rapsody");
                s2.play();
                Console.WriteLine(album);
                Console.Read();
            }
            catch(SongNotFoundException s)
            {
                Console.WriteLine("The song was not found");
                Console.Read();

            }
            catch(Exception e)
            {
                Console.Read();
            }
        }
    }
}
