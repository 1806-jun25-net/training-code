using System;
using FizzBuzz;

namespace FizzBuzzVS
{
    class Program
    {
        static void Main(string[] args)
        {


            // For each number from 1 to 1000 in order,
            // * print "Fizz" for the ones divisible by 3 (& not 5)
            // * print "Buzz" for the ones divisible by 5 (& not 3)
            // * print "Fizzbuzz" for the ones divisible by both 3 and 5
            // * print the number itself, for all the rest of the numbers
            // Also, I want to know, at the end, how many Fizz, how many Buzz, how many Fizzbuzz.

            FBClass fb = new FBClass();

            fb.MethodFB();
            


        }
    }
}
