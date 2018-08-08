using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.Library
{
    public class Validation
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public static int ValidationCheck { get; set; }

        public static string AttemptValidation()
        {
            string checker = null;

            for (int i = 0; i < 6; i++)
            {
                checker = ReadNext();
                string message = "Sorry I didn't understand that, could you please type a valid pizza ";

                switch (ValidationCheck)
                {
                    case 1:
                        if (checker == "New" || checker == "Returning" || checker == "Password123")
                        {
                            return checker;
                        }
                        else
                        {
                            Console.WriteLine("Sorry I didn't understand that, could you please typing New or Returning");
                        }
                        break;

                    case 2:
                        for (int a = 0; a < Pizza.Size.Count; a++)
                        {
                            if (checker == Pizza.Size[a])
                            {
                                return checker;
                            }
                        }
                        Console.WriteLine(message + "size.");
                        break;

                    case 3:
                        for (int a = 0; a < Pizza.Crust.Count; a++)
                        {
                            if (checker == Pizza.Crust[a])
                            {
                                return checker;
                            }
                        }
                        Console.WriteLine(message + "crust.");
                        break;

                    case 4:
                        for (int a = 0; a < Pizza.Toppings.Count; a++)
                        {
                            if (Pizza.TempToppings.Contains(checker) || checker == Pizza.Toppings[a] || checker == "")
                            {
                                return checker;
                            }
                        }
                        Console.WriteLine(message + "topping.");
                        break;

                    case 5:
                        for (int a = 1; a < 13; a++)
                        {
                            if (checker == Convert.ToString(a))
                            {
                                return checker;
                            }
                        }
                        Console.WriteLine("Please enter a valid quantity.");
                        break;

                    case 6:
                        for (int a = 0; a < Location.Locations.Count; a++)
                        {
                            if (checker == Location.Locations[a])
                            {
                                return checker;
                            }
                        }
                        Console.WriteLine("Please enter a valid location");
                        break;

                    case 7:
                        if (checker == "Yes" || checker == "No")
                        {
                            return checker;
                        }
                        else
                        {
                            Console.WriteLine("Sorry I didn't understand that, could you please typing Yes or No");
                        }
                        break;

                    case 10:
                        if (checker == "Yes")
                        {
                            return checker;
                        }

                        else if (checker == "No")
                        {
                            Environment.Exit(0);
                        }
                        break;
                }

                if (i == 4)
                {
                    Console.WriteLine("\nYou may only try one more time or you will be forced to exit.");
                }
            }
            logger.Info("Order Canceled because of too many wrong attempts");
            logger.Info("Application shutting down");
            Environment.Exit(0);
            return null;
        }

        public bool TestValidation(List<string> actual, List<string> input)
        {
            bool checker = false;
            int checkNum = 0;

            foreach (var size in actual)
            {
                foreach (var item in input)
                {
                    if (size == item)
                    {
                        checkNum++;
                    }
                }
            }

            if (checkNum == input.Count)
            {
                checker = true;
            }

            return checker;
        }

        public static string ReadNext()
        {
            return Console.ReadLine();
        }
    }
}
