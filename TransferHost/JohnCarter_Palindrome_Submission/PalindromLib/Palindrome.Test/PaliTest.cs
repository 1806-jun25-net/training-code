using Palindrome.Library;
using System;
using Xunit;

namespace Palindrome.Test
{
    public class PaliTest
    {
        [Fact]
        public void PaliCheckerShouldntReturnFailedVarName()
        {
            //ASSERT
            var PaliCheckerTest = new PaliPali();
            string actual = PaliCheckerTest.PaliChecker("Racecar");
            string expected = "palindrome";
            //Assert.True(actual != expected);
            //Assert.True(actual == expected);
            
            //Use this one for more verbose explanations of why test went wrong
            Assert.Equal(expected, actual);
        }
    }
}
