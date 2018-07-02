using System;
using System.Collections.Generic;
using System.Text;

namespace Plaindrome.Library
{
    public class Palindrome
    {
        public string newPalindrome { get; set; }

        public Palindrome()
        {

        }

        public bool IsPalindrome(string palindrome)
        {
            bool SameBothWays = true;
            string StringToCheck = "";

            palindrome = palindrome.ToLower();
            StringToCheck = RemoveWhiteSpaceAndPunctuation(palindrome);

            for (int i = 0; i < StringToCheck.Length / 2; i++)
            {
                if (StringToCheck[i] != StringToCheck[StringToCheck.Length - i-1])
                {
                    SameBothWays = false;
                }
            }

            return SameBothWays;
        }

        public string RemoveWhiteSpaceAndPunctuation(string pal)
        {
            string StringToCheck = "";
            for (int i = 0; i < pal.Length; i++)
            {
                if (!Char.IsWhiteSpace(pal[i]) || !Char.IsPunctuation(pal[i]))
                {
                    StringToCheck = StringToCheck + pal[i];
                }

            }
            return StringToCheck;
        }
    }
}
