using System;

namespace RTFizzbuzz
{
    class Program
    {
        static int FizzCounter, BuzzCounter, FizzbuzzCounter;

        static void Main(string[] args)
        {
            for (int i = 1; i<1001; i++)
            {
                fizzbuzz(i);
            }
            Console.WriteLine("Fizz: " + FizzCounter);
            Console.WriteLine("Buzz: " + BuzzCounter);
            Console.WriteLine("Fizzbuzz: " + FizzbuzzCounter);
        }

        static void fizzbuzz(int num)
        {
            if ((num % 3) == 0 && (num % 5) == 0)
            {
                Console.WriteLine("Fizzbuzz");
                FizzbuzzCounter++;
            }
            else if ((num % 3) == 0)
            {
                Console.WriteLine("Fizz");
                FizzCounter++;
            }
            else if((num % 5) == 0)
            {
                Console.WriteLine("Buzz");
                BuzzCounter++;
            }
            else
            {
                Console.WriteLine(num);
            }
        }
    }
}
