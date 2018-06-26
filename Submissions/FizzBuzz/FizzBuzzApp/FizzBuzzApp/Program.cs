using System;

namespace FizzBuzzApp
{
    class Program
    {

        static void Main(string[] args)
        {
            FizzBuzzMethod();
           

        }


        static void FizzBuzzMethod()
        {
            int fizzCount = 0;
            int buzzCount = 0;
            int fizzBuzzCount = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 15 == 0)  // if it is divisible by 3 and 5, it will be divisible by 15

                {
                    Console.WriteLine("Fizzbuzz");
                    fizzBuzzCount++;
                }
                // checking for fizzbuzz first to avoid exiting too early. For example printing either just fizz or just buzz for 30
                // as long as fizzbuzz is first the next two are fine in any order because it could only be one of them

                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    buzzCount++;
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    fizzCount++;
                }
                else
                    Console.WriteLine(i);

            }

            Console.WriteLine("Fizzbuzz Count = " + fizzBuzzCount);
            Console.WriteLine("Buzz Count = " + buzzCount);
            Console.WriteLine("Fizz Count = " + fizzCount);
        }

    }
}
