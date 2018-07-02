using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge2.library
{
    public class Verification
    {

        public bool CheckStringArray(string word)
        {
            
            int LettersInvertWord = word.Length - 1;
            int LettersNormalWord = 0;

            while (LettersNormalWord < LettersInvertWord)
            {
                if(word[LettersInvertWord] == word[LettersNormalWord] && LettersNormalWord < 0 )
                {

                    return true;
                }

                LettersInvertWord++;
                LettersNormalWord--;
            }

            return false;
        }
    }
}
