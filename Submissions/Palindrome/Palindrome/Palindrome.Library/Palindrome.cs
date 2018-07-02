using System;
using System.Collections.Generic;
using System.Text;

namespace Palindrome.Library
{
    public class Palindrome
    {
        public Palindrome(string input)
        {
            PalindromeString = input;
        }

        public string PalindromeString { get; set; }

        public bool PalindromeStatus()
        {
            // clean up the palindrome for comparison
            string palindrome = CleanUpPalindrome();

            // get half of the string
            string secondHalf = palindrome.Substring(0, this.PalindromeString.Length / 2);
            // turn it into an array of characters
            char[] characterArray = secondHalf.ToCharArray();
            // reverse the order
            Array.Reverse(characterArray);
            // convert back to an array
            string tempHalf = new string(characterArray);

            return false;
        }

        public string CleanUpPalindrome()
        {
            // trim whitespace, special characters, and set string to lowercase
            char[] delimiters = { ' ', ',', '"', '\'', ':', ';', '[', ']', '{', '}', '/', '\\', '|' };
            // delete unnecessary white space before and after the string, convert string to lowercase.
            string tempString = PalindromeString.Trim().ToLower();
            // remove all special characters and white spaces within the string
            string cleanPalindrome = tempString.Split(delimiters).ToString();
            return cleanPalindrome;
        }
    }
}
