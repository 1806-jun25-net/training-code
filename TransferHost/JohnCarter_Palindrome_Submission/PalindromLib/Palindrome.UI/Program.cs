using Palindrome.Library;
using System;

namespace Palindrome.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            PaliPali check = new PaliPali();
            Console.WriteLine(   check.PaliChecker("Racecar"));
            //check.PaliChecker("nurses run");
            Console.ReadKey();
        }
    }
}
