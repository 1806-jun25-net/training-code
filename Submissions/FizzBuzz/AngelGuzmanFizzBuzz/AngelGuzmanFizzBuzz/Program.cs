using System;

namespace AngelGuzmanFizzBuzz
{
    class Program
    {
        
        static void FizzBuzzcheck()
        {
            int Fizz = 0, Buzz = 0, Fizzbuzz = 0;

            for (int i = 1; i <= 1000; i++)
            {

                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i + " ==== Fizzbuzz");
                    Fizzbuzz++;
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(i + " ==== Fizz");
                    Fizz++;
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i + " ==== Buzz");
                    Buzz++;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("|Fizz: " + Fizz + "|    |Buzz: " + Buzz + "|    |Fizzbuzz: " + Fizzbuzz + "|");
        }

        static void Main(string[] args)
        {
            FizzBuzzcheck();
            Console.ReadLine();
        }
    }
}
