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
    public interface IFizzBuzz
    {
        // fields
        string Word1 { get; set; }
        string Word2 { get; set; }
        string Word3 { get; set; }
        int CountWord1 { get; set; }
        int CountWord2 { get; set; }
        int CountWord3 { get; set; }
        int Number { get; set; }
        int Divider1 { get; set; }
        int Divider2 { get; set; }

        // methods
        bool CheckDivisible(int number, int divider);
        void DoFizzBuzz();
    }

}
