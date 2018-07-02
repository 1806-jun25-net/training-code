using System;

namespace ClassLibrary1
{
    public class Palindrom
    {
        public static void IsPalindrom()
        {
            string input = null;

            Console.WriteLine("Enter some text. Is it a palindrome?");
            //take user input and set all characters to lowercase
            input = Console.ReadLine();
            input = input.ToLower();

            var sb = new StringBuilder();
            //strip punctuation and whitespace from string
            foreach (char c in input)
            {
                if (!char.IsPunctuation(c))
                    sb.Append(c);
            }
            //apply new string to input variable
            input = sb.ToString();

            //remove white space
            input = input.Replace(" ", String.Empty);

            //palindrome comparison

            var reversed = new string(input.Reverse().ToArray());
            bool palindrom = input == reversed;


            //inform user
            if (palindrom == true)
            {
                Console.WriteLine("That is a palindrom!");
            }
            else
            {
                Console.WriteLine("Sorry, that is not a palindrom");
            }

            Console.ReadLine();


        }
    }
}
