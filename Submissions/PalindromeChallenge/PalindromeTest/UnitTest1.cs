using System;
using Xunit;

namespace PalindromeTest
{
    public class PalindromeTest
    {
        [Fact]
        public void RaceCarTest()
        {
            var racecar = "Race Car!";

            Assert.True(IsPalindrome(racecar));
        }
        [Fact]
        public void Abc123Test()
        {
            var str = "123abccba123";

            Assert.False(IsPalindrome(str));
        }
        [Fact]
        public void OneTwoOneTest()
        {
            var str = "one two one";
            Assert.False(IsPalindrome(str));
        }
        [Fact]
        public void NeverOddOrEvenTest()
        {
            var str = "never odd, or even.";
            Assert.True(IsPalindrome(str));
        }
        [Fact]
        public void NursesRunTest()
        {
            var str = "nurses run";

            Assert.True(IsPalindrome(str));
        }
    }
}
