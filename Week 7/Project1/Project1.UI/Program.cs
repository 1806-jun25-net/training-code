using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NLog;
using Project1.ContextLibrary;
using Project1.Library;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Project1.UI
{
    public static class Program
    {
        //set up logging
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            //start logging
            logger.Info("Application starting up");

            //deserialize Inventory and Order History files
            Location.InventoryRecall();
            Location.OrderHistoryRecall();

            Location.InventoryRecall2();
            Location.OrderHistoryRecall2();


            //start program
            Customers.NewCustomer();
            if (Customers.ReturningCustomer2() == "No") //change ReturningCustomer to switch from XML to DB
            {
                Order.OrderPizza();
            }

            //checks if you are allowed to place an order
            if (!Order.CheckTime2(Order.OrderTime, //change CheckTime to switch from XML to DB
                Customers.CustomerName, Order.OrderLocation)) 
            {
                Console.WriteLine("Sorry, you need to wait to place another order or choose a different location" +
                    "\npress any key to exit the program.");
                Console.ReadKey();
                Environment.Exit(0);
            }

            //checks current inventory levels
            //change Check to switch from XML to DB
            if (!Location.Check2(Order.OrderLocation, Order.OrderToppings, Order.OrderSize, Order.OrderQuantity))
            {
                Console.WriteLine("Sorry, that location does not have the ingredients to complete your order" +
                    "\npress any key to exit the program.");
                Console.ReadKey();
                Environment.Exit(0);
            }

            //final decision
            Order.FinalAnswer();

            //add information to DB

            Context.Program.Main();

            //log customer info
            logger.Info($"Customer Name: {Customers.CustomerName}");
            logger.Info($"Order Location: {Order.OrderLocation}");
            logger.Info($"Order Size: {Order.OrderSize}");
            logger.Info($"Order Crust: {Order.OrderCrust}");
            logger.Info($"Order Toppings: {string.Join(", ", Order.OrderToppings.ToArray())}");
            logger.Info($"Order Quantity: {Order.OrderQuantity}");
            logger.Info($"Order Cost: {Order.OrderCost}");

            //serialize Inventory and Order History files
            //Serializer.SerializeInventoryToFile(@"C:\Revature\knain-project1\Project1\locationInventory.xml", Location.LocationInventory);

            //Location.OrderHistoryAdd(Location.OrderHistory);
            //Serializer.SerializeOrderToFile(@"C:\Revature\knain-project1\Project1\orderHistory.xml", Location.OrderHistory);

            //end logging
            logger.Info("Application shutting down");
        }
    }
}
