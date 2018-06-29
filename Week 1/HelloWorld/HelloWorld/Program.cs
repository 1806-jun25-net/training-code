using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer = 0; // integer data types
            short sixteenbit = 0;
            long sixtyfourbit = 0;
            byte eightbit = 0; // default 0

            float thirtytwobitfloat = 0; // floating-point (decimal) numbers
            double sixtyfourbitfloat = 0;
            decimal bit128 = 0; // suitable for currency

            var number = 45;
            var number2 = 4.5;

            string name = "Ny name"; // immutable Unicode
            char character = 'a';

            bool trueorfalse = true;

            integer = 5;

            // control statements
            // if, else
            if (integer == 5)
            {
                Console.WriteLine(integer);
            }
            else if (integer == 6)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("none of the conditions match");
            }

            switch (integer)
            {
                case 0:
                    Console.WriteLine();
                    break;
                case 1:
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("none of the cases matched");
                    break;
            }

            // ternary statement
            // (condition) ? (true-value) : (false-value)
            var output = (integer < 6) ? "less than 6" : "not less than 6";

            /*
            asdfasdf
            */
            // if (integer < 0) return;

            // loops
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine(i);
            }

            var array = new object[4];

            int[] integerArray = new int[10]; // size 10
            integerArray[2] = 6;
            // integerArray[10] = 40; <--- throws an exception

            foreach (var item in integerArray)
            {
                System.Console.WriteLine(item);
            }

            while (trueorfalse)
            {
                trueorfalse = false;
            }

            do
            {
                trueorfalse = true;
            } while (!trueorfalse);

            // exception handling in C#

            try
            {
                // code that might throw an exception goes here
                integerArray[10] = 40;
            }
            catch (IndexOutOfRangeException ex)
            {
                // code to recover from the error and log it
                System.Console.WriteLine(ex.Message);
            }
            finally
            {
                // always runs after try and/or catch
                System.Console.WriteLine("finally block");
            }

            Console.WriteLine("Hello World!");

            string userInput = Console.ReadLine();
            System.Console.WriteLine(userInput);

            Employee newEmployee = new Employee();
            System.Console.WriteLine(newEmployee.name);
            System.Console.WriteLine(newEmployee.PaycheckAmount(4));
        }

        DateTime GetCurrentTime()
        {
            try
            {
                return DateTime.Now;
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                throw new Exception("Unable to get current time.");
            }
        }
    }
}
