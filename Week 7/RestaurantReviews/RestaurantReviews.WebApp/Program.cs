using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using RestaurantReviews.Context.Models;

namespace RestaurantReviews.WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();

            // this is how we ask the dependency injector for something
            // if we can't just put it in a constructor
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    using (var context = services.GetRequiredService<RestaurantReviewsDBContext>())
                    {
                        // creates the db with all tables based on dbcontext, if it doesn't exist.
                        // does nothing if it does exist.
                        context.Database.EnsureCreated();

                        // we can put seed data for the db in OnModelCreating
                        // https://docs.microsoft.com/en-us/ef/core/modeling/data-seeding
                    }
                }
                catch (Exception ex)
                {
                    // var logger = services.GetRequiredService<ILogger<Program>>();
                    // logger.LogError(ex, "An error occurred initializing the DB.");
                    Console.WriteLine("An error occurred initializing the DB.");
                }
            }

            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
