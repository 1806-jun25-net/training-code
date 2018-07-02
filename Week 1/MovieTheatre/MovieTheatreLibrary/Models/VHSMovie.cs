using MovieTheaterLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieTheaterLibrary.Models
{
    public class VHSMovie : IMovie
    {
        public string Title { get; private set; }
        string IMovie.Genre { get; } = "old"; //explicit interface implementation

        public DateTime ReleaseDate { get; private set; }

        public VHSMovie(string title, string genre, DateTime date)
        {
            Title = title;
            ReleaseDate = date;
        }
    }
}
