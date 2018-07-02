using System;
using Xunit;
using PalindromeLib;

namespace Testing
{
    public class UnitTest1
    {
        [Fact]
        public void isItaPalindromeShouldReturnTrueifitisaPalindrome()
        {
            Palindrome Paltest = new Palindrome();
            Assert.True(Paltest.isItaPalindrome("nurses run"));
        }

        [Fact]
        public void isItaPalindromeShouldReturnFalseifitisnotaPalindrome()
        {
            Palindrome Paltest = new Palindrome();
            Assert.False(Paltest.isItaPalindrome("one two one"));


        }
    }
}
