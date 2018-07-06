using System;
using System.Collections.Generic;

namespace EFDBFirstDemo.Data
{
    public partial class Movie
    {
        // ----- regular properties -----

        // this one is the primary key
        // we should not modify it
        public int Id { get; set; }
        // we can modify the name
        public string Name { get; set; }
        // this one is the foreign key itself.
        // we should not modify that either. instead:
        public int GenreId { get; set; }

        // DateTime? means the same as Nullable<DateTime>
        public DateTime? ReleaseDate { get; set; }

        // ---- navigation properties ----

        // instead, we can modify this navigation property.
        // it's called that because through it we navigate to other entities
        public Genre Genre { get; set; }
        // BUT, we need to call "Include" for the navigation properties
        // we want to see.
    }
}
