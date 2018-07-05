using System;
using Xunit;
using CodingChallenge2.library;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldSaysIfPalindrome()
        {
            // Arrange
            var ana = new Verification();

            // Act
            bool t = ana.CheckStringArray("ANA");
            bool expected = true;
            // Assert
            Assert.Equal(expected, t);
        }

        [Fact]
        public void ShouldSaysINOTPalindrome()
        {
            // Arrange
            var ana = new Verification();

            // Act
            bool t = ana.CheckStringArray("AN.4[");
            bool expected = true;
            // Assert
            Assert.Equal(expected, t);
        }


        [Theory]
        [InlineData("ANA", new string[] {"ANA"})]
        //[InlineData(null, new string[] { })]
        //[InlineData("asdas", new string[] { "12", "1234", "asdas" })]
        public void bigtest(string expected, string[] word2)
        {
            // Arrange
            var ana = new Verification();

            // Act
            bool t = ana.CheckStringArray(word2);
            // Assert
            Assert.Equal(expected, t);
        }
    }
}
