using System;
using System.Collections.Generic;
using System.Text;

namespace Palindrome.Library
{
    public class Palindrome
    {
        public string PalindromeString { get; set; }

        public bool PalindromeStatus()
        {
            string palindrome = CleanUpPalindrome();
            // get the half of the string
            string secondHalf = this.PalindromeString.Substring(0, this.PalindromeString.Length / 2);
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
