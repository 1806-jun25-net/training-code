using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFDBFirstDemo.Data
{
    public class MovieRepository
    {
        private readonly MoviesDBContext _db;

        public MovieRepository(MoviesDBContext db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }

        public IEnumerable<Movie> GetMovies()
        {
            // we don't need to track changes to these, so
            // skip the overhead of doing so
            List<Movie> movies = _db.Movie.AsNoTracking().ToList();
            return movies;
        }

        public IEnumerable<Movie> GetMoviesWithGenres()
        {
            List<Movie> movies = _db.Movie.Include(m => m.Genre).AsNoTracking().ToList();
            return movies;
        }

        public void AddMovie(string name, DateTime release, string genreName)
        {
            // LINQ: First fails by throwing exception,
            // FirstOrDefault fails to just null
            var genre = _db.Genre.FirstOrDefault(g => g.Name == genreName);
            if (genre == null)
            {
                throw new ArgumentException("genre not found", nameof(genreName));
            }
            var movie = new Movie
            {
                Name = name,
                ReleaseDate = release,
                Genre = genre
            };
            _db.Add(movie);
        }

        public void DeleteById(int id)
        {
            // with LINQ it would be, .FirstOrDefault(m => m.Id == id)
            // but Find is better/faster
            var movie = _db.Movie.Find(id);
            if (movie == null)
            {
                throw new ArgumentException("no such movie id", nameof(id));
            }
            _db.Remove(movie);
        }

        public void Edit(Movie movie)
        {
            // would add it if it didn't exist
            _db.Update(movie);
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
