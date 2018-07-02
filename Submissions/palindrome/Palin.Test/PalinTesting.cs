using Palin.Library;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Palin.Test
{
    public class PalinTesting
    {
        [Theory]
        [InlineData(true, "nurses run")]
        [InlineData(true, "racecaR")]
        [InlineData(true, "1221")]
        [InlineData(true, "never odd, or even.")]
        public void basicTestsShouldReturnTrue(bool b, string s)
        {
            //Arrange
            bool expected = true;
            bool actual = b;

            //Act
            Palindrome p = new Palindrome();
            actual = p.isPalindrome(s);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(false, "one, two, one")]
        [InlineData(false, "123abccba123")]
        public void basicTestsShouldReturnFalse(bool b, string s)
        {
            //Arrange
            bool expected = true;
            bool actual = b;

            //Act
            Palindrome p = new Palindrome();
            actual = p.isPalindrome(s);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
