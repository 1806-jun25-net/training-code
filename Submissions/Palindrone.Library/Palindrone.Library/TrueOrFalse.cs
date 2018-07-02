using System;

/**
 * two projects, a library project and a unit test project.
library should have a class that can tell me whether a string is a palindrome or not.
all the behavior of the class should be unit tested.
a palindrome reads the same forwards and backwards.
these should be considered palindromes:
    "nurses run"
    "racecaR"
    "1221"
    "never odd, or even."
these should not be considered palindromes:
    "one two one"
    "123abccba123"
 */

namespace Palindrone.Library
{
    public class TrueOrFalse
    {
        public bool Palindrone(string s)
        {
            var line = new System.Text.StringBuilder();
            //gets rid of punctuation
            foreach (char c in s)
            {
                if (!char.IsPunctuation(c))
                    line.Append(c);
            }
            //converts the chars back to a string
            s = line.ToString();
            //gets rid of spaces
            s = s.Replace(" ", "");
        
            int beginning = 0;
            int end = s.Length - 1;
            //while true run through this code
            while(true)
            {
                if( beginning > end)
                {
                    return true;
                }
                char a = s[beginning];
                char b = s[end];
                //if two letters don't match return false 
                if(char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                beginning++;
                end--;
            }
        }
    }
}
