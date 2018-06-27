// C.Coronado

// For each number from 1 to 1000 in order,
// * print "Fizz" for the ones divisible by 3 (& not 5)
// * print "Buzz" for the ones divisible by 5 (& not 3)
// * print "Fizzbuzz" for the ones divisible by both 3 and 5
// * print the number itself, for all the rest of the numbers
// Also, I want to know, at the end, how many Fizz, how many Buzz, how many Fizzbuzz.

using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz.Library
{
    public class OFizzBuzz : IFizzBuzz // implementing the IFizzBuzz interface
    {
        // fields
        public string Word1 { get; set; } = "Fizz";
        public string Word2 { get; set; } = "Buzz";
        public string Word3 { get; set; } = "Fizzbuzz";
        public int CountWord1 { get; set; } = 0; // setting initial count values to 0
        public int CountWord2 { get; set; } = 0;
        public int CountWord3 { get; set; } = 0;
        public int Number { get; set; }
        public int Divider1 { get; set; }
        public int Divider2 { get; set; }

        // constructor
        public OFizzBuzz(int number, int divider1, int divider2)
        {
            Number = number;
            Divider1 = divider1;
            Divider2 = divider2;
        }


        // methods
        public bool CheckDivisible(int number, int divider) // method checks if a number is divisible by another number; returns a boolean
        {
            if (number % divider == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DoFizzBuzz() // method to carry out FizzBuzz operation
        {
            // loops through the amount set by Number and checks divisibility
            for (int i = 1; i <= Number; i++)
            {
                if ((CheckDivisible(i, Divider1)) && (CheckDivisible(i, Divider2))) // check if a number if divisible by both divider numbers first
                {
                    Console.WriteLine(Word3);
                    CountWord3++;
                }
                else if (CheckDivisible(i, Divider1)) // check if number is divisible by first divider number
                {
                    Console.WriteLine(Word1);
                    CountWord1++;
                }
                else if (CheckDivisible(i, Divider2)) // check if number is divisible by first divider number
                {
                    Console.WriteLine(Word2);
                    CountWord2++;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            // prints the word counts
            Console.WriteLine($"There are {CountWord1} instances of {Word1}.");
            Console.WriteLine($"There are {CountWord2} instances of {Word2}.");
            Console.WriteLine($"There are {CountWord3} instances of {Word3}.");

        }
    }
}
