using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFDBDemo.Data
{
    public class MovieRepository
    {
        private readonly MoviesDBContext _db;

        public MovieRepository(MoviesDBContext db)
        {
            //checks not null
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }

        public IEnumerable<Movie> GetMovies()
        {
            //dont need to track changes to these, skip the overhead to do that
            var movies = _db.Movie.AsNoTracking().ToList();
            return movies;
        }
        public IEnumerable<Movie> GetMoviesWithGenres()
        {
            //dont need to track changes to these, skip the overhead to do that
            var movies = _db.Movie.Include(m=>m.Genre).AsNoTracking().ToList();
            return movies;
        }

        public void AddMovie(string name, DateTime release, string genre)
        {
            //first or default gives null if no first, instead of exception
            var g = _db.Genre.FirstOrDefault(h => h.Name == genre);
            if (g == null)
            {
                throw new ArgumentException("No such genre exists", nameof(genre));
            }
            var m = new Movie
            {
                Name = name,
                ReleaseDate = release,
                Genre = g
            };
            AddMovie(m);
        }

        public void AddMovie(Movie m)
        {
            _db.Add(m);
        }

        public void DeleteMovieById(int id)
        {
            var movie = _db.Movie.Find(id);
            if (movie == null)
                throw new ArgumentException("No such movie id exists", nameof(id));
            _db.Remove(movie);
        }

        public void Edit(Movie movie)
        {
            //no assumtpion that this is a tracked entity
            //note: adds if not found
            _db.Update(movie);
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }

    }
}
