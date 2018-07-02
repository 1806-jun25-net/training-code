using System;

namespace Palindrome
{
    public class Palindrome
    {
        public char[] InvertedStirng(string Str)
        {
            char[] charArr = Str.ToCharArray();
            return charArr;
        }
        public char[] LowerCase(string Str)
        {
            char[] charArr = Str.ToCharArray();
            return charArr;
        }
        public char[] NoEmptySpaces (string Str)
        {
            char[] charArr = Str.ToCharArray();
            return charArr;
        }
        public char[] NoSpecialCharacters (string Str)
        {
            char[] charArr = Str.ToCharArray();
            return charArr;
        }
        public bool ComparingArrays (string NonInverted, string inverted)
        {
            char[] charInverted = inverted.ToCharArray();
            char[] charNonInverted = NonInverted.ToCharArray();
            bool Equal = false;
            foreach (var item in charInverted)
            {
                foreach(var item2 in charNonInverted)
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
