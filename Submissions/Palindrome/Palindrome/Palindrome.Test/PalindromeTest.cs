using System;
using Xunit;
using Palindrome.Library;

namespace Palindrome.Test
{
    public class PalindromeTest
    {
        // should return true
        [Fact]
        public void CheckPalindromeShouldReturnTrueForNursesRun()
        {
            string InputWord = "nurses run";
            OPalindrome MyPalidrome = new OPalindrome(InputWord);
            Assert.True(MyPalidrome.IsPalindrome);
        }

        [Fact]
        public void CheckPalindromeShouldReturnTrueForRacecar()
        {
            string InputWord = "racecaR";
            OPalindrome MyPalidrome = new OPalindrome(InputWord);
            Assert.True(MyPalidrome.IsPalindrome);
        }

        [Fact]
        public void CheckPalindromeShouldReturnTrueFor1221()
        {
            string InputWord = "1221";
            OPalindrome MyPalidrome = new OPalindrome(InputWord);
            Assert.True(MyPalidrome.IsPalindrome);
        }

        [Fact]
        public void CheckPalindromeShouldReturnTrueForNeverOddOrEven()
        {
            string InputWord = "never odd, or even.";
            OPalindrome MyPalidrome = new OPalindrome(InputWord);
            Assert.True(MyPalidrome.IsPalindrome);
        }


        // should return false
        [Fact]
        public void CheckPalindromeShouldReturnFalseForOneTwoOne()
        {
            string InputWord = "one two one";
            OPalindrome MyPalidrome = new OPalindrome(InputWord);
            Assert.False(MyPalidrome.IsPalindrome);
        }

        [Fact]
        public void CheckPalindromeShouldReturnFalseFor123abccba123()
        {
            string InputWord = "123abccba123";
            OPalindrome MyPalidrome = new OPalindrome(InputWord);
            Assert.False(MyPalidrome.IsPalindrome);
        }
    }
}
