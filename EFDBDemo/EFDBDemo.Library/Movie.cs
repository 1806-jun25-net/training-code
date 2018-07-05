using System;
using System.Collections.Generic;

namespace EFDBDemo.Data
{
    public partial class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GenreId { get; set; }
        public DateTime? ReleaseDate { get; set; }


        public Genre Genre { get; set; }
    }
}
