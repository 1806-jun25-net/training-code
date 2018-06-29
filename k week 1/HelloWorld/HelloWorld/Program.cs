using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            int integer = 0;  //integer data types
            short sixteenbit = 0;
            long sixtyfourbit = 0;
            byte eightbit = 0;

            float thirtytwobit = 0; //floating point (Decimal) numbers
            double sixtyfourbit = 0; //high precision
            decimal bit128 = 0; //suitable for currency


            var number = 56;
            var number2 = 4.5;

            string name = "My name"; //initialize unicode
            char character = 'a';

            bool trueorfalse = true;

            integer = 5;
            
            if (integer == 5)
            {
                Console.WriteLine(integer);
            }
            else if (integer = 6)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
            }

            // if (integer < 0) return;

            /*
            multiline coment
            */

            //Ternary statement
            //(condition) ? (true value) : (false value)
            var output = (integer < 6) ? "less than 6" : "not less than 6";


            switch (integer)
            {
                case 0:
                    Console.WriteLine();
                    break;
                case 1:
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine();
                    break;
            }

            try
            {
                //code that might throw an exception goes here
                integerArray[10] = 40;
            }
            catch (IndexOutOfRangeException ex)
            {
                //code to recover from the error and log it
                System.Console.WriteLine(ex.Message);
            }
            finally
            {
                //always runs after try and/or catch
                System.Console.WriteLine("finally block");
            }

            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine(i); //cw tab for quick write
            }

            int[] integerArray = new int[10]; //size 10
            integerArray[2] = 6;

            foreach (var item in integerArray)
            {
                System.Console.WriteLine(item);
            }

            Console.WriteLine("Hello World!");
            string userInput = Console.ReadLine();
            System.Console.WriteLine(userinput);


            DateTime GetCurrentTime()
            {
                try
                {
                    return DateTime.Now;
                }
                catch (System.Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                    throw new Exception("Unable to get current time");
                }
            }
        }
    }
}
