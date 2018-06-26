using System;

namespace fizzbuzz
{
    public class Fizzbuzz
    {

        static void Main(string[] args)
        {

            FizzBuzz();
        }

        static void FizzBuzz()
        {
            int fizzbuzzcount = 0; //Counts the number of Fizzbuzz's
            int buzzcount = 0; //Counts the number of Buzz's
            int fizzcount = 0; //Counts the number of Fizz's
            for (int number = 1; number < 1001; number++)
            {
                if (number % 15 == 0) //checks if number has a factor or 3 & 5
                {
                    Console.WriteLine("Fizzbuzz");
                    fizzbuzzcount++;
                }
                else if (number % 5 == 0) //checks if number has a factor of 5 and not 3, since the first if statement takes priority
                {
                    Console.WriteLine("Buzz");
                    buzzcount++;
                }
                else if (number % 3 == 0) //checks if number has a factor of 3 and not 5, since the first 2 if statements take priority
                {
                    Console.WriteLine("Fizz");
                    fizzcount++;
                }
                else
                {
                    Console.WriteLine(number);
                }
           }
            Console.WriteLine("Fizz count: {0}, Buzz count: {1}, Fizzbuzz count: {2}", fizzcount, buzzcount, fizzbuzzcount);
            Console.ReadKey();
        }
    }
}