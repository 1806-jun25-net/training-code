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
            //variables to keep track of the number of buzz, fizz, fizzbuzz, and numbers
            int buz = 0;
            int fiz = 0;
            int both = 0;
            int neither = 0;

            //loop runs 1 - 1000 incrementing 1 at a time
            for (int i = 1; i < 1001; i++)
            {
                // sees if the number can be divided by 3 and 5 evenly
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz"); //prints fizzbuzz
                    both++; //increments both by 1
                }
                //sees if the number can be divided by 3 evenly
                else if(i % 3 == 0)
                {
                    Console.WriteLine("Fizz"); //prints fizz
                    fiz++; //increments fiz by 1
                }
                //sees if the number can be divided by 5 evenly
                else if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz"); //prints buzz
                    buz++; //increments buz by 1
                }
                else
                //if number is not divisible by 5 or 3 then print the number
                {
                    Console.WriteLine(i); //prints number that is i
                    neither++; //increments neither by 1
                }
            }
            //resutls calculated and written out
            Console.WriteLine("FizzBuzz: " + both + " Fizz: " + fiz + " Buzz: " + buz + " Neither: " + neither); 
        }
        //Main method
        static void Main(string[] args)
        {
            Work(); //runs the work method
            Console.ReadLine(); // keeps console open to see results. Hit enter to close.
        }
    }
}
