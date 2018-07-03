using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Palindrome.Library
{
    public class Palindrome2
    {
        public bool IsPalindrome(string value)
        {
            int minSize = 0;
            int maxSize = value.Length - 1 ;

            while(true)
            {
                if (minSize > maxSize)
                {
                    return true;
                }

                char min = value[minSize];
                char max = value[maxSize];
                
                // checks if the letters are differents minSize increasing and maxSize decreasing
                if(char.ToUpper(min) != char.ToUpper(max))
                {
                    return false;
                }

                minSize++;
                maxSize--;
            }

        }
    }
}
