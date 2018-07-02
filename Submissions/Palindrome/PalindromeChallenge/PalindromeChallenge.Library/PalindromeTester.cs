using System;

namespace PalindromeChallenge.Library
{
    public static class PalindromeTester
    {
        /// <summary>
        /// Primary method for testing if a string is a Palindrome.  
        /// Converts string to lower case and uses RemoveSpacePunctuation for the rest.
        /// </summary>
        /// <param name="s">The string to be tested</param>
        /// <returns>true if string is palindrome no matter the spacing or simple punctuation; false if not a palindrome or if string is null</returns>
        public static bool TestForPalindrome(string s)
        {
            if (s == null)
                return false;
            string sPrepped = s.ToLower();
            sPrepped = RemoveSpacePunctuation(sPrepped);
            return IsPalindrome(sPrepped);
        }

        /// <summary>
        /// Helper method to prepare string for IsPalindrome.  Removes all spaces and punctuatino from string
        /// </summary>
        /// <param name="s">The string to be cleaned.</param>
        /// <returns>s cleaned of all spaces and common punctuation.</returns>
        public static string RemoveSpacePunctuation(string s)
        {
            string sPrepped = "";
            for (int i = 0; i<s.Length; i++)
            {
                if (s[i] != ' ' && s[i] != '.' && s[i] != ',' && s[i] != '!' && s[i] != '?' && s[i] != ':' && s[i] != ';')
                    sPrepped = sPrepped + s.Substring(i, 1);
            }
            return sPrepped;
        }

        /// <summary>
        /// Recursive method to determine if given string is a palindrome character for character.
        /// Is sensitive to capitalization, spaces, and punctuation.  
        /// Ie "a x xa" is not a palindrome per this method.
        /// </summary>
        /// <param name="s"></param>
        /// <returns>true if s is a palindrome or empty string, false otherwise</returns>
        public static bool IsPalindrome(string s)
        {
            //base case:
            if (s.Length <= 1)
                return true;
            //recursive step: (can assume s.Length >=2
            else
            {
                if (s[0] == s[s.Length - 1])
                    return IsPalindrome(s.Substring(1, s.Length - 2));
                else
                    return false;
            }
        }
    }
}
