using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum Genre
{
    Rock,
    Pop,
    Dance,
    Other
}

namespace GamesCA_S00189001
{
    class Song : IComparable
    {
        public string title { get; set; }
        public string artist { get; set; }
        public double duration { get; set; }
        public string genre { get; set; }

        public Song (string Title, string Artist, double Duration, string Genre)
        {
            title = Title;
            artist = Artist;
            duration = Duration;
            genre = Genre;
        }

        //public Song(string title, string artist, double duration, string genre) : this(title, artist, duration, genre)
        //{
        //    this.title = title;
        //    this.artist = artist;
        //    this.duration = duration;
        //    this.genre = genre;

        //}

        public Song()
        {

        }

        public override string ToString()
        {
            return $"{title}\t{artist}\t{duration}\t{genre}";
        }

        public int CompareTo(object obj)
        {
            // get a reference to the next object in the list/array/collection
            Song objectThatIAmCompartingTo = (Song)obj as Song; //Now we have something to compare our current object to

            //indicate what field I want to compare
            int returnValue = this.artist.CompareTo(objectThatIAmCompartingTo.artist);//title);
            //return
            return returnValue;
        }
    }
}
