using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace Vizuelno_Aud2_2
{
    class Song
    {
        public string Name { get; set; }
        public double rating { get; set; }
        public int duration { get; set; }
        public string URL { get; set; }
        public Song() { }
        public Song(string Name, double rating, int duration, string URL)
        {
            this.Name = Name;
            this.rating = rating;
            this.duration = duration;
            this.URL = URL;
        }
        public void play()
        {
            WindowsMediaPlayer player = new WindowsMediaPlayer();
            player.URL = this.URL;
            player.controls.play();
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append("Name: " + Name + "\n");
            str.Append("Duration: " + duration + "\n");
            str.Append("Rating: " + rating + "\n");
            return str.ToString();
        }
    }
}
