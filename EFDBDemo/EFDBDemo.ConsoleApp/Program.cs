using EFDBDemo.Data;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace EFDBDemo.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            //Console.WriteLine(configuration.GetConnectionString("MoviesDB"));

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
            aMovie.Name = "Star Wars";
            repo.Edit(aMovie);
            repo.AddMovie("Die Hard", DateTime.Now, "action");
            repo.DeleteMovieById(2);
            repo.SaveChanges();

            movies = repo.GetMoviesWithGenres();
            foreach (var item in movies)
            {
                Console.WriteLine($"Name {item.Name}," +
                    $" genre {item.Genre.Name}");
            }
            



            Console.ReadLine();
        }
        static void Previous()
        { 
            AddMovie();
            PrintMovies();
            Console.ReadLine();
        }
         static void PrintMovies()
        {
            using (var db = new MoviesDBContext())
            {
                foreach(var item in db.Movie.Include(m => m.Genre))
                {
                    Console.WriteLine($"Name {item.Name}, " + $" genre {item.Genre.Name}");
                }
            }
        }

        static void AddMovie()
        {
            using (var db = new MoviesDBContext())
            {
            }
        }

       
    }
}
