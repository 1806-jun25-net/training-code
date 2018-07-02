using System;
using Xunit;
using Palindrome.Library;

namespace Palindrome.Test
{
    /// <summary>
    /// Tests for the IsPalindrome method of StringFunctions method library.
    /// </summary>
    public class PalindromeTest
    {
        
        /// <summary>
        /// Base test for empty string.
        /// </summary>
        [Fact]
        public void TestPalindromeEmpty()
        {
            Assert.True(StringFunctions.IsPalindrome(""));
        }


        /// <summary>
        /// Tests for palindromes of alphanumeric length 1 or less.
        /// </summary>
        [Fact]
        public void TestPalindromeSizeOne()
        {
            Assert.True(StringFunctions.IsPalindrome(","));
            Assert.True(StringFunctions.IsPalindrome("a"));
            Assert.True(StringFunctions.IsPalindrome("a,! ,"));
            Assert.True(StringFunctions.IsPalindrome("     a"));
            Assert.True(StringFunctions.IsPalindrome("        a,! ,"));
        }

        /// <summary>
        /// Tests for true palindromes of alphanumeric length 2
        /// </summary>
        [Fact]
        public void TestPalindromeSizeTwoTrue()
        {
            Assert.True(StringFunctions.IsPalindrome("aa"));
            Assert.True(StringFunctions.IsPalindrome(" a a"));
            Assert.True(StringFunctions.IsPalindrome("aA"));
            Assert.True(StringFunctions.IsPalindrome("55"));
        }

        /// <summary>
        /// Tests for false palindromes of alphanumeric length 2
        /// </summary>
        [Fact]
        public void TestPalindromeSizeTwoFalse()
        {
            Assert.False(StringFunctions.IsPalindrome("ab"));
            Assert.False(StringFunctions.IsPalindrome(" a b"));
        }

        /// <summary>
        /// Simple check to begin testing
        /// </summary>
        [Fact]
        public void TestPaldindromeSimple()
        {
            Assert.True(StringFunctions.IsPalindrome("racecaR"));
        }
        /// <summary>
        /// Tests for true palindromes, drawn from given strings
        /// </summary>
        /// <param name="s"></param>
        [Theory]
        [InlineData("nurses run")]
        [InlineData("racecaR")]
        [InlineData("1221")]
        [InlineData("never odd, or even.")]
        public void TestPalindromeTrue(string s)
        {
            Assert.True(StringFunctions.IsPalindrome(s));

        }

        /// <summary>
        /// Tests for false palindromes, drawn from given strings
        /// </summary>
        /// <param name="s"></param>
        [Theory]
        [InlineData("these should not be considered palindromes")]
        [InlineData("one two one")]
        [InlineData("123abccba123")]
        public void TestPalindromeFalse(string s)
        {
            Assert.False(StringFunctions.IsPalindrome(s));
        }
    }
}
