using System;
using System.Collections.Generic;

namespace EFDBFirstDemo.Data
{
    public partial class Genre
    {
        public Genre()
        {
            Movie = new HashSet<Movie>();
        }

        public int GenreId { get; set; }
        public string Name { get; set; }

        public ICollection<Movie> Movie { get; set; }
    }
}
