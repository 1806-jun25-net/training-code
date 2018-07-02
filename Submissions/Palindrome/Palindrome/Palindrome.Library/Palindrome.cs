using System;
using System.Collections.Generic;
using System.Text;

namespace Palindrome.Library
{
    public class Palindrome
    {
        private readonly string word = "";

        public Palindrome(string Word)
        {
            word = Word;
        }
        public bool IsPalindrome()
        {
            string NoSpaceOrPunc = word.Replace(" ", string.Empty);
            NoSpaceOrPunc = NoSpaceOrPunc.ToLower();

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = word.Length; j < word.Length; j--)
                {
                    if (word[i] == word[j])
                    {
                        break;
                    }
                    else
                        return false;
                }
            }
            return true;
        }
    }
}
