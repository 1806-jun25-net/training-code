using System;
using Xunit;
using Palindrome.Library;

namespace Palindrome.Test
{
    public class PalindromeTest
    {
        [Fact]
        public void CheckPalindromeShouldReturnFalseFor123abccba123()
        {
            string InputWord = "123abccba123";
            OPalindrome MyPalidrome = new OPalindrome(InputWord);
            Assert.False(MyPalidrome.IsPalindrome);
        }

        [Fact]
        public void CheckPalindromeShouldReturnTrueForNeverOddOrEven()
        {
            string InputWord = "never odd, or even.";
            OPalindrome MyPalidrome = new OPalindrome(InputWord);
            Assert.True(MyPalidrome.IsPalindrome);
        }
    }
}
