using System;
using System.Collections.Generic;
using System.Text;
using MovieTheaterLibrary.Interface;
namespace MovieTheaterLibrary.Models
{
    public class DVDMovies : IMovies
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }


    }
}
