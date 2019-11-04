using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesCA_S00189001
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song1 = new Song("Beautiful People", "Ed Sheeran", 3.15, "PoP");
            Song song2 = new Song("Ride It", "Regard", 3.37, "Dance");
            Song song3 = new Song("Dnace Moneky", "Tones & I", 4.20, "Dnace");
            Song song4 = new Song("Circles", "Post Malone", 3.25, "PoP");
            Song song5 = new Song("South Of The Border", "Ed Sheeran", 4.26, "Other");

            List<Song> PlayList = new List<Song>();
            PlayList.Add(song1);
            PlayList.Add(song2);
            PlayList.Add(song3);
            PlayList.Add(song4);
            PlayList.Add(song5);

            
            PlayList.Sort();

            DisplayPlayList(PlayList);
            Shuffle(PlayList);
            DisplayPlayList(PlayList);

            Console.ReadKey();
        }

        private static void DisplayPlayList(List<Song> songs)
        {
            Console.WriteLine("{0,-10}\t{1,-10}\t\t{2,-10}\t{3,-10}", "Artist", "Song", "Duration", "Genre");

            //loop through all songs in the playlist; list

            foreach (Song song in songs)
            {
                Console.WriteLine("{0,-10}\t{1,-10}\t\t{2,-10}\t{3,-10}",song.artist, song.title, song.duration, song.genre);
                //Console.Write("{0,-10}", song);
            }

            //Adds a blank line for spacing
            Console.WriteLine();
        }

        public static void Shuffle(List<Song> PlayList)
        {

            Console.WriteLine("Shuffling The Playlist...");

            var random = new Random();
            //var PlayList = new List<string>{
            // "question1",
            //"question2",
            //"question3"};
            int index = random.Next(PlayList.Count);
            Console.WriteLine(PlayList[index]);

            
        }
        //public static void Shuffle<T>(this IList<T> list, Random rnd)
        //{
        //    for (var i = 0; i < list.Count - 1; i++)
        //        list.Swap(i, rnd.Next(i, list.Count));
        //}

        //public static void Swap<T>(this IList<T> list, int i, int j)
        //{
        //    var temp = list[i];
        //    list[i] = list[j];
        //    list[j] = temp;
        //}
    }
}
