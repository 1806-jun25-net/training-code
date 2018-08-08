using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Project1.ContextLibrary;
using Project1.Library;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace Project1.XUnit
{
    public class Tester
    {
        public List<string> Checker = new List<string> { "New" };
        public List<string> PizzaSize = new List<string> { "Small" };
        public List<string> PizzaCrust = new List<string> { "Deep Dish" };
        public List<string> PizzaToppings = new List<string> { "Bacon", "Peppers" };
        [Fact]
        public void TestChecker()
        {
            bool expected = true;

            Assert.Equal(expected, Customers.TestChecker(Checker));
        }

        [Fact]
        public void TestSize()
        {
            bool expected = true;

            Assert.Equal(expected, Library.Pizza.TestSize(PizzaSize));
        }

        [Fact]
        public void TestCrust()
        {
            bool expected = true;

            Assert.Equal(expected, Library.Pizza.TestCrust(PizzaCrust));
        }

        [Fact]
        public void TestToppings()
        {
            bool expected = true;

            Assert.Equal(expected, Library.Pizza.TestToppings(PizzaToppings));
        }

        [Fact]
        public void TestPizzaLookup()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            //Console.WriteLine(configuration.GetConnectionString("Project1"));

            var optionsBuilder = new DbContextOptionsBuilder<Project1Context>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("Project1"));

            var repo = new PizzaRepos(new Project1Context(optionsBuilder.Options));

            string size = "Small";
            string crust = "Hand Tossed";

            int low = 1;
            int high = 9;

            Assert.InRange(repo.LookupPizzaId(size, crust), low, high);
        }


        [Fact]
        public void TestInventoryTrue()
        {
            Location.InventoryRecall();

            string location = "Herndon";
            List<string> toppings = new List<string> { "Bacon", "Sausage" };
            string size = "Large";
            int quantity = 3;

            bool expected = true;

            //change Check to switch from XML to DB
            Assert.Equal(expected, Location.Check(location, toppings, size, quantity));
        }

        [Fact]
        public void TestInventoryFalse()
        {
            Location.InventoryRecall();

            string location = "Herndon";
            List<string> toppings = new List<string> { "Bacon", "Sausage" };
            string size = "Large";
            int quantity = 12;

            bool expected = false;

            //change Check to switch from XML to DB
            Assert.Equal(expected, Location.Check(location, toppings, size, quantity));
        }

        [Fact]
        public void TestInventoryTrue2()
        {
            Location.InventoryRecall2();

            string location = "Herndon";
            List<string> toppings = new List<string> { "Bacon", "Sausage" };
            string size = "Large";
            int quantity = 3;

            bool expected = true;

            //change Check to switch from XML to DB
            Assert.Equal(expected, Location.Check2(location, toppings, size, quantity));
        }

        [Fact]
        public void TestInventoryFalse2()
        {
            Location.InventoryRecall2();

            string location = "Herndon";
            List<string> toppings = new List<string> { "Bacon", "Sausage" };
            string size = "Large";
            int quantity = 12;

            bool expected = false;

            //change Check to switch from XML to DB
            Assert.Equal(expected, Location.Check2(location, toppings, size, quantity));
        }
    }
}