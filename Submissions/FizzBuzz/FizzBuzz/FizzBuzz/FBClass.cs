using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FBClass
    {


        


        public void MethodFB()
        {

            int countFizz = 0;
            int countBuzz = 0;
            int countFizzBuzz = 0;

            for (int i = 1; i <= 1000; i++)
            {
                bool fizz = i % 3 == 0; // Compare in this statement. If the currently number is not dividible by 3 then it will be false and it will go down and print the correct statement.
                bool buzz = i % 5 == 0;// Compare in this statement. If the currently number is not dividible by 5 then it will be false and it will go down and print the correct statement.

                if (buzz && fizz)
                {
                    Console.WriteLine("FizzBuzz");
                    countFizzBuzz++;// To count the FizzBuzz so we can print them out.
                }
                else if (buzz)
                {
                    Console.WriteLine("Buzz");
                    countBuzz++;// To count the Buzz so we can print them out.
                }
                else if (fizz)
                {
                    Console.WriteLine("Fizz");
                    countFizz++;// To count the Fizz so we can print them out.
                    //
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            //Now we print every count that we have collected.
            Console.WriteLine("The amount of Fizz are: " + countFizz);
            Console.WriteLine("The amount of Buzz are: " + countBuzz);
            Console.WriteLine("The amount of BuzzFizz are: " + countFizzBuzz);



        }

    }

}

