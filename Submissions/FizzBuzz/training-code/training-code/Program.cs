using System;

namespace training_code
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //counter variables for fizz, buzz and fizzbuzz
            var fizz = 0;
            var buzz = 0;
            var fizzBuzz = 0;

            for (int i =1; i <=1000; i++)
            {

                if (FizzBuzz(i) == true)//if is divisible by  3 and 5
                {
                    Console.WriteLine("FizzBuzz");
                    fizzBuzz++;
                }
                else if (Fizz(i) == true)// if is divisible by 3
                {
                    Console.WriteLine("Fizz");
                    fizz++;
                }
                else if (Buzz(i) == true)// if is divisible by 5
                {
                    Console.WriteLine("Buzz");
                    buzz++;
                }
                else
                {
                    Console.WriteLine(i);
                }

            }
            //print the fizz, buzz, fizzbuzz
            Console.WriteLine($"Fizz: {fizz}");
            Console.WriteLine($"Buzz: {buzz}");
            Console.WriteLine($"FizzBuzz: {fizzBuzz}");

            Console.ReadLine();

        }
        static public bool Fizz(int num)
        {
            if (num % 3 == 0)
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
            if (num % 5 == 0 )
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static public bool FizzBuzz(int num)
        {
            if (num % 5 == 0 && num % 3== 0)
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



 // For each number from 1 to 1000 in order,
// * print "Fizz" for the ones divisible by 3 (& not 5)
// * print "Buzz" for the ones divisible by 5 (& not 3)
// * print "Fizzbuzz" for the ones divisible by both 3 and 5
// * print the number itself, for all the rest of the numbers
// Also, I want to know, at the end, how many Fizz, how many Buzz, how many Fizzbuzz.

