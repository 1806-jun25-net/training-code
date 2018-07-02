using System;
using System.Collections.Generic;
using System.Text;

namespace Plaindrome.Library
{
    class Palindrome
    {
        public bool IsPalindrome(string palindrome)
        {
            bool SameBothWays = true;
            string StringToCheck = "";

            palindrome = palindrome.ToLower();
            StringToCheck = RemoveWhiteSpace(palindrome);

            for (int i = 0; i < StringToCheck.Length / 2; i++)
            {
                if (StringToCheck[i] != StringToCheck[StringToCheck.Length - i])
                {
                    SameBothWays = false;
                }
            }

            return SameBothWays;
        }

        public string RemoveWhiteSpace(string pal)
        {
            string StringToCheck = "";
            for (int i = 0; i < pal.Length; i++)
            {
                if (!Char.IsWhiteSpace(pal[i]))
                {
                    StringToCheck = StringToCheck + pal[i];
                }

            }
            return StringToCheck;
        }
    }
}
