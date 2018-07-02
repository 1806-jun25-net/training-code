using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Palindrome.Test
{

    public class PalindromTest 
    {        
        [Theory]
        [InlineData(true, "nurses run")]
        [InlineData(true, "racecaR")]
        [InlineData(true, "1221")]
        [InlineData(true, "never odd, or even")]
        public void IsPalindromeReturnsTrue(bool expected, string palindrome)
        {
            var col = new Palindrome()
        }
    }
}
