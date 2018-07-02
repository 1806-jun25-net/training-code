using Palindrone.Library;
using System;
using Xunit;

namespace Palindrone.Test
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldReturnTrueAsAPalindroneWithSpace()
        {
            var palindrone = new TrueOrFalse();
            palindrone.Palindrone("race car");
            Assert.True(palindrone.Palindrone("race car"));
        }

        [Fact]
        public void ShouldReturnTrueAsAPalindroneWithCapital()
        {
            var palindrone = new TrueOrFalse();
            palindrone.Palindrone("racecaR");
            Assert.True(palindrone.Palindrone("race caR"));
        }

        [Fact]
        public void ShouldReturnFalseAsAPalindrone()
        {
            var palindrone = new TrueOrFalse();
            palindrone.Palindrone("123");
            Assert.False(palindrone.Palindrone("123"));
        }
    }
}
