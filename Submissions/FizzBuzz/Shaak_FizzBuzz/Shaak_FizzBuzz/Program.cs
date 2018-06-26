using System;
// For each number from 1 to 1000 in order,
// * print "Fizz" for the ones divisible by 3 (& not 5)
// * print "Buzz" for the ones divisible by 5 (& not 3)
// * print "Fizzbuzz" for the ones divisible by both 3 and 5
// * print the number itself, for all the rest of the numbers
// Also, I want to know, at the end, how many Fizz, how many Buzz, how many Fizzbuzz.
namespace Shaak_FizzBuzz
{
    class Program
    {

        static public void Work()
        {
            int buz = 0;
            int fiz = 0;
            int both = 0;
            int neither = 0;

            for (int i = 1; i < 1001; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    both++;
                }
                else if(i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    fiz++;
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    buz++;
                }
                else
                {
                    Console.WriteLine(i);
                    neither++;
                }
            }

            Console.WriteLine("FizzBuzz: " + both + " Fizz: " + fiz + " Buzz: " + buz + " Neither: " + neither);
        }
        static void Main(string[] args)
        {
            Work();
            Console.ReadLine();
        }
    }
}
