using System;

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
            char[] testingInverted = InvertedStirng(palindrome);
        }
        [Theory]
        [MemberData(nameof(GetTestData))]
        public void TestLowerCaseing (string pali)
        {
            string testingLowerCase = LowerCase(pali); 
        }
        [Theory]
        [MemberData(nameof(GetTestData))]
        public void TestNoSpecialCharacters(string pali)
        {
            char[] testingNoSpace = NoSpecialCharacters(pali); 
        }
        [Theory]
        [MemberData(nameof(GetTestData))]
        public void TesNoSpecialCharacters(string pali)
        {
            char[] testingNoSpace = NoSpecialCharacters(pali);
        }
        [Theory]
        [MemberData(nameof(GetTestData))]
        public void TestComparingArrays(string pali, string pali2)
        {
             bool comparing = ComparingArrays(pali, pali2 );
        }
        public char[] InvertedStirng(string Str)
        {

            char[] charArr = Str.ToCharArray();
            
            return charArr;
        }
        public string LowerCase(string Str)
        {
            string Lowercase = Str.ToLower();
            
            return Lowercase;
        }
        public char[] NoEmptySpaces(string Str)
        {
            char[] charArr = Str.ToCharArray();
            return charArr;
        }
        public char[] NoSpecialCharacters(string Str)
        {
            char[] charArr = Str.ToCharArray();
            return charArr;
        }
        public bool ComparingArrays(string NonInverted, string inverted)
        {
            char[] charInverted = inverted.ToCharArray();
            char[] charNonInverted = NonInverted.ToCharArray();
            bool Equal = false;
            foreach (var item in charInverted)
            {
                foreach (var item2 in charNonInverted)
                {
                    if (charInverted[item] == charNonInverted[item])
                    {
                        Equal = true;
                    }
                }
            }

            return Equal;
        }
    }
}
