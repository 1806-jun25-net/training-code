using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Project1.ContextLibrary
{
    public class PizzaRepos
    {
        private readonly Project1Context project1;

        public PizzaRepos(Project1Context input)
        {
            project1 = input ?? throw new ArgumentException(nameof(input));
        }

        public List<PizzaOrder> GetPizzaOrders()
        {
            List<PizzaOrder> pizzaOrders =
                project1.PizzaOrder.Include(c => c.Customer).Include(l => l.Location)
                .Include(p => p.Pizza).Include(po => po.PizzaOrderToppings).AsNoTracking().ToList();
            return pizzaOrders;
        }

        public List<PizzaOrder> GetPizzaOrders(string input)
        {
            List<PizzaOrder> pizzaOrders =
                project1.PizzaOrder.Include(c => c.Customer).Include(l => l.Location)
                .Include(p => p.Pizza).Include(po => po.PizzaOrderToppings)
                .AsNoTracking().Where(a => a.Customer.CustomerName.Contains(input)).ToList();
            return pizzaOrders;
        }

        public List<LocationInventory> GetInventories()
        {
            List<LocationInventory> inventories =
                project1.LocationInventory.Include(p => p.PizzaOrder).AsNoTracking().ToList();
            return inventories;
        }

        public List<Pizza> GetPizzas()
        {
            List<Pizza> pizzas = project1.Pizza.AsNoTracking().ToList();
            return pizzas;
        }

        public static void WritePizzaOrder(int marker)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            var optionsBuilder = new DbContextOptionsBuilder<Project1Context>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("Project1"));

            var repo = new PizzaRepos(new Project1Context(optionsBuilder.Options));

            List<PizzaOrder> pizzaOrders = repo.GetPizzaOrders();
            List<string> toppings;

            toppings = new List<string> { };
            foreach (var item in pizzaOrders[marker].PizzaOrderToppings)
            {
                toppings.Add(item.ToppingName.ToString());
            }

            Console.WriteLine($"Customer Name: {pizzaOrders[marker].Customer.CustomerName}" +
                $"\nLocation Name: {pizzaOrders[marker].Location.LocationName}" +
                $"\nPizza Size: {pizzaOrders[marker].Pizza.PizzaSize}" +
                $"\nPizza Crust: {pizzaOrders[marker].Pizza.PizzaCrust}" +
                $"\nPizza Toppings: {string.Join(", ", toppings.ToArray())}" +
                $"\nOrder Quantity: {pizzaOrders[marker].PizzaQuantity}" +
                $"\nOrder Cost: {pizzaOrders[marker].OrderCost}" +
                $"\nOrder Time: {pizzaOrders[marker].OrderTime}\n");

        }

        public static void WriteInventory(int marker)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            var optionsBuilder = new DbContextOptionsBuilder<Project1Context>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("Project1"));

            var repo = new PizzaRepos(new Project1Context(optionsBuilder.Options));

            List<LocationInventory> inventories = repo.GetInventories();
            
            Console.WriteLine($"\nLocation Name: {inventories[marker].LocationName}" +
                $"\nDough: {inventories[marker].Dough}" +
                $"\nAnchovies: {inventories[marker].Anchovies}" +
                $"\nBacon: {inventories[marker].Bacon}" +
                $"\nChicken: {inventories[marker].Chicken}" +
                $"\nMushrooms: {inventories[marker].Mushrooms}" +
                $"\nOlives: {inventories[marker].Olives}" +
                $"\nOnions: {inventories[marker].Onions}" +
                $"\nPepperoni: {inventories[marker].Pepperoni}" +
                $"\nPeppers: {inventories[marker].Peppers}" +
                $"\nSalami: {inventories[marker].Salami}" +
                $"\nSausage: {inventories[marker].Sausage}");
        }

        public int CheckCustomerId(string custName)
        {
            List<Customer> customers = project1.Customer.AsNoTracking().ToList();
            int custId = 0;

            foreach (var item in customers)
            {
                if (item.CustomerName == custName)
                {
                    custId = item.CustomerId;
                    break;
                }
            }

            if (custId != 0)
            {
                return custId;
            }
            else
                AddCustomer(custName);
            return customers[customers.Count - 1].CustomerId + 1;
        }

        public bool CheckCustomerName(string name)
        {
            List<Customer> customers = project1.Customer.AsNoTracking().ToList();

            foreach (var item in customers)
            {
                if (item.CustomerName == name)
                {
                    return true;
                }
            }
            return false;
        }

        public void AddCustomer(string custName)
        {
            var customer = new Customer
            {
                CustomerName = custName
            };
            project1.Add(customer);
            project1.SaveChanges();
        }

        public int LookupPizzaId(string size, string crust)
        {
            List<Pizza> pizza = GetPizzas();
            int PizzaId = 0;

            for (int a = 0; a < pizza.Count; a++)
            {
                if (pizza[a].PizzaSize == size && pizza[a].PizzaCrust == crust)
                {
                    PizzaId = pizza[a].PizzaId;
                    break;
                }
            }
            return PizzaId;
        }

        public int LookupLocationId(string name)
        {
            List<LocationInventory> locations = GetInventories();
            int LocationId = 0;

            for (int a = 0; a < locations.Count; a++)
            {
                if (locations[a].LocationName == name)
                {
                    LocationId = a + 1;
                    break;
                }
            }
            return LocationId;
        }

        public void AddPizzaOrder(int cId, int lId, int pId, int pQuantity, double oCost, DateTime dateTime)
        {
            var pizzaOrder = new PizzaOrder
            {
                CustomerId = cId,
                LocationId = lId,
                PizzaId = pId,
                PizzaQuantity = pQuantity,
                OrderCost = oCost,
                OrderTime = dateTime
            };
            project1.Add(pizzaOrder);
            SaveChanges();
        }

        public void AddPizzaOrderToppings(List<string> toppings)
        {
            List<PizzaOrder> pizzaOrders = GetPizzaOrders();
            int pizzaOrderId = pizzaOrders[pizzaOrders.Count - 1].PizzaOrderId;
            foreach (var item in toppings)
            {
                var pizzaOrderToppings = new PizzaOrderToppings
                {
                    PizzaOrderId = pizzaOrderId,
                    ToppingName = item
                };
                project1.Add(pizzaOrderToppings);
            }
            SaveChanges();
        }

        public void UpdateLocationInventory(string location, string size, List<string> toppings, int quantity)
        {
            int LocationId = LookupLocationId(location);
            LocationInventory inventory = new LocationInventory { };
            var locations = GetInventories();
            for (int a = 0; a < locations.Count; a++)
            {
                if (locations[a].LocationId == LocationId)
                {
                    inventory = locations[a];
                    break;
                }
            }
            
            double doughUsed;

            if (size == "Small")
            {
                doughUsed = 1;
            }
            else if (size == "Medium")
            {
                doughUsed = 1.5;
            }
            else
            {
                doughUsed = 2;
            }

            inventory.Dough -= doughUsed * quantity;

            for (int a = 0; a < toppings.Count; a++)
            {
                switch (toppings[a])
                {
                    case "Anchovies":
                        inventory.Anchovies -= quantity;
                        break;

                    case "Bacon":
                        inventory.Bacon -= quantity;
                        break;

                    case "Chicken":
                        inventory.Chicken -= quantity;
                        break;

                    case "Mushrooms":
                        inventory.Mushrooms -= quantity;
                        break;

                    case "Olives":
                        inventory.Olives -= quantity;
                        break;

                    case "Onions":
                        inventory.Onions -= quantity;
                        break;

                    case "Pepperoni":
                        inventory.Pepperoni -= quantity;
                        break;

                    case "Peppers":
                        inventory.Peppers -= quantity;
                        break;

                    case "Salami":
                        inventory.Salami -= quantity;
                        break;

                    case "Sausage":
                        inventory.Sausage -= quantity;
                        break;
                }
            }
            project1.Update(inventory);
            SaveChanges();
        }

        public void SaveChanges()
        {
            project1.SaveChanges();
        }
    }
}

