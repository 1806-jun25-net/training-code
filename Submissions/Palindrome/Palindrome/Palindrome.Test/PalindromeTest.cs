using Palindrome.Library;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Palindrome.Testing
{
    public class PalindromeTest
    {
        [Fact]
        public void IsPalindromShouldReturnTrue()
        {
            bool expected = true;
            string str = "nursesrun";

            bool result = Palindrome.Library.Palindrome.IsPalindrome(str);

            Assert.Equal(expected, result);
        }
    }
}
