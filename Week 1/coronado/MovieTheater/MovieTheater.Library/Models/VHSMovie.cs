using MovieTheater.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieTheater.Library.Models
{
    public class VHSMovie : IMovie
    {
        public string Title { get; private set; }
        string IMovie.Genre { get; } = "Old"; // explicit interface implementation; not visible
        public DateTime ReleaseDate { get; private set; }

        public VHSMovie(string title, string genre, DateTime date)
        {
            Title = title;
            //Genre = genre;
            ReleaseDate = date;
        }
    }
}
