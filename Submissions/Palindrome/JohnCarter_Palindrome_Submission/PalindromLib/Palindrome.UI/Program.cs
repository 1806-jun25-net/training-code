using Palindrome.Library;
using System;

namespace Palindrome.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            PaliPali check = new PaliPali();
            //Console.WriteLine(   check.PaliChecker("anna"));
            check.PaliChecker("anna");
            Console.ReadKey();
        }
    }
}
