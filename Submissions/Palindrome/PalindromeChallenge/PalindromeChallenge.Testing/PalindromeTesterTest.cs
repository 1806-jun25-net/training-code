using PalindromeChallenge.Library;
using System;
using Xunit;

namespace PalindromeChallenge.Testing
{
    public class PalindromeTesterTest
    {
        //Overall testing of TestForPalindrome method
        //If TestForPalindrome passes all tests, it should be displaying required functionality

        [Fact]
        public void TestForPalindromeHandlesNullString()
        {
            //Arrange
            string s = null;
            //Act
            bool result = PalindromeTester.TestForPalindrome(s);

            //Assert
            Assert.True(!result);
        }

        [Fact]
        public void TestForPalindromeReturnsTrueForEmptyString()
        {
            //Arrange
            string s = "";
            //Act
            bool result = PalindromeTester.TestForPalindrome(s);

            //Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData("z")]
        [InlineData(" ")]
        public void TestForPalindromeReturnsTrueForStringLengthOne(string s)
        {
            //Arrange
            //Act
            bool result = PalindromeTester.TestForPalindrome(s);

            //Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData("hefty")]
        [InlineData("daddy")]
        [InlineData("god not dog")]
        public void TestForPalindromeReturnsFalseForNonPalindromesOfSameCase(string s)
        {
            //Arrange
            //Act
            bool result = PalindromeTester.TestForPalindrome(s);

            //Assert
            Assert.True(!result);
        }

        [Theory]
        [InlineData("racecar")]
        [InlineData("dad")]
        [InlineData("god dog")]
        public void TestForPalindromeReturnsTrueForPalindromesOfSameCase(string s)
        {
            //Arrange
            //Act
            bool result = PalindromeTester.TestForPalindrome(s);

            //Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData("rAcecar")]
        [InlineData("Dad")]
        [InlineData("God dOg")]
        public void TestForPalindromeReturnsTrueForPalindromesDespiteCasing(string s)
        {
            //Arrange
            //Act
            bool result = PalindromeTester.TestForPalindrome(s);

            //Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData("rAce.car")]
        [InlineData("Dad...")]
        [InlineData("G!oddOg!")]
        public void TestForPalindromeReturnsTrueForPalindromesDespitePunctuation(string s)
        {
            //Arrange
            //Act
            bool result = PalindromeTester.TestForPalindrome(s);

            //Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData(" rA  c ecar")]
        [InlineData("D a  d    ")]
        [InlineData("  Go     d d O  g ")]
        public void TestForPalindromeReturnsTrueForPalindromesDespiteSpacing(string s)
        {
            //Arrange
            //Act
            bool result = PalindromeTester.TestForPalindrome(s);

            //Assert
            Assert.True(result);
        }

    }
}
