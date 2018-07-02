using System;
using System.Collections.Generic;
using System.Text;
using MovieTheater.Library.Interfaces;

namespace MovieTheater.Library.Models
{
    public class DVDMovie :IMovie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        private int diskCount;
        public DateTime ReleaseDate { get; set; }

    }
}
