using System;

namespace FizzBuzz.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz();
        }

        static void FizzBuzz()
        {
            int fizzes = 0, buzzes = 0, fizzbuzzes = 0;
            
            for(int i = 1; i <= 1000; i++)
            {
                if(i % 3 == 0 & i % 5 == 0)
                {
                    System.Console.WriteLine("Fizzbuzz");
                    fizzbuzzes++;
                }
                else if(i % 3 == 0)
                {
                    System.Console.WriteLine("Fizz");
                    fizzes++;
                }
                else if(i % 5 == 0)
                {
                    System.Console.WriteLine("Buzz");
                    buzzes++;
                }
                else
                {
                    System.Console.WriteLine(i);
                }
            }

            System.Console.WriteLine($"There were {fizzes} Fizzes, {buzzes} Buzzes, " +
                $"and {fizzbuzzes} Fizzbuzzes.");
        }
    }
}
