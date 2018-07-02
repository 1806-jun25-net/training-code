using System;
using System.Collections.Generic;
using System.Text;

namespace Palindrome.Library
{
    public class Palindrome
    {
        public bool isPalindrome(string s)
        {
            //First remove all punctuations
            string str = "";
            foreach (char c in s)
            {
                if (!char.IsPunctuation(c))
                {
                    str += c;
                }
            }
            //Then remove all whitespaces
            str.Replace(" ", string.Empty);

            //Finally, convert the string to lowercase
            str.ToLower();


            //Now rewrite the string backwards and check
            string reverseStr = Reverse(str);

            return str == reverseStr;
        }

        public string Reverse(string s)
        {

            string rev = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                rev += s[i];
            }
            return rev;
        }
    }
}
