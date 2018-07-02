using System;
using System.Collections.Generic;
using System.Text;

namespace Palindrome.Library
{
    public class Palindrome
    {
        
        public static bool IsPalindrome(string str)
        {
            str.ToLower();
            str.Trim();
                        
            int count = 0;
            for (int i = (str.Length / 2); i >= 0; i--)
            {
                if (str[count] == str[i]) { }
                else { return false; }
                count++;
            }
            return true;
        }
    }
}
