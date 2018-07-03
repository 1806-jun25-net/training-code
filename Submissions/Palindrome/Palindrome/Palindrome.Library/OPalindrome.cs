using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Palindrome.Library
{
    public class OPalindrome
    {
        public bool IsPalindrome(string word)
        {
            string NoSpaceOrPunc = word.Replace(" ", string.Empty);
            NoSpaceOrPunc = Regex.Replace(NoSpaceOrPunc, @"\p{P}", "");
            NoSpaceOrPunc = NoSpaceOrPunc.ToLower();

            Char[] arr = NoSpaceOrPunc.ToCharArray();
            Array.Reverse(arr);
            string reversed = new string(arr);
            if (NoSpaceOrPunc == reversed)
            {
                return true;
            }
            else return false;
        //    int start = 0;
        //    int end = word.Length - 1;
        //    bool done = true;
        //    while(done)
        //    {
        //        if (word[start] != word[end])
        //        {
        //            return false;
        //        }
        //        else if (start < end)
        //        {
        //            done = false;
        //        }
        //        else
        //        {
        //            start++;
        //            end--;
        //        }
        //    }
        //return true;
        }
    }
}
