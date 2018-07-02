using PalindromeLibrary;
using System;

namespace PalindromeUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            bool results;
            Palindrome myword = new Palindrome();

            Console.WriteLine("Please enter a string");
            word = Console.ReadLine();

            results  = myword.IsPalindrome(word);

            if (results == true)
            {
                Console.WriteLine("Is Palindrome");
            }
            else
            {
                Console.WriteLine("Is not Plaindrome");
            }

        }
    }
}
