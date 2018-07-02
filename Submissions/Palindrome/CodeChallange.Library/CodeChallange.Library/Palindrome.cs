using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChallange.Library
{
    public class Palindrome
    {

        public void PrintToScreen()
        {
            //Initialize an array with some strings that where given to it.

            string[] array = { "nurses run", "racecaR", "1221", "never odd, or even.", "one two one", "123abccba123" };

            //We loop through the array to print out the value using the method IsPalindrome to see if they read the same backwards.
            foreach (string value in array)
            {
                //{0 is value} {1 is the return value from the method true or false.}
                Console.WriteLine("{0} = {1}", value, IsPalindrome(value));

            }


        }

        public static bool IsPalindrome(string word)
        {
            //To determine the minimun and maximun length of the string example "1234" will have a lenght of 3 max and 0 min.
            int minL = 0;
            int maxL = word.Length - 1;
            //Then we compare while true then we do a loop since it needs to run atleast once we can compare inside the values.
            //If min length is greater than max lenght then is true it means is a Palindrome word witch means it can be read the same backwards.
            //If is not greater than and not the same letter then is false
            while (true)
            {

                if (minL > maxL)
                {
                    return true;
                }
                char a = word[minL];//Determine what char you are in at the current moment to be able to compare them.
                char b = word[maxL];//Determine what char you are in at the current moment to be able to compare them.
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                //We increment the min value to go up one char and we decrement th lenght to get closer to the end.
                minL++;
                maxL--;

            }

        }


        public bool Reverse(string value)
        {
            //This uses LINQ expression. I saw there was a method reverse and i searched how to apply it lets see if works.
            //this reverse method with LINQ im sure it does not works im gonna leave it here as referene cause i can probably give it some use on another project.
            return value.SequenceEqual(value.Reverse());

        }

        public bool IsPalindromeEasyWay(string word)
        {
            string reversedString = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedString += word[i];//We reverse the word
            }
            return word == reversedString;// in here we compare the normal word and the backwards word and return True if word is a Palindorme and if not it returns False.
        }

    }
}
