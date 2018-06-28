using Movie.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Movies
{
    public class VHAMovie : IMovie

    {
        public string title { get; private set; }

        public string genre { get; } = "old"; // eplicite interface implmentation 
                                      

        public DateTime relseDate { get; private set; }

        public VHAMovie(string title, string genre, DateTime date)
        {
            title = this.title;
            genre = this.genre;
            relseDate = date; 

        }
    }
}
