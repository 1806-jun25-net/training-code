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
            //get the configuration from file
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            //now I can access the connection string like this
            //this will fail if there isn't an appsettings with this connection string
            Console.WriteLine(configuration.GetConnectionString("MoviesDB"));

            Console.WriteLine("Hello World!");
            //PrintMovies();
            //ChangeMovie();
            //PrintMovies();

            var optionsBuilder = new DbContextOptionsBuilder<MoviesDBContext>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("MoviesDB"));

            var repo = new MovieRepository(new MoviesDBContext(optionsBuilder.Options));

            var movies = repo.GetMoviesWithGenres();

            //edit a movie
            var aMovie = movies.First();
            aMovie.Name = "Water Boy";
            repo.Edit(aMovie);
            //repo.AddMovie("Die Hard", DateTime.Now, "action");
            repo.DeleteByID(3); //works but you need to drop the trigger preventing deletion
            repo.SaveChanges();


            foreach (var item in movies)
            {
                Console.WriteLine($"Name {item.Name}, " +
                    $"genre {item.Genre.Name}");
            }

            //using (var db = new MoviesDBContext(optionsBuilder.Options))
            //{
            //    foreach (var item in db.Movie.Include(m => m.Genre))
            //    {
            //        Console.WriteLine($"Name {item.Name}," +
            //            $" genre {item.Genre.Name}");
            //    }
            //}

            //var movie = new Movie { Id = 1, Name = "Toy Story", GenreId = 1 };
            ////at this point movie is untracked
            //using (var db = new MoviesDBContext())
            //{
            //    //begin tracking
            //    db.Update(movie);

            //    //push changes to db
            //    db.SaveChanges();
            //}
        }

        static void ChangeMovie()
        {
            using (var db = new MoviesDBContext())
            {
                //this entity is tracked
                var movie = db.Movie.OrderBy(mbox => mbox.Name).First();

                //edit movie name
                movie.Name = "Solo";

                //create untracked genre entity
                //var genre = new Genre { Name = "Adventure" };

                //begin tracking it as an added entity
                //takes any entity object and begins tracking it, in the added state, eventually an insert
                //db.Add(genre);

                //the new genre gets added to the db because the movie referencing it is tracked
                //movie.Genre = genre;

                //makes sure that we are tracking all changes for this object
                //if it's untracked, start tracking it
                db.Update(movie);

                //pushes changes to database, picking up tracked changes.
                db.SaveChanges();
            }
        }

        static void PrintMovies()
        {
            using (var db = new MoviesDBContext())
            {
                foreach (var item in db.Movie.Include(m => m.Genre))
                {
                    Console.WriteLine($"Name {item.Name}, " +
                        $"Genre {item.Genre.Name}");
                }
            }
        }
    }
}
