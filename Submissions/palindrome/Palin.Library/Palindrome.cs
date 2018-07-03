using System;
using System.Collections.Generic;
using System.Text;

namespace Palin.Library
{
    public class Palindrome
    {
        public bool isPalindrome(string s)
        {
            //First remove all punctuations
            string str = "";
            foreach (char c in s)
            {
                if (!Char.IsPunctuation(c))
                {
                    str += c;
                }
            }
            //Then remove all whitespaces
            str = str.Replace(" ", string.Empty);

            //Finally, convert the string to lowercase
            str = str.ToLower();


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