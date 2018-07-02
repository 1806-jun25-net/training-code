using System;
using System.Collections.Generic;
using System.Text;

namespace Palindrome.Library
{
    public class Palindrome
    {
        private readonly List<string> words = new List<string>();

        public bool IsPalindrome()
        {
            
            foreach (var word in words)
            {
                string NoSpaceOrPunc = word.Replace(" ", string.Empty);
                NoSpaceOrPunc = NoSpaceOrPunc.ToLower();

                for (int i = 0; i < word.Length; i++)
                {
                    for (int j = word.Length; j < word.Length; j--)
                    {
                        if (words[i] == words[j])
                        {
                            break;
                        }
                        else
                            return false;
                    }
                }
            }
            return true;
        }
    }
}
