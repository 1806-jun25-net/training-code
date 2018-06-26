using System;

namespace FizzBuz.Console
{
    class Program
    {
        static void FizBuz (int a)
        {
            switch (a)
            {
                case 1:
                    if a % 3 == 0 && a % 5 != 0
                        Console.WriteLine("Fizz");
                    break;
                case 2:
                    if a % 5 == 0 && a % 3 != 0
                        Console.WriteLine("Buzz");
                    break;
                case 3:
                    if a % 3 == 0 && a % 5 == 0
                        Console.WriteLine("FizzBuzz")
                default
                    Console.WriteLine(a)
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
