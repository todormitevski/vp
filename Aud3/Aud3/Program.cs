using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aud3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Song song1 = new Song("Without You", 4.5, 250,
                    "E:\\Visual Studio Code\\.NET PROGRAMS\\vp\\Aud3\\Avicii - Without You “Audio” ft. Sandro Cavazza.mp3");
                Song song2 = new Song("Levels", 4.5, 250, "test2");
                Song song3 = new Song("Waiting For Love", 4.5, 250, "test3");
                Song song4 = new Song("Hey Brother", 4.5, 250, "test4");

                Album album = new Album();
                album.name = "AviciiLikedSongs";
                album.year = 2023;
                album.addSong(song1);
                album.addSong(song2);
                album.addSong(song3);
                album.addSong(song4);

                Console.WriteLine(album);
                song1.playSong();
                album.findSong("Hey Brother");
                album.findSong("The Nights");
                Console.Read();
            }
            catch (SongNotFoundException e)
            {
                Console.WriteLine(e.Message);
                Console.Read();
            }
        }
    }
}
