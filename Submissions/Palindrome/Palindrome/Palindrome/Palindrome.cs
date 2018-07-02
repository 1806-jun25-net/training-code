using System;

namespace Palindrome.Library
{
    public class PalindromeClass
    {
        public int IsStringPalindrome(string word)
        {

            word = word.ToLower();
            word = word.Replace(" ", String.Empty); //removes whitespace
            int StringLength = word.Length - 1;
            /*  if (StringLength % 2 == 1)
              {
                  return 0;
              }*/
            for (int x = 0; x < (StringLength+1) / 2; x++)
            {
                if (word[x] != word[StringLength - x])
                {
                    return 0;
                }

            }
            return 1;

        }

    }

}