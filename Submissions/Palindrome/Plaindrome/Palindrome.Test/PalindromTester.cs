using Plaindrome.Library;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PalindromeTest
{

    public class PalindromTester 
    {        
        [Theory]
        [InlineData("nurses run")]
        [InlineData("racecaR")]
        [InlineData("1221")]
        [InlineData("never odd, or even")]
        public void IsPalindromeReturnsTrue(string palindrome)
        {
            var col = new Palindrome();
            col.newPalindrome = palindrome;
            bool actual = col.IsPalindrome(col.newPalindrome);
            Assert.True(actual);
        }

        [Theory]
        [InlineData("one two one")]
        [InlineData("123abccba123")]
        public void IsPalindromeReturnFalse(string palindrome)
        {
            var col = new Palindrome();
            col.newPalindrome = palindrome;
            bool actual = col.IsPalindrome(col.newPalindrome);
            Assert.False(actual);
        }
    }
}
