using Palindrome.Library;
using System;
using Xunit;

namespace Palindrome.Test
{
    public class UnitTest1
    {
        [Fact]
        public void PalindromeTest1()
        {
            CheckIfPalindrome check = new CheckIfPalindrome();
            string pal1 = "nurses run";

            string input = pal1;

            string deleted = CheckIfPalindrome.DeleteNonChars(input);
            char[] reverse = CheckIfPalindrome.Reverse(deleted);
            string output = CheckIfPalindrome.Combine(reverse);
            Assert.True(CheckIfPalindrome.Test(input, output));

        }

        [Fact]
        public void PalindromeTest2()
        {
            CheckIfPalindrome check = new CheckIfPalindrome();
            string pal2 = "racecaR";

            string input = pal2;

            string deleted = CheckIfPalindrome.DeleteNonChars(input);
            char[] reverse = CheckIfPalindrome.Reverse(deleted);
            string output = CheckIfPalindrome.Combine(reverse);
            Assert.True(CheckIfPalindrome.Test(input, output));

        }

        [Fact]
        public void PalindromeTest3()
        {
            CheckIfPalindrome check = new CheckIfPalindrome();
            string pal3 = "1221";

            string input = pal3;

            string deleted = CheckIfPalindrome.DeleteNonChars(input);
            char[] reverse = CheckIfPalindrome.Reverse(deleted);
            string output = CheckIfPalindrome.Combine(reverse);
            Assert.True(CheckIfPalindrome.Test(input, output));

        }

        [Fact]
        public void PalindromeTest4()
        {
            CheckIfPalindrome check = new CheckIfPalindrome();
            string pal4 = "never odd, or even";

            string input = pal4;

            char[] reverse = CheckIfPalindrome.Reverse(input);
            string output = CheckIfPalindrome.Combine(reverse);
            Assert.True(CheckIfPalindrome.Test(input, output));

        }
    }
}
