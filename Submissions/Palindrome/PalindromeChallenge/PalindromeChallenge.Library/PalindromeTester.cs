using System;

namespace PalindromeChallenge.Library
{
    public static class PalindromeTester
    {
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
