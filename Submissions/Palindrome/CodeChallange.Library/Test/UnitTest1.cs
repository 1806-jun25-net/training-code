using System;
using System.Linq;
using Xunit;

namespace Test
{
    public class UnitTest1
    {



        [Theory]
        [InlineData("1221")]
        [InlineData("1222")]
        [InlineData("bleh")]
        [InlineData("Something")]
        [InlineData("nun")]
        public static bool IsPalindromeTest(string value)
        {
            //To determine the minimun and maximun length of the string example "1234" will have a lenght of 3 max and 0 min.
            int min = 0;
            int max = value.Length - 1;

            //Then we compare 
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = value[min];
                char b = value[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }

                //We increment the min value to go up one char and we decrement th lenght to get closer to the end.
                min++;
                max--;
            }

        }


        [Theory]
        [InlineData("1221")]
        [InlineData("1222")]
        [InlineData("bleh")]
        [InlineData("Something")]
        [InlineData("nun")]
        public bool Reverse(string value)
        {
            //This uses LINQ expression. I saw there was a method reverse and i searched how to apply it lets see if works.
            return value.SequenceEqual(value.Reverse());



        }

        [Fact]
        public void PrintToScreen()
        {
            //Initialize an array with some strings that where given to it.

            string[] array = { "nurses run", "racecaR", "1221", "never odd, or even.", "one two one", "123abccba123" };

            //We loop through the array to print out the value using the method IsPalindrome to see if they read the same backwards.
            foreach (string value in array)
            {
                //{0 is value} {1 is the return value from the method true or false.}
                Console.WriteLine("{0} = {1}", value, IsPalindromeTest(value));

            }



            foreach (string value in array)
            {
                //{0 is value} {1 is the return value from the method true or false.}
                Console.WriteLine("{0} = {1}", value, Reverse(value));

            }

        }

    }
}
