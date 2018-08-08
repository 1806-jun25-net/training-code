using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Project1.ContextLibrary;
using Project1.Library;
using System;
using System.Collections.Generic;
using System.IO;

namespace Project1.Context
{
    public static class Program
    {
        public static void Main()
        {
            //get the configuration from file
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            var optionsBuilder = new DbContextOptionsBuilder<Project1Context>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("Project1"));

            var repo = new PizzaRepos(new Project1Context(optionsBuilder.Options));

            repo.UpdateLocationInventory(Order.OrderLocation, Order.OrderSize, Order.OrderToppings, Order.OrderQuantity);

            int custId = repo.CheckCustomerId(Customers.CustomerName);
            int locationId = repo.LookupLocationId(Order.OrderLocation);
            int pizzaId = repo.LookupPizzaId(Order.OrderSize, Order.OrderCrust);

            repo.AddPizzaOrder(custId, locationId, pizzaId, Order.OrderQuantity, Order.OrderCost, Order.OrderTime);
            repo.AddPizzaOrderToppings(Order.OrderToppings);

            repo.SaveChanges();

        }
    }
}
