using System;

namespace FizzBuzz
{
    class Program
    {
        static void Print(string s)
        {
            System.Console.WriteLine(s);
        }

        static void Fizzbuzz(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                if (i % 15 == 0) Print("Fizzbuzz");
                else if (i % 3 == 0) Print("Fizz");
                else if (i % 5 == 0) Print("Buzz");
                else System.Console.WriteLine(i);
            }
            System.Console.WriteLine("Total Fizz: " + n / 3);
            System.Console.WriteLine("Total Buzz: " + n / 5);
            System.Console.WriteLine("Total Fizzbuzz: " + n / 15);
        }
        static void Main(string[] args)
        {
            Fizzbuzz(1000);
            System.Console.ReadLine();
        }
    }
}
