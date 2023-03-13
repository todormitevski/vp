using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aud3
{
    internal class Album
    {
        public string name { get; set; }
        public int year { get; set; }
        public List<Song> songs { get; set; }

        public Album()
        {
            songs = new List<Song>();
        }

        public Album(string name, int year, List<Song> songs)
        {
            this.name = name;
            this.year = year;
            foreach (Song song in songs)
            {
                this.songs.Add(song);
            }
        }

        public void addSong(Song song)
        {
            songs.Add(song);
        }

        public Song findSong(string song)
        {
            foreach (Song s in songs)
            {
                if (s.name.Equals(song, StringComparison.OrdinalIgnoreCase))
                    Console.WriteLine("Song found: {0}",s);
            }
            throw new SongNotFoundException("The song " + song + " is not found in the album.");
        }

        public void removeSong(string name)
        {
            for (int i = 0; i < songs.Count; i++)
            {
                if (songs[i].name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    songs.RemoveAt(i);
                    i--;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append("Name of album: " + name + "\n");
            str.Append("Year: " + year + "\n");
            str.Append("Songs:\n");
            foreach (Song song in songs)
            { str.Append(song.ToString()); }
            return str.ToString();
        }
    }
}
