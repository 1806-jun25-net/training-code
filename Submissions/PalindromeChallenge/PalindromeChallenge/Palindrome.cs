using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Palindrome
{
    public class Palindrome
    {
        //tests if a string is a palindrome and returns a boolean
        public static bool IsPalindrome(string str)
        {
            str = Regex.Replace(str, @"\p{P}", "");
            str = Regex.Replace(str, @"\s+", "");
            string reverse = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverse = reverse + str.Substring(i, 1);
            }
            if (reverse == str)
                return true;
            else
                return false;
        }

    }
}
