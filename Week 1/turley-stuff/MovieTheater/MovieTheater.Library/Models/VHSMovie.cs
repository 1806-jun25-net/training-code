using System;
using System.Collections.Generic;
using System.Text;
using MovieTheater.Library.Interfaces;

namespace MovieTheater.Library.Models
{
    public class VHSMovie : IMovie
    {
        public string Title { get; private set; }
        public string Genre { get; private set; }
        public DateTime ReleaseDate { get; private set;}

        public VHSMovie(string title, string genre, DateTime date)
        {
            Title = title;
            Genre = genre;
            ReleaseDate = date;
        }
    }
}
