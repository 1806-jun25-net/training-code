﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Plaindrome.Library
{
    public class Palindrome
    {
        public string PossiblePalindrome { get; set; }

        public Palindrome(string pal)
        {
            PossiblePalindrome = pal;
        }

        public bool IsPalindrome(string palindrome)
        {
            bool SameBothWays = true;
            string StringToCheck = "";

            palindrome = palindrome.ToLower();
            StringToCheck = RemoveWhiteSpaceAndPunctuation(palindrome);

            for (int i = 0; i < StringToCheck.Length / 2; i++)
            {
                if (StringToCheck[i] != StringToCheck[StringToCheck.Length - i])
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
