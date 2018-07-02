using Palindrom;
using System;

namespace PalindromCodingChallenge
{
    class Program
    {
        public static void Main(string[] args)
        {
            //create palindrom object
            var palin = new Palindrome();
            //take user input
            string input = palin.GetPalindrom();
            //test input for palindrom true/false
            bool isPalin = palin.IsPalindrom(input);

            Console.ReadLine();
        }
    }
}
