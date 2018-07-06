using System;
using System.Collections.Generic;
using System.Text;

namespace EFDBFirstDemo.Data
{
    class MovieRepository
    {
        private readonly MoviesDBContext _db;

        public MovieRepository(MoviesDBContext db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }
    }
}
