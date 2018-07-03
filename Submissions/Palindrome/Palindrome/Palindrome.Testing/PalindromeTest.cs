using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Palindrome.Library;

namespace Palindrome.Test
{
    public class PalindromeTest
    {
        [Theory]
        [InlineData("one two one")]
        [InlineData("123abccba123")]
        public void WordIsNotPalindrome(string word)
        {
           var p = new OPalindrome();

            Assert.False(p.IsPalindrome(word));
        }


        [Theory]
        [InlineData("nurses run")]
        [InlineData("racecaR")]
        [InlineData("1221")]
        [InlineData("never odd, or even")]
        public void WordIsPalindrome(string word)
        {
            var p = new OPalindrome();

            Assert.True(p.IsPalindrome(word));
        }
    }
}
