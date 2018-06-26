using System;

namespace FizzBuzz_WK
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[1000];

            //writes numbers 1 through 1000 to array numbers
            for (int a = 0; a < numbers.Length; a++)
            {
                numbers[a] = a + 1;
            }

            for (int b = 0; b < numbers.Length; b++)
            {
                //writes FizzBuzz if divisible by 3 and 5
                if (numbers[b] % 3 == 0 && numbers[b] % 5 == 0)
                    Console.WriteLine("FizzBuzz");

                //writes Buzz if divisible by 5 and not 3
                else if (numbers[b] % 3 != 0 && numbers[b] % 5 == 0)
                    Console.WriteLine("Buzz");

                //writes Fizz if divisibly by 3 and not 5
                else if (numbers[b] % 3 == 0 && numbers[b] % 5 != 0)
                    Console.WriteLine("Fizz");

                //writes the number of divisible by neither 3 nor 5
                else
                    Console.WriteLine(numbers[b]);
            }


            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Count of FizzBuzz: " + CountFizzBuzz(numbers));

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Count of Buzz: " + CountBuzz(numbers));

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Count of Fizz: " + CountFizz(numbers));
        }

        //methods use same if statements to check as in Main method

        //counts number of FizzBuzzes by incrementing variable cfizzbuzz
        static int CountFizzBuzz(int[] numbers)
        {
            int cfizzbuzz = 0;
            for (int a = 0; a < numbers.Length; a++)
            {
                if (numbers[a] % 3 == 0 && numbers[a] % 5 == 0)
                    cfizzbuzz++;
            }
            return cfizzbuzz;
        }

        //counts number of Fizzes by incrementing variable cfizz
        static int CountBuzz(int[] numbers)
        {
            int cbuzz = 0;
            for (int a = 0; a < numbers.Length; a++)
            {
                if (numbers[a] % 3 != 0 && numbers[a] % 5 == 0)
                    cbuzz++;
            }
            return cbuzz;
        }

        //counts number of Buzzes by incrementing variable cbuzz
        static int CountFizz(int[] numbers)
        {
            int cfizz = 0;
            for (int a = 0; a < numbers.Length; a++)
            {
                if (numbers[a] % 3 == 0 && numbers[a] % 5 != 0)
                    cfizz++;
            }
            return cfizz;
        }
    }
}