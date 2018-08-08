using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.Library
{
    public static class Pizza
    {
        public static List<string> Size { get; } = new List<string> { "Small", "Medium", "Large" };
        public static List<double> DoughUsed { get; } = new List<double> { 1.0, 1.5, 2 };
        public static List<string> Crust { get; } = new List<string> { "Hand Tossed", "Deep Dish", "Thin Crust" };
        public static List<string> Toppings { get; } = new List<string>
            { "Anchovies", "Bacon", "Chicken", "Mushrooms", "Olives", "Onions", "Pepperoni", "Peppers", "Salami", "Sausage" };
        public static List<string> TempToppings { get; set; } = new List<string>(Toppings);

        public static List<double> Price { get; } = new List<double> { 5.95, 7.95, 9.95 };

        public static string WriteLine(List<string> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                if (Validation.ValidationCheck == 2)
                {
                    Console.WriteLine($"{input[i]}: ${Price[i]}");
                }
                else
                    Console.WriteLine(input[i]);
            }
            return null;
        }

        public static void RemoveToppings()
        {
            foreach (var item in Order.OrderToppings)
            {
                TempToppings.Remove(item);
            }
        }

        public static bool TestSize(List<string> input)
        {
            Validation validation = new Validation();
            bool output = validation.TestValidation(Pizza.Size, input);
            return output;
        }

        public static bool TestCrust(List<string> input)
        {
            Validation validation = new Validation();
            bool output = validation.TestValidation(Pizza.Crust, input);
            return output;
        }

        public static bool TestToppings(List<string> input)
        {
            Validation validation = new Validation();
            bool output = validation.TestValidation(Pizza.Toppings, input);
            return output;
        }
    }
}
