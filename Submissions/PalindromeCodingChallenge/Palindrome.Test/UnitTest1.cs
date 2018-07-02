using System;
using Xunit;
using Palindrom;

namespace Palindrom.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("nurses run", true)]
        [InlineData("racecaR", true)]
        [InlineData("1221", true)]
        [InlineData("never odd, or even.", true)]
        [InlineData("one two one", false)]
        [InlineData("123abccba123", false)]

        public void PalindromInputIsString(string input, bool expected)
        {
            //arrange
            var palindrom = new Palindrome();
            //act
            bool result = palindrom.IsPalindrom(input);
            //assert
            Assert.Equal(result,expected);
        }
    }
}
