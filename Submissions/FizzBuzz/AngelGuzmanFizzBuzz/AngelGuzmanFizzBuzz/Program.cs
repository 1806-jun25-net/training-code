using System;

namespace AngelGuzmanFizzBuzz
{
    class Program
    {

        static void FizzBuzzcheck()
        {
            int Fizz = 0, Buzz = 0, Fizzbuzz = 0;

            for (int i = 1; i <= 1000; i++) // Counting from 1 to 1000.
            {

                if (i % 3 == 0 && i % 5 == 0) // Cheking if it divided by the number(i) is divided by 3 and 5, and counting the Fizzbuzz.
                {
                    Console.WriteLine(i + " ==== Fizzbuzz");
                    Fizzbuzz++;
                }
                else if (i % 3 == 0) // Cheking if it divided by the number(i) is divided by 3, and counting the Fizz.
                {
                    Console.WriteLine(i + " ==== Fizz");
                    Fizz++;
                }
                else if (i % 5 == 0) // Cheking if it divided by the number(i) is divided by 5, and counting the Buzz.
                {
                    Console.WriteLine(i + " ==== Buzz");
                    Buzz++;
                }
                else
                {
                    Console.WriteLine(i); // printing the number, not divided by 3 or 5.
                }
            }

            Console.WriteLine("|Fizz: " + Fizz + "|    |Buzz: " + Buzz + "|    |Fizzbuzz: " + Fizzbuzz + "|"); // Printing how many Fizz, Buzz, Fizzbuzz 
        }

        static void Menu() // Explanation of what the program do.
        {
            Console.WriteLine("Cheking what numbers can be divided by 3 and 5 from 1 to 1000"); 
            Console.WriteLine("Press any key to continue....");
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Menu();
            FizzBuzzcheck();
            Console.ReadLine();
        }
    }
}
