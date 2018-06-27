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
    public class FizzBuzz_1000_3_5 : AFizzBuzz // subclass FizzBuzz_1000_3_5 inherits from abstract ckass AFizzBuzz
    {
        // setting fields to the values asked for in the assignment
        public override string Word1 { get; set; } = "Fizz";
        public override string Word2 { get; set; } = "Buzz";
        public override string Word3 { get; set; } = "Fizzbuzz";
        public override int Number { get; set; } = 1000;
        public override int Divider1 { get; set; } = 3;
        public override int Divider2 { get; set; } = 5;
       
    }
}
