using Palindrome.Library;
using System;
using Xunit;

namespace PalindromeTest
{
    public class PalindromeTesting
    {
        [Fact]
        public void ShouldSayIsPalindrome()
        {
            //Arrange
            var x = new Palindrome2();

            //Act
            bool actual = x.IsPalindrome("Ana");

            bool expected = true;
            //Assert
            Assert.Equal(expected, actual);


        }

        [Theory]
        [InlineData(true, "Ana" )]
        [InlineData(false, "Fish")]
        [InlineData(true, "Racecar" )]
        public void IsPalindromeTests(bool expected, string value)
        {
            //Arrange
            var x = new Palindrome2();

            //Act
            bool actual = x.IsPalindrome(value);
            
            //Assert
            Assert.Equal(expected, actual);


        }
    }
}
