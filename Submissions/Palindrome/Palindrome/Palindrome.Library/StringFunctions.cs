using System;

namespace Palindrome.Library
{
    public static class StringFunctions
    {
        /// <summary>
        /// String of allowed characters (characters needed for palindrome)
        /// </summary>
        public static string LowerAlphaNum { get;} = 
            "abcdefghijklmnopqrstuvwxyz1234567890";

        /// <summary>
        /// True iff the string is a Palindrome (spelled the same forward/back).
        /// Palindrome check applies only to alphanumber characters.
        /// Other characters are ignored. Alphabet case is ignored.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsPalindrome(String str)
        {
            //move to lowercase, as 'R' and 'r' are listed as identical
            string s = str.ToLower();
            int i = 0, j=s.Length-1;
            while (i <= j)
            {
                //if 1 character remains, no matter the character, we have a palindrome
                if (i == j)
                    return true;
                //check if [i] is an allowed character
                if(LowerAlphaNum.Contains(s[i]))
                {
                    if (LowerAlphaNum.Contains(s[j]))
                    {
                        //allowed characters in both position, check for equality
                        if (s[i] == s[j])
                        {
                            i++; j--;
                            continue;
                        }
                        else //implies two non-equal but allowed characters were found
                            return false;
                    }
                    else
                    {
                        //unallowed character in [j], must move past
                        j--;
                        continue;
                    }
                }
                else
                {
                    //unallowed character at i, moving forward
                    i++;
                    continue;
                }

            }
            //True by default (i.e empty string, or only pairs of allowed characters were found)
            return true;
        }

    }
}
