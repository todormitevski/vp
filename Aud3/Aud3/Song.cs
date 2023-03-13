using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace Aud3
{
    internal class Song
    {
        public string name { get; set; } //simplified getters and setters
        public double rating { get; set; }
        public int duration { get; set; }
        public string url { get; set; }

        public Song() { }
        public Song(string name, double rating, int duration, string url)
        {
            this.name = name;
            this.rating = rating;
            this.duration = duration;
            this.url = url;
        }

        public void playSong()
        {
            WindowsMediaPlayer player = new WindowsMediaPlayer();
            player.URL = this.url;
            player.controls.play();
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Duration: {1}, Rating: {2}, URL: {3}\n",
                name,duration,rating,url);
        }
    }
}
