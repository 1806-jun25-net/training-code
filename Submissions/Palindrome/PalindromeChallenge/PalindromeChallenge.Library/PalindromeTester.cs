using System;

namespace PalindromeChallenge.Library
{
    public static class PalindromeTester
    {
        public static bool TestForPalindrome(string s)
        {
            if (s == null)
                return false;
            string sPrepped = s.ToLower();
            sPrepped = RemoveSpacePunctuation(sPrepped);
            return IsPalindrome(sPrepped);
        }

        public static string RemoveSpacePunctuation(string s)
        {
            string sPrepped = "";
            for (int i = 0; i<s.Length; i++)
            {
                if (s[i] != ' ' && s[i] != '.' && s[i] != ',' && s[i] != '!')
                    sPrepped = sPrepped + s.Substring(i, 1);
            }
            return sPrepped;
        }

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
