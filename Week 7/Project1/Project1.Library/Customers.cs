using Project1.ContextLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1.Library
{
    public static class Customers
    {
        public static List<string> Checker { get; set; } = new List<string> { "New", "Returning" };
        public static string CustomerName { get; set; }

        public static void NewCustomer()
        {
            Console.WriteLine("Welcome to Wayne's World Pizzeria!");
            Console.WriteLine("Are you a new customer or a returning one?" +
                "\nPlease type New or Returning.");

            Validation.ValidationCheck = 1;
            Order.CustChecker = Validation.AttemptValidation();

            if (Order.CustChecker == "New")
            {
                Console.WriteLine("Since you're new here can I get your first and last name, " +
                    "or you may enter nothing and your data will not be saved.");
                CustomerName = Validation.ReadNext();

                if (CustomerName == "")
                {
                    CustomerName = "Guest";
                }
            }
            else if (Order.CustChecker == "Password123")
            {
                Manager2(); //change this line to switch from XML to DB
            }
        }

        public static string ReturningCustomer()
        {
            if (Order.CustChecker == "Returning")
            {
                Console.WriteLine("Can you please enter your first and last name.");
                CustomerName = Validation.ReadNext();

                //searches for customer's most recent order and populates the terminal
                Console.WriteLine($"Hello {CustomerName}, welcome!");
                if (PreviousOrder(0) == "No")
                {
                    return "No";
                }
                Console.WriteLine($"\nWould you like to order your most recent order:" +
                    $"\nLocation: {PreviousOrder(1)}" +
                    $"\nSize: {PreviousOrder(2)}" +
                    $"\nCrust: { PreviousOrder(3)}" +
                    $"\nToppings: {PreviousOrder(4)}" +
                    $"\nQuantity: {PreviousOrder(5)}" +
                    $"\nCost: {PreviousOrder(6)}");

                Console.WriteLine("Please type Yes to order your most recent order " +
                    "or type No to order a new pizza.\n");

                Validation.ValidationCheck = 7;
                if (Validation.AttemptValidation() == "Yes")
                {
                    Order.OrderLocation = PreviousOrder(1);
                    Order.OrderSize = PreviousOrder(2);
                    Order.OrderCrust = PreviousOrder(3);
                    Order.OrderToppings = PreviousOrder(4).Split(", ").ToList();
                    Order.OrderQuantity = Int32.Parse(PreviousOrder(5));
                    Order.OrderCost = Double.Parse(PreviousOrder(6));
                    return "Yes";
                }
            }
            return "No";
        }

        public static string ReturningCustomer2()
        {
            if (Order.CustChecker == "Returning")
            {
                Console.WriteLine("Can you please enter your first and last name.");
                CustomerName = Validation.ReadNext();

                //searches for customer's most recent order and populates the terminal
                Console.WriteLine($"Hello {CustomerName}, welcome!");
                if (PreviousOrder2(0) == "No")
                {
                    return "No";
                }
                Console.WriteLine($"Would you like to order your most recent order:" +
                    $"\nLocation: {PreviousOrder2(1)}" +
                    $"\nSize: {PreviousOrder2(2)}" +
                    $"\nCrust: { PreviousOrder2(3)}" +
                    $"\nToppings: {PreviousOrder2(4)}" +
                    $"\nQuantity: {PreviousOrder2(5)}" +
                    $"\nCost: {PreviousOrder2(6)}");

                Console.WriteLine("Please type Yes to order your most recent order " +
                    "or type No to order a new pizza.\n");

                Validation.ValidationCheck = 7;
                if (Validation.AttemptValidation() == "Yes")
                {
                    Order.OrderLocation = PreviousOrder2(1);
                    Order.OrderSize = PreviousOrder2(2);
                    Order.OrderCrust = PreviousOrder2(3);
                    Order.OrderToppings = PreviousOrder2(4).Split(", ").ToList();
                    Order.OrderQuantity = Int32.Parse(PreviousOrder2(5));
                    Order.OrderCost = Double.Parse(PreviousOrder2(6));
                    return "Yes";
                }
            }
            return "No";
        }

        public static bool TestChecker(List<string> input)
        {
            Validation validation = new Validation();
            bool output = validation.TestValidation(Customers.Checker, input);
            return output;
        }

        //code to retrieve customer's previous order
        public static string PreviousOrder(int place)
        {
            int marker = -1;

            for (int i = 0; i < Location.OrderHistory.Count; i++)
            {
                if (Location.OrderHistory[Location.OrderHistory.Count - 1 - i].CustName == CustomerName)
                {
                    marker = Location.OrderHistory.Count - 1 - i;
                    break;
                }
            }

            if (marker == -1)
            {
                Console.WriteLine($"Sorry we don't have a previous customer named {CustomerName}" +
                    $"\nwe'll start you on a new order.\n");
                return "No";
            }

            switch (place)
            {
                case 1:
                    return Location.OrderHistory[marker].OrderLocation;

                case 2:
                    return Location.OrderHistory[marker].OrderSize;

                case 3:
                    return Location.OrderHistory[marker].OrderCrust;

                case 4:
                    return string.Join(", ", Location.OrderHistory[marker].OrderToppings.ToArray());

                case 5:
                    return Location.OrderHistory[marker].OrderQuantity.ToString();

                case 6:
                    return Location.OrderHistory[marker].OrderCost.ToString();

                default:
                    return null;
            }
        }

        public static string PreviousOrder2(int place)
        {
            int marker = -1;

            for (int i = 0; i < Location.OrderHistory2.Count; i++)
            {

                if (Location.OrderHistory2[Location.OrderHistory2.Count - 1 - i].Customer.CustomerName == CustomerName)
                {
                    marker = Location.OrderHistory2.Count - 1 - i;
                    break;
                }
            }

            if (marker == -1)
            {
                Console.WriteLine($"Sorry we don't have a previous customer named {CustomerName}" +
                    $"\nwe'll start you on a new order.\n");
                return "No";
            }

            switch (place)
            {
                case 1:
                    return Location.OrderHistory2[marker].Location.LocationName;

                case 2:
                    return Location.OrderHistory2[marker].Pizza.PizzaSize;

                case 3:
                    return Location.OrderHistory2[marker].Pizza.PizzaCrust;

                case 4:
                    List<string> toppings = new List<string> { };
                    foreach (var item in Location.OrderHistory2[marker].PizzaOrderToppings)
                    {
                        toppings.Add(item.ToppingName.ToString());
                    }
                    return string.Join(", ", toppings.ToArray());

                case 5:
                    return Location.OrderHistory2[marker].PizzaQuantity.ToString();

                case 6:
                    return Location.OrderHistory2[marker].OrderCost.ToString();

                default:
                    return null;
            }
        }

        public static void CustomerOrderHistory()
        {
            Console.WriteLine("Which Customer would you like to see an Order History for?");
            string input = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < Location.OrderHistory.Count; i++)
            {
                int marker = Location.OrderHistory.Count - 1 - i;
                if (Location.OrderHistory[marker].CustName == input)
                {
                    count++;
                    Order.WriteOrder(marker);
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Sorry, I couldn't find a Customer with that name.");
            }
        }

        public static void CustomerOrderHistory2()
        {
            Console.WriteLine("Which Customer would you like to see an Order History for?");
            string input = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < Location.OrderHistory2.Count; i++)
            {
                int marker = Location.OrderHistory2.Count - 1 - i;
                if (Location.OrderHistory2[marker].Customer.CustomerName == input)
                {
                    count++;
                    PizzaRepos.WritePizzaOrder(marker);
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Sorry, I couldn't find a Customer with that name.");
            }
        }

        public static void Manager()
        {
            string input = null;
            do
            {
                Console.WriteLine("\nWhat records would you like today Mr. President.\n");
                Console.WriteLine("1. Order History sorted from Earliest to Latest" +
                    "\n2. Order History sorted from Latest to Earliest" +
                    "\n3. Order History sorted from Cheapest to Most Expensive" +
                    "\n4. Order History is sorted from Most Expensive to Cheapest" +
                    "\n5. Order History for a specific Customer" +
                    "\n6. Order History for a specific Location" +
                    "\n7. Inventory Levels for a specific Location");
                Console.WriteLine("Please select a number 1 through 6 or type Done to exit");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Order.EarliestOrder();
                        break;

                    case "2":
                        Order.LatestOrder();
                        break;

                    case "3":
                        Order.CheapestOrder();
                        break;

                    case "4":
                        Order.MostExpensiveOrder();
                        break;

                    case "5":
                        CustomerOrderHistory();
                        break;

                    case "6":
                        Location.LocationOrderHistory();
                        break;

                    case "7":
                        Location.LocationInventoryLevels();
                        break;
                }
            } while (input != "Done");
            Environment.Exit(0);
        }

        public static void Manager2()
        {
            string input = null;
            do
            {
                Console.WriteLine("\nWhat records would you like today Mr. President.\n");
                Console.WriteLine("1. Order History sorted from Earliest to Latest" +
                    "\n2. Order History sorted from Latest to Earliest" +
                    "\n3. Order History sorted from Cheapest to Most Expensive" +
                    "\n4. Order History is sorted from Most Expensive to Cheapest" +
                    "\n5. Order History for a specific Customer" +
                    "\n6. Order History for a specific Location" +
                    "\n7. Inventory Levels for a specific Location");
                Console.WriteLine("Please select a number 1 through 7 or type Done to exit");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Order.EarliestOrder2();
                        break;

                    case "2":
                        Order.LatestOrder2();
                        break;

                    case "3":
                        Order.CheapestOrder2();
                        break;

                    case "4":
                        Order.MostExpensiveOrder2();
                        break;

                    case "5":
                        CustomerOrderHistory2();
                        break;

                    case "6":
                        Location.LocationOrderHistory2();
                        break;

                    case "7":
                        Location.LocationInventoryLevels2();
                        break;
                }
            } while (input != "Done");
            Environment.Exit(0);
        }
    }
}
