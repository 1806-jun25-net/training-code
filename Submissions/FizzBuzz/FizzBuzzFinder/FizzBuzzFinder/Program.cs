using System;

namespace FizzBuzzFinder
{
    class Program
    {
        static void PrintFizzbuzz()
        {
            int fizzCount = 0;
            int buzzCount = 0;
            int fizzbuzzCount = 0;

            for (int i=1; i <= 1000; i++)
            {
                switch (CalculateMod15Divisibility(i))
                {
                    case 0:
                        Console.WriteLine(i);
                        break;
                    case 1:
                        Console.WriteLine("Fizz");
                        fizzCount++;
                        break;
                    case 2:
                        Console.WriteLine("Buzz");
                        buzzCount++;
                        break;
                    case 3:
                        Console.WriteLine("Fizzbuzz");
                        fizzbuzzCount++;
                        break;
                }
            }
            Console.WriteLine($"Total Fizz: {fizzCount}");
            Console.WriteLine($"Total Buzz: {buzzCount}");
            Console.WriteLine($"Total Fizzbuzz: {fizzbuzzCount}");
        }

        static int CalculateMod15Divisibility(int num)
        {
            int tally = 0;
            if (num % 3 == 0)
                tally += 1;
            if (num % 5 == 0)
                tally += 2;
            return tally;
        }

        static void Main(string[] args)
        {
            PrintFizzbuzz();
        }
    }
}
