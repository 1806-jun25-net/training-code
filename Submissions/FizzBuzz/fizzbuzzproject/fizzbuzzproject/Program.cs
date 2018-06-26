using System;

namespace fizzbuzzproject
{
    class Program
    {
        //solution to coding challenge
        static void FizzBuzz()
        {
            int totalFizz = 0;
            int totalBuzz = 0;
            int totalFizzbuzz = 0;
            string[] numberfizzbuzz = new string[1000];

            for(int i = 0; i < numberfizzbuzz.Length; i++)
            {
                if ((i+1) % 3 == 0 && (i+1) % 5 == 0)
                {
                    numberfizzbuzz[i] = "Fizzbuzz";
                    totalFizzbuzz++;
                }

                else if ((i+1) % 3 == 0)
                {
                    numberfizzbuzz[i] = "Fizz";
                    totalFizz++;
                }

                else if ((i+1) % 5 ==0)
                {
                    numberfizzbuzz[i] = "Buzz";
                    totalBuzz++;
                }

                else
                {
                    int position = i + 1;
                    numberfizzbuzz[i] = position.ToString();
                }
            }

            foreach(var item in numberfizzbuzz)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Total number of Fizzes is: {totalFizz}");
            Console.WriteLine($"Total number of Buzzes is: {totalBuzz}");
            Console.WriteLine($"Total number of Fizzbuzzes is: {totalFizzbuzz}");
        }

        //main used to call solution method
        static void Main(string[] args)
        {
            FizzBuzz();
        }
    }
}
