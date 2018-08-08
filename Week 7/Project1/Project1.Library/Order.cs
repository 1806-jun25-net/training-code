using Project1.ContextLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.Library
{
    public class Order
    {
        public int OrderCheck { get; } = 0;
        public static string CustChecker { get; set; }
        public static string OrderLocation { get; set; }
        public static string OrderSize { get; set; }
        public static string OrderCrust { get; set; }
        public static List<string> OrderToppings { get; set; } = new List<string> { };
        public static int OrderQuantity { get; set; }
        public static double OrderCost { get; set; }
        public static DateTime OrderTime => DateTime.Now;

        public static void OrderPizza()
        {
            Validation.ValidationCheck = 6;
            Console.WriteLine("Which location would you like to order from?");
            Console.WriteLine(Pizza.WriteLine(Location.Locations));

            OrderLocation = Validation.AttemptValidation();

            Validation.ValidationCheck = 2;
            Console.WriteLine("What size Pizza would you like to order?");
            Console.WriteLine(Pizza.WriteLine(Pizza.Size));

            OrderSize = Validation.AttemptValidation();

            Validation.ValidationCheck = 3;
            Console.WriteLine("Please select what type of crust you would like?");
            Console.WriteLine(Pizza.WriteLine(Pizza.Crust));

            OrderCrust = Validation.AttemptValidation();

            Console.WriteLine("What toppings would you like?");
            Console.WriteLine("You may select up to 5 toppings.");

            if (OrderSize == "Small")
            {
                Console.WriteLine($"Since you ordered a {OrderSize} pizza you get 1 free topping," +
                    $" any toppings after that cost $1.00");
            }
            else
                Console.WriteLine($"Since you ordered a {OrderSize} pizza you get 2 free toppings," +
                    $" any toppings after that cost $1.00");

            Console.WriteLine("When you are done selecting toppings just leave it blank.");
            Validation.ValidationCheck = 4;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(Pizza.WriteLine(Pizza.TempToppings));
                OrderToppings.Add(item: Validation.AttemptValidation());
                if (OrderToppings[i] == "")
                {
                    OrderToppings.Remove("");
                    break;
                }
                Pizza.RemoveToppings();
                Console.WriteLine("\n");
            }

            Validation.ValidationCheck = 5;
            Console.WriteLine($"How many {OrderSize} pizzas would you like to order?");
            OrderQuantity = Convert.ToInt32(Validation.AttemptValidation());

            OrderCost = CalculateCost(OrderSize, OrderToppings, OrderQuantity);

            Console.WriteLine($"Current total: ${OrderCost}\n");
        }

        public static void FinalAnswer()
        {
            Validation.ValidationCheck = 10;

            Console.WriteLine($"Location: {Order.OrderLocation}" +
                $"\nSize: {Order.OrderSize}" +
                $"\nCrust: {Order.OrderCrust}" +
                $"\nToppings: {string.Join(", ", Order.OrderToppings.ToArray())}" +
                $"\nQuantity: {Order.OrderQuantity}" +
                $"\nCost: {Order.OrderCost}");
            Console.WriteLine("\nPlease type Yes to complete your order" +
                "\n or type No to cancel your order");

            Validation.AttemptValidation();
        }

        public static bool CheckTime(DateTime time)
        {
            if (Location.OrderHistory.Count == 0)
            {
                return true;
            }

            for (int a = 0; a < Location.OrderHistory.Count; a++)
            {
                int marker = Location.OrderHistory.Count - 1 - a;
                if (Location.OrderHistory[marker].CustName == Customers.CustomerName ||
                    Location.OrderHistory[marker].OrderLocation == OrderLocation)
                {
                    //checks your last order time
                    if (time - Location.OrderHistory[marker].OrderTime > TimeSpan.FromHours(2))
                    {
                        return true;
                    }
                    return false;
                }
            }
            return true;
        }

        public static bool CheckTime2(DateTime time, string name, string location)
        {
            if (Location.OrderHistory2.Count == 0)
            {
                return true;
            }

            for (int a = 0; a < Location.OrderHistory2.Count; a++)
            {
                int marker = Location.OrderHistory.Count - 1 - a;
                if (Location.OrderHistory2[marker].Customer.CustomerName == name ||
                    Location.OrderHistory2[marker].Location.LocationName == location)
                {
                    //checks your last order time
                    if (time - Location.OrderHistory2[marker].OrderTime > TimeSpan.FromHours(2))
                    {
                        return true;
                    }
                    return false;
                }
            }
            return true;
        }

        public static double CalculateCost(string size, List<string> toppings, int quantity)
        {
            double Cost;
            if (size == "Small")
            {
                Cost = Pizza.Price[0];
                if (toppings.Count > 1)
                {
                    Cost += (toppings.Count - 1) * 1.0;
                }
            }

            else if (size == "Medium")
            {
                Cost = Pizza.Price[1];
                if (toppings.Count > 2)
                {
                    Cost += (toppings.Count - 1) * 1.0;
                }
            }

            else
            {
                Cost = Pizza.Price[2];
                if (toppings.Count > 2)
                {
                    Cost += (toppings.Count - 1) * 1.0;
                }
            }
            OrderCost = Cost * quantity;
            return OrderCost;
        }

        public static void WriteOrder(int marker)
        {
            Console.WriteLine($"Order Time: {Location.OrderHistory[marker].OrderTime}" +
                $"\nCustomer Name: {Location.OrderHistory[marker].CustName}" +
                $"\nOrder Location: {Location.OrderHistory[marker].OrderLocation}" +
                $"\nOrder Size: {Location.OrderHistory[marker].OrderSize}" +
                $"\nOrder Crust: {Location.OrderHistory[marker].OrderCrust}" +
                $"\nOrder Toppings: {string.Join(", ", Location.OrderHistory[marker].OrderToppings.ToArray())}" +
                $"\nOrder Quantity: {Location.OrderHistory[marker].OrderQuantity}" +
                $"\nOrder Cost: {Location.OrderHistory[marker].OrderCost}\n");
        }

        public static void EarliestOrder()
        {
            Console.WriteLine("Order History sorted by time from Earliest to Latest");
            for (int i = 0; i < Location.OrderHistory.Count; i++)
            {
                int marker = Location.OrderHistory.Count - 1 - i;
                WriteOrder(marker);
            }
        }
        public static void LatestOrder()
        {
            Console.WriteLine("Order History sorted by time from Latest to Earliest");
            for (int i = 0; i < Location.OrderHistory.Count; i++)
            {
                WriteOrder(i);
            }
        }

        public static void CheapestOrder()
        {
            List<int> used = new List<int> { };

            for (int a = 0; a < Location.OrderHistory.Count; a++)
            {
                double lowest = 500;
                int marker = 0;
                for (int i = 0; i < Location.OrderHistory.Count; i++)
                {
                    if (!used.Contains(i) || Location.OrderHistory[i].OrderCost < lowest)
                    {
                        marker = i;
                        lowest = Location.OrderHistory[i].OrderCost;
                    }
                }
                used.Add(marker);
                WriteOrder(marker);
            }
        }

        public static void MostExpensiveOrder()
        {
            List<int> used = new List<int> { };

            for (int a = 0; a < Location.OrderHistory.Count; a++)
            {
                double highest = 0;
                int marker = 0;
                for (int i = 0; i < Location.OrderHistory.Count; i++)
                {
                    if (!used.Contains(i) || Location.OrderHistory[i].OrderCost > highest)
                    {
                        marker = i;
                        highest = Location.OrderHistory[i].OrderCost;
                    }
                }
                used.Add(marker);
                WriteOrder(marker);
            }
        }

        public static void EarliestOrder2()
        {
            Console.WriteLine("Order History sorted by time from Earliest to Latest");
            for (int i = 0; i < Location.OrderHistory2.Count; i++)
            {
                int marker = Location.OrderHistory2.Count - 1 - i;
                PizzaRepos.WritePizzaOrder(marker);
            }
        }
        public static void LatestOrder2()
        {
            Console.WriteLine("Order History sorted by time from Latest to Earliest");
            for (int i = 0; i < Location.OrderHistory2.Count; i++)
            {
                PizzaRepos.WritePizzaOrder(i);
            }
        }

        public static void CheapestOrder2()
        {
            List<int> used = new List<int> { };

            for (int a = 0; a < Location.OrderHistory2.Count; a++)
            {
                double lowest = 500;
                int marker = 0;
                for (int i = 0; i < Location.OrderHistory2.Count; i++)
                {
                    if (!used.Contains(i) || Location.OrderHistory2[i].OrderCost < lowest)
                    {
                        marker = i;
                        lowest = Location.OrderHistory2[i].OrderCost.Value;
                    }
                }
                used.Add(marker);
                PizzaRepos.WritePizzaOrder(marker);
            }
        }

        public static void MostExpensiveOrder2()
        {
            List<int> used = new List<int> { };

            for (int a = 0; a < Location.OrderHistory2.Count; a++)
            {
                double highest = 0;
                int marker = 0;
                for (int i = 0; i < Location.OrderHistory2.Count; i++)
                {
                    if (!used.Contains(i) || Location.OrderHistory2[i].OrderCost > highest)
                    {
                        marker = i;
                        highest = Location.OrderHistory2[i].OrderCost.Value;
                    }
                }
                used.Add(marker);
                PizzaRepos.WritePizzaOrder(marker);
            }
        }
    }
}

