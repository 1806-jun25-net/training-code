using System;

namespace fizzbuzzproject
{
    class Program
    {
        //solution to coding challenge
        static void FizzBuzz()
        {
            int totalFizz = 0;
            int totalBuzz = 0;
            int totalFizzbuzz = 0;
            string[] numberfizzbuzz = new string[1000];

            Console.WriteLine($"Total number of Fizzes is: {totalFizz}");
            Console.WriteLine($"Total number of Buzzes is: {totalBuzz}");
            Console.WriteLine($"Total number of Fizzbuzzes is: {totalFizzbuzz}");
        }

        //main used to call solution method
        static void Main(string[] args)
        {
            FizzBuzz();
        }
    }
}
