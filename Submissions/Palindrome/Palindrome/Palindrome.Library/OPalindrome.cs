using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Palindrome.Library
{
    public class OPalindrome
    {
        // fields
        public string InputWord { get; set; }
        public string ProcessedWord { get; set; }
        public IEnumerable<char> LetterList = new List<char>();
        public bool IsPalindrome { get; set; }

        // constructor
        public OPalindrome(string word)
        {
            if (word != null)
            {
                InputWord = word;
                ProcessedWord = ProcessWord(InputWord);
                LetterList = BreakWordIntoCharList(ProcessedWord);
                var letterList = (List<char>)LetterList; // downcast from IEnumerable to List so we can use CheckPalindrome()
                IsPalindrome = CheckPalindrome(letterList);
            }
        }

        // methods
        public string ProcessWord(string inputWord) // converts palindrome string in question to format coinciding with assignment requirements (not case sensitive, ignore spaces and punctuation)
        {            
            string currentWord = inputWord;
            string processedWord;
            
            // remove spaces and commas
            currentWord = currentWord.Replace(" ", "");
            currentWord = currentWord.Replace(",", "");
            currentWord = currentWord.ToUpper(); // converts string to upper case because the check is not case sensitive

            processedWord = currentWord;

            return processedWord;
        }

        public List<char> BreakWordIntoCharList(string word) // converts string into List<char>
        {
            var letterList = (List<char>)LetterList; // downcast from IEnumerable to List so we can use .AddRange()
            letterList.AddRange(word); //takes each char of the string word and adds them to List<char> letterList

            return letterList;
        }

        public bool CheckPalindrome(List<char> letterList)
        {
            int listLength = 0;
            listLength = letterList.Count();

            bool check = false;
            for (int i = 0; i < listLength / 2; i++)
            {
                var a = letterList[i];
                var b = letterList[listLength - 1];

                if (a == b)
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
            }

            return check;
        }
    }
}
