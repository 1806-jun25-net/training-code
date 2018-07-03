using MovieTheater.Library.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieTheater.Library.Models
{
    class VHSMovie : IMovie
    {
        public string Title { get; set; }

        string IMovie.Genre { get; } = "Old";//explicit interface implementation
                                               //not visible on regular VHSMovie variables!
        public DateTime ReleaseDate { get; private set; }
        public VHSMovie(string title, DateTime date)
        {
            Title = title;
            ReleaseDate = date;
        }
    }
}
