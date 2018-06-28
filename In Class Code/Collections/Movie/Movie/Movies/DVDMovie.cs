using Movie.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Movies
{
    public class DVDMovie : IMovie
    {
        public string title { get; set; }

        public string genre { get; set; }

        public DateTime relseDate { get; set; }

        public int count
        {
            get { return count; }
            set { if (value > 0 ) count = value; }

        }
    }
}
