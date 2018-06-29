using System;

namespace HelloWorld
{
    class Program
    {   
        static void PrintFizzBuzz()
        {
            int fizz = 0, buzz = 0, fizzbuzz = 0;
            for(int i = 1; i <= 1000; i++)
            {
                if(i % 3 == 0 && i % 5 ==0)
                {
                    Console.WriteLine("FizzBuzz");
                    fizzbuzz++;
                }
                else if(i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    fizz++;
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    buzz++;
                }
                else
                    Console.WriteLine(i);
            
            }
            Console.WriteLine("Fizz count: " + fizz);
            Console.WriteLine("Buzz count: " + buzz);
            Console.WriteLine("FizzBuzz count: " + fizzbuzz);
        }
        static void Main(string[] args)
        {
            PrintFizzBuzz();
        }
    }
}
