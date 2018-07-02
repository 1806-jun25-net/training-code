using System;
using Xunit;
using Palindrome.Library;


namespace Palindrome.UnitTest
{
    public class UnitTest1
    {

        [Theory]
        [InlineData("racecar", 1)]
        [InlineData("nurses run",1)]
        [InlineData("racecaR",1)]
        [InlineData("1221",1)]
        [InlineData("one two one",0)]
        [InlineData("123abccba123",0)]

        public void IsStringPalimdromeReturningCorrectly(string word, int actual)
        {
            var test = new PalindromeClass();
            int result = test.IsStringPalindrome(word);
            Assert.Equal(actual, result);
        }
    }
}
