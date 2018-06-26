using System;

namespace FizzBuz.Console
{
    class Program
    {
        static void FizzBuzz(int[] numList)
        {
            //counting variable to count the number of times Fizz,Buzz,&FizzBuzz are printed
            //[0] = Fizz, [1] = Buzz, [2] = FizzBuzz
            int[] counter = new int[3];

            foreach (int number in numList)
            {
                if ((number % 3 == 0) && (number % 5 != 0))
                {
                    System.Console.WriteLine("Fizz\n");
                    counter[0]++;
                }
                else if ((number % 5 == 0) && (number % 3 != 0))
                {
                    System.Console.WriteLine("Buzz\n");
                    counter[1]++;
                }
                else if ((number % 3 == 0) && (number % 5 == 0))
                {
                    System.Console.WriteLine("FizzBuzz\n");
                    counter[2]++;
                }
                else
                {
                    System.Console.WriteLine(number+"\n");
                }
            } //end foreach

            //Print the number of times the Console printed Fizz, Buzz, and FizzBuzz
            System.Console.WriteLine($"There were...\n{counter[0]} Fizz's,\n{counter[1]} Buzz's\n{ counter[2]} FizzBuzz's.");

        } //end FizzBuzz

        //start program
        static void Main(string[] args)
        {
            //instantiate the 1000 numbers to be tested
            int[] numList = new int[1000];

            //for loop to instantiate numList 1-1000
            for(int i=1; i<1001; i++)
            {
                numList[i-1] = i;
            }

            //run the FizzBuzz method
            FizzBuzz(numList);

            System.Console.ReadKey();
        } //end main
    }
}
