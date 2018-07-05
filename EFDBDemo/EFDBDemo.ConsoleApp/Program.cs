using EFDBDemo.Data;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EFDBDemo.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
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
