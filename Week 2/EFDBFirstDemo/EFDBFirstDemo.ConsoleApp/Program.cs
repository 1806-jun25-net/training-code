using EFDBFirstDemo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Linq;

namespace EFDBFirstDemo.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // get the configuration from file
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            // now i can access the connection string like this
            // this will be null if there isn't an appsettings with this connection string
            Console.WriteLine(configuration.GetConnectionString("MoviesDB"));

            // ORM: object-relational mapper
            // our ORM in .NET is: Entity Framework
            // we will use database-first approach to EF
            Console.WriteLine("Hello World!");

            // provide the connection string to the dbcontext
            var optionsBuilder = new DbContextOptionsBuilder<MoviesDBContext>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("MoviesDB"));

            var repo = new MovieRepository(new MoviesDBContext(optionsBuilder.Options));

            var movies = repo.GetMoviesWithGenres();
            foreach (var item in movies)
            {
                Console.WriteLine($"Name {item.Name}," +
                    $" genre {item.Genre.Name}");
            }

            //edit a movie
            var aMovie = movies.First();
            aMovie.Name = "A New Hope";
            repo.Edit(aMovie);
            repo.AddMovie("Die Hard", DateTime.Now, "action");
            repo.DeleteById(aMovie.Id);
            repo.SaveChanges();

            movies = repo.GetMoviesWithGenres();
            Console.WriteLine();
            foreach (var item in movies)
            {
                Console.WriteLine($"Name {item.Name}," +
                    $" genre {item.Genre.Name}");
            }
        }

        static void EarlierCode()
        {
            PrintMovies();
            ChangeMovie();
            PrintMovies();

            var movie = new Movie { Id = 1, Name = "Toy Story", GenreId = 1 };
            // at this point, movie is untracked.
            using (var db = new MoviesDBContext())
            {
                // begin tracking the movie, based on the Id it has.
                // treat any difference as updates to be made.
                db.Update(movie);

                // push the changes to the db
                db.SaveChanges();
            }
        }

        static void ChangeMovie()
        {
            using (var db = new MoviesDBContext())
            {
                // get the first movie by name
                // this entity is tracked.
                var movie = db.Movie.OrderBy(m => m.Name).First();

                // edit it
                movie.Name = "Solo";

                // create (untracked) genre entity
                var genre = new Genre { Name = "Action/Adventure" };
                // begin tracking it as an "added" entity
                //db.Add(genre);

                movie.Genre = genre;
                // the new genre gets added to the db because the movie
                // referencing it is tracked.

                // make sure that we are tracking all changes for this object
                // (if it's untracked, start tracking it)
                db.Update(movie);

                // update the database, picking up tracked changes.
                db.SaveChanges();
            }
        }

        static void PrintMovies()
        {
            using (var db = new MoviesDBContext())
            {
                foreach (var item in db.Movie.Include(m => m.Genre))
                {
                    Console.WriteLine($"Name {item.Name}," +
                        $" genre {item.Genre.Name}");
                }
            }
        }
    }
}
