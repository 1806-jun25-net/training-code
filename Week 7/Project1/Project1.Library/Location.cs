using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Project1.ContextLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Library
{
    public static class Location
    {
        public static List<SerializeOrder> OrderHistory { get; set; } = new List<SerializeOrder> { };
        public static List<PizzaOrder> OrderHistory2 { get; set; } = new List<PizzaOrder> { };
        public static List<SerializeInventory> LocationInventory { get; set; } = new List<SerializeInventory> { };
        public static List<LocationInventory> LocationInventory2 { get; set; } = new List<LocationInventory> { };
        private static int LocationMarker = 0;

        public static List<string> Locations { get; } = new List<string> { "Herndon", "Reston", "Fairfax" };

        public static void OrderHistoryAdd(List<SerializeOrder> input)
        {
            input.Add(new SerializeOrder
            {
                CustName = Customers.CustomerName,
                OrderLocation = Order.OrderLocation,
                OrderSize = Order.OrderSize,
                OrderCrust = Order.OrderCrust,
                OrderToppings = Order.OrderToppings,
                OrderQuantity = Order.OrderQuantity,
                OrderCost = Order.OrderCost,
                OrderTime = Order.OrderTime
            });
        }

        public static void OrderHistoryRecall()
        {
            string path = Path.Combine(Environment.CurrentDirectory, "orderHistory.xml");
            Task<IEnumerable<SerializeOrder>> deserializeFile = Serializer.DeserializeOrderFromFile(path);
            IEnumerable<SerializeOrder> order = new List<SerializeOrder>();
            try
            {
                order = deserializeFile.Result;
            }
            catch (AggregateException)
            {
                Console.WriteLine("Order History File was not found.");
            }
            OrderHistory.AddRange(order);
        }

        public static void InventoryRecall()
        {
            string path = Path.Combine(Environment.CurrentDirectory, "locationInventory.xml");
            Task<IEnumerable<SerializeInventory>> deserializeFile = Serializer.DeserializeInventoryFromFile(path);
            IEnumerable<SerializeInventory> inventory = new List<SerializeInventory>();
            try
            {
                inventory = deserializeFile.Result;
            }
            catch (AggregateException)
            {
                Console.WriteLine("Location Inventory File was not found.");
            }
            LocationInventory.AddRange(inventory);
        }

        public static void OrderHistoryRecall2()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            var optionsBuilder = new DbContextOptionsBuilder<Project1Context>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("Project1"));

            var repo = new PizzaRepos(new Project1Context(optionsBuilder.Options));

            List<PizzaOrder> pizzaOrders = repo.GetPizzaOrders();
            OrderHistory2 = pizzaOrders;
        }

        public static void InventoryRecall2()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            var optionsBuilder = new DbContextOptionsBuilder<Project1Context>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("Project1"));

            var repo = new PizzaRepos(new Project1Context(optionsBuilder.Options));

            List<LocationInventory> inventory = repo.GetInventories();
            LocationInventory2 = inventory;
        }

        public static void WriteInventory(int marker)
        {
            Console.WriteLine($"\nLocation Name: {LocationInventory[marker].Location}" +
                $"\nDough: {LocationInventory[marker].Dough}" +
                $"\nAnchovies: {LocationInventory[marker].ToppingLevels[0]}" +
                $"\nBacon: {LocationInventory[marker].ToppingLevels[1]}" +
                $"\nChicken: {LocationInventory[marker].ToppingLevels[2]}" +
                $"\nMushrooms: {LocationInventory[marker].ToppingLevels[3]}" +
                $"\nOlives: {LocationInventory[marker].ToppingLevels[4]}" +
                $"\nOnions: {LocationInventory[marker].ToppingLevels[5]}" +
                $"\nPepperoni: {LocationInventory[marker].ToppingLevels[6]}" +
                $"\nPeppers: {LocationInventory[marker].ToppingLevels[7]}" +
                $"\nSalami: {LocationInventory[marker].ToppingLevels[8]}" +
                $"\nSausage: {LocationInventory[marker].ToppingLevels[9]}");
        }

        public static bool Check(string location, List<string> toppings, string size, int quantity)
        {
            bool check = false;
            int checkNum = 0;

            //set location marker
            for (int i = 0; i < LocationInventory.Count; i++)
            {
                if (location == LocationInventory[i].Location)
                {
                    LocationMarker = i;
                    break;
                }
            }

            //check if location has enough toppings and removes toppings if enough is available
            for (int a = 0; a < toppings.Count; a++)
            {
                for (int b = 0; b < Pizza.Toppings.Count; b++)
                {
                    if (toppings[a] == Pizza.Toppings[b] || quantity <= Int32.Parse(LocationInventory[LocationMarker].ToppingLevels[b]))
                    {
                        checkNum++;
                        int newQuantity = Int32.Parse(LocationInventory[LocationMarker].ToppingLevels[b]) - quantity;
                        LocationInventory[LocationMarker].ToppingLevels[b] = newQuantity.ToString();
                    }
                }
            }

            //check if location has enough dough and removes dough if enough is available
            for (int i = 0; i < Pizza.Size.Count; i++)
            {
                if (size == Pizza.Size[i] || Pizza.DoughUsed[i] * quantity <= LocationInventory[LocationMarker].Dough)
                {
                    LocationInventory[LocationMarker].Dough -= Pizza.DoughUsed[i] * quantity;
                    checkNum++;
                }
            }

            if (checkNum == toppings.Count + 1)
            {
                check = true;
            }

            return check;
        }

        public static bool Check2(string location, List<string> toppings, string size, int quantity)
        {
            bool check = false;
            int checkNum = 0;

            //set location marker
            for (int i = 0; i < LocationInventory2.Count; i++)
            {
                if (location == LocationInventory2[i].LocationName)
                {
                    LocationMarker = i;
                    break;
                }
            }

            for (int a = 0; a < toppings.Count; a++)
            {
                switch (toppings[a])
                {
                    case "Anchovies":
                        if (quantity <= LocationInventory2[LocationMarker].Anchovies)
                        {
                            checkNum++;
                        }
                        break;

                    case "Bacon":
                        if (quantity <= LocationInventory2[LocationMarker].Bacon)
                        {
                            checkNum++;
                        }
                        break;

                    case "Chicken":
                        if (quantity <= LocationInventory2[LocationMarker].Chicken)
                        {
                            checkNum++;
                        }
                        break;

                    case "Mushrooms":
                        if (quantity <= LocationInventory2[LocationMarker].Mushrooms)
                        {
                            checkNum++;
                        }
                        break;

                    case "Olives":
                        if (quantity <= LocationInventory2[LocationMarker].Olives)
                        {
                            checkNum++;
                        }
                        break;

                    case "Onions":
                        if (quantity <= LocationInventory2[LocationMarker].Onions)
                        {
                            checkNum++;
                        }
                        break;

                    case "Pepperoni":
                        if (quantity <= LocationInventory2[LocationMarker].Pepperoni)
                        {
                            checkNum++;
                        }
                        break;

                    case "Peppers":
                        if (quantity <= LocationInventory2[LocationMarker].Peppers)
                        {
                            checkNum++;
                        }
                        break;

                    case "Salami":
                        if (quantity <= LocationInventory2[LocationMarker].Salami)
                        {
                            checkNum++;
                        }
                        break;

                    case "Sausage":
                        if (quantity <= LocationInventory2[LocationMarker].Sausage)
                        {
                            checkNum++;
                        }
                        break;
                }
            }

            //check if location has enough dough and removes dough if enough is available
            for (int i = 0; i < Pizza.Size.Count; i++)
            {
                if (size == Pizza.Size[i])
                {
                    if (Pizza.DoughUsed[i] * quantity <= LocationInventory2[LocationMarker].Dough)
                    {
                        LocationInventory2[LocationMarker].Dough -= Pizza.DoughUsed[i] * quantity;
                        checkNum++;
                    }
                    break;
                }
            }

            if (checkNum == toppings.Count + 1)
            {
                check = true;
            }

            return check;
        }

        public static void LocationOrderHistory()
        {
            Console.WriteLine("Which Location would you like to see an Order History for?");
            string input = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < OrderHistory.Count; i++)
            {
                int marker = OrderHistory.Count - 1 - i;
                if (OrderHistory[marker].OrderLocation == input)
                {
                    count++;
                    Order.WriteOrder(marker);
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Sorry, I couldn't find any order for that Location.");
            }
        }

        public static void LocationOrderHistory2()
        {
            Console.WriteLine("Which Location would you like to see an Order History for?");
            string input = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < OrderHistory2.Count; i++)
            {
                int marker = OrderHistory2.Count - 1 - i;
                if (OrderHistory2[marker].Location.LocationName == input)
                {
                    count++;
                    PizzaRepos.WritePizzaOrder(marker);
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Sorry, I couldn't find any order for that Location.");
            }
        }

        public static void LocationInventoryLevels()
        {
            Console.WriteLine("Which Location would you like to see Inventory Levels for?");
            string input = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < LocationInventory.Count; i++)
            {
                int marker = LocationInventory.Count - 1 - i;
                if (LocationInventory[marker].Location == input)
                {
                    count++;
                    WriteInventory(marker);
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Sorry, I couldn't find any order for that Location.");
            }
        }

        public static void LocationInventoryLevels2()
        {
            Console.WriteLine("Which Location would you like to see Inventory Levels for?");
            string input = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < LocationInventory2.Count; i++)
            {
                int marker = LocationInventory2.Count - 1 - i;
                if (LocationInventory2[marker].LocationName == input)
                {
                    count++;
                    PizzaRepos.WriteInventory(marker);
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Sorry, I couldn't find any order for that Location.");
            }
        }
    }
}
