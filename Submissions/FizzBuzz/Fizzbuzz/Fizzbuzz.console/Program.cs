using System;

namespace Fizzbuzz.console
{
    class Program
    {
        static void Main(string[] args)
        {
            Fizzbuzz();
            Console.WriteLine("Press enter to close..");
            Console.Read();
        }
        static void Fizzbuzz()
        {
            int fizzCount = 0;
            int buzzCount = 0;
            int FizzbuzzCount = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Fizzbuzz");
                    FizzbuzzCount += 1;
                }
                else if (i % 3 == 0 && i % 5 != 0)
                {
                    Console.WriteLine("Fizz");
                    fizzCount += 1;
                }
                else if (i % 3 != 0 && i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    buzzCount += 1;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Fizz count: " + fizzCount);
            Console.WriteLine("Buzz count: " + buzzCount);
            Console.WriteLine("Fizzbuzz count: " + FizzbuzzCount);
        }
    }
}
