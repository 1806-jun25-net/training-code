using EFDBFirstDemo.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EFDBFirstDemo.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // ORM: Object-relational mapper Do operations on C# objects and have those get translsated behind the scenes to SQL queries
            // Our ORM in .NET is: Entity Framework
            // We wiill use database-first approach to EF
            Console.WriteLine("Hello World!");
            PrintMovies();
            ChangeMovie();
            PrintMovies();

        }

        static void ChangeMovie()
        {
            using (var db = new MoviesDBContext())
            {
                //get the first movie by name
                var movie = db.Movie.OrderBy(m => m.Name).First();
                movie.Name = "Solo";

                //create (untracked) genre entity
                var genre = new Genre { Name = "Action/Adventure" };
                //begin tracking it as an "added" entity
                db.Add(genre);

                movie.Genre = genre;

                //make sure that we are tracking all changes for this object
                //(if it's untracked, start tracking it)
                db.Update(movie);

                //update the database
                db.SaveChanges();
            }
        }

        static void PrintMovies()
        {
            using (var db = new MoviesDBContext())
            {
                foreach (var item in db.Movie.Include(m => m.Genre))
                {
                    Console.WriteLine($"{item.Name}, " +
                        $"Genre: {item.Genre.Name}");
                }
            }
        }
    }
}
