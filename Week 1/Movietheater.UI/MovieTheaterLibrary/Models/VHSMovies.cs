using System;
using System.Collections.Generic;
using System.Text;
using MovieTheaterLibrary.Interface;


namespace MovieTheaterLibrary.Models

{
   public class VHSMovies : IMovies
    {
        public string Title { get; private set; }
        string IMovies.Genre { get; private set; }   //explicitly 
        public DateTime ReleaseDate { get; private set; }

        public VHSMovies(string title, string genre, DateTime date)
        {
            Title = title;
            Genre = genre;
            ReleaseDate = date;

        }
    }
}
