using CodingChallenge2.library;
using System;

namespace CodingChallenge.Test
{
    public class Program
    {


        static void Main(string[] args)
        {
           
            Console.WriteLine("Type what you think is a palimdrome");
            string x = Console.ReadLine();
            Verification word = new Verification();
            if (word.CheckStringArray(x) == true)
            {
                Console.WriteLine(x + " Is a Palindrome!!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(x + " Is not a Palindrome");
                Console.ReadLine();
            }
        }
    }
}
