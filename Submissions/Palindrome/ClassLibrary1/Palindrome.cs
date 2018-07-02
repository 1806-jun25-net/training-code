using System;
using System.Linq;

namespace PalindromeLibrary
{
    public class Palindrome

    {


     public bool ReverseString(string originalString)

        {
            char[] arr = originalString.ToCharArray();
            char[] arr2 = originalString.ToCharArray();
            Array.Reverse(arr);

            if (PalindromeTest(arr, arr2))
            {
                Console.WriteLine(arr2 + " is a palindrome.");
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool PalindromeTest(char[] s1, char[] s2)
        {
            return (s1.SequenceEqual(s2)); 
            
        }
    }
}
