using System;
using System.Text.RegularExpressions;

namespace PalindromeLib
{
    public class Palindrome
    {
        string testString;


        public bool isItaPalindrome(string paly)
        {


            //removing special characters so that it will still detect palindromes when
            // spaces or periods are used. and converting to lowercase because that doesn't matter to us either. 
           testString = paly;
            testString = testString.Replace(" ", "");
            testString = testString.Replace(",", "");
            testString = testString.Replace(".", "");
            testString = testString.ToLower();
           //testString = Regex.Replace(testString, @"(\s|-)", "");

            for (int i = 0; i <= ((testString.Length/2) -1); i++)
            {

                if (testString[i] == testString[testString.Length-i-1])
                {
                    continue;
                }
                
                else
                {
                    return false;
                }

            }

            return true;
           

          
        }
    }
}
