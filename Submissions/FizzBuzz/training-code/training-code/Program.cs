using System;

namespace training_code
{
    class Program
    {
        static void Main(string[] args)
        {
            //Counters
            var fizz = 0;
            var buzz = 0;
            var fizzbuzz = 0;

            for (int i=1; i<=1000; i++) //Identifies the numbers divisible by 3,5 or 3 and 5 and increments the counters
            {
                if (Fizzbuzz(i) == true)
                {
                    Console.WriteLine("FizzBuzz");
                    fizzbuzz++;
                }
                else if (Fizz(i) == true)
                {
                    Console.WriteLine("Fizz");
                    fizz++;
                }
                else if (Buzz(i) == true)
                {
                    Console.WriteLine("Buzz");
                    buzz++;
                }
                
                else
                {
                    Console.WriteLine(i);
                }
                
            }


            //Print all the counters
            Console.WriteLine("Fizz = " + fizz);
            Console.WriteLine("Buzz = " + buzz);
            Console.WriteLine("FizzBuzz = " + fizzbuzz);
            Console.ReadLine();

        }

        static public bool Fizz(int num)
        {
            if (num % 3 == 0)//Verify if the number is divisible by 3
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static public bool Buzz(int num)
        {
            if (num % 5 == 0)//Verify if the number is divisible by 5
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static public bool Fizzbuzz(int num)
        {
            if (num % 3 == 0 && num % 5 == 0)//Verify either if the number is divisible by 3 or 5
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
