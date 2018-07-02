using System;
using System.Collections.Generic;
using System.Text;

namespace Palindrome.Library
{
    public class CheckIfPalindrome
    {
        public static string DeleteNonChars(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                
            }
            string lower = input.ToLower();
            return lower;
        }

        public static char[] Reverse(string input)
        {
            char[] inputArray = input.ToCharArray();
            char[] inputReverse = new char[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == ' ')
                {
                    i++;
                }
                inputReverse[i] = inputArray[inputArray.Length - 1 - i];
            }

            return inputReverse;
        }

        public static string Combine(char[] input)
        {
            string output = new string(input);
            return output;
        }

        public static bool Test(string first, string second)
        {
            bool check = false;

            if (first == second)
            {
                check = true;
            }
            return check;
        }
    }
}
