using System;
using Palindrome.Library.Palindrome;
using System.Collections.Generic;
using Xunit;

namespace Palindrome.Test
{
    public class TestingPalindrome
    {
        public static IEnumerable<object[]> GetTestData()
        {
            string v1 = "nurses run",
                v2 = "1221",
                v3 = "never odd, or even",
                v4 = "one two one",
                v5 = "123abccba123";
                
            yield return new object[] { v1 };
            yield return new object[] { v2  };
            yield return new object[] { v3 };
            yield return new object[] { v4  };
            yield return new object[] { v5  };

        }
        [Theory]
        [MemberData(nameof(GetTestData))]
        public void TestTheInvertionOfArray(string palindrome)
        {
            var testingInverted = InvertedStirng(palindrome);
        }
        [Theory]
        [MemberData(nameof(GetTestData))]
        public void TestLowerCaseing (string pali)
        {
            var testingLowerCase = LowerCase(pali); 
        }
        [Theory]
        [MemberData(nameof(GetTestData))]
        public void TestNoSpecialCharacters(string pali)
        {
            var testingNoSpace = NoSpecialCharacters(pali); 
        }
        [Theory]
        [MemberData(nameof(GetTestData))]
        public void TesNoSpecialCharacters(string pali)
        {
            var testingNoSpace = NoSpecialCharacters(pali);
        }
        [Theory]
        [MemberData(nameof(GetTestData))]
        public void TestComparingArrays(string pali, string pali)
        {
            var testingNoSpace = ComparingArrays(pali);
        }
       
    }
}
