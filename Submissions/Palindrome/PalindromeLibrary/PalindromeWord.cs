using System;

namespace PalindromeLibrary
{
    public class PalindromeWord
    {
        public bool Palindrome(string word)
        {
            
            int maxSize = word.Length;
            bool isPalindrome = false;

            for (int i = 0; i <maxSize; i++)
            {
                if (word[i] != word[maxSize])
                {
                    isPalindrome = true;
                }
                else
                    isPalindrome = false;

            }

            if (isPalindrome == true)
            {
                return true;
            }
            else
                return false;


        }
        
    }
}
