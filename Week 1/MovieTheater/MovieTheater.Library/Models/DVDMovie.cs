using MovieTheater.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieTheater.Library.Models
{
    public class DVDMovie : IMovie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }

        private int diskCount = 1; // backing field

        // manual implementation of property with backing field
        public int DiskCount
        {
            get { return diskCount; }
            set { if (value > 0) diskCount = value; }
        }
    }
}
