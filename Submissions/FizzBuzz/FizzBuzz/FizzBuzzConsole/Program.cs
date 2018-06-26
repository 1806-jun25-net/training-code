using System;

namespace FizzBuzzConsole
{
    class Program
    {
        static int fizzcount = 0;
        static int buzzcount = 0;
        static int fizzbuzzcount = 0;

        static void fizzBuzzSoundsLikeaClown(int a)
        {
            if (a % 3 == 0 && a % 5 == 0)
            {
                Console.WriteLine("Fizzbuzz");
                fizzbuzzcount++;
            }
            else if (a % 3 == 0)
            {
                Console.WriteLine("Fizz");
                fizzcount++;
            }
            else if (a % 5 == 0)
            {
                Console.WriteLine("Buzz");
                buzzcount++;
            }
            else
            {
                Console.WriteLine(a);
            }
        }

        static void Main(string[] args)
        {
            for (int i = 1; i < 1001; i++)
            {
                fizzBuzzSoundsLikeaClown(i);
            }
            Console.WriteLine("Fizz count is " + fizzcount);
            Console.WriteLine("Buzz count is " + buzzcount);
            Console.WriteLine("Fizzbuzz count is " + fizzbuzzcount);
        }
    }
}
