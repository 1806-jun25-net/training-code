using System;

namespace FizzBuzz
{
    public class Class1
    {

        public static void Main(string[] args)
        {




            {
                //initialize the count to increase with each return off fizz, buzz and fizzbuzz
                int fizzCount = 0;
                int buzzCount = 0;
                int fizzbuzzCount = 0;
                for (int i = 1; i <= 1000; i++)
                {
                    //Declaration of Fizz and Buzz as Boolean
                    bool fizz = i % 3 == 0;
                    bool buzz = i % 5 == 0;
                    //Fizzbuzz declared to be conditional if its both
                    bool fizzbuzz = fizz && buzz;


                    if (fizzbuzz)


                    {
                        fizzbuzzCount++;
                        Console.WriteLine("FizzBuzz");

                    }
                    else if (fizz)
                    {
                        fizzCount++;
                        Console.WriteLine("Fizz");
                    }
                    else if (buzz)
                    {
                        buzzCount++;
                        Console.WriteLine("Buzz");
                    }
                    else
                        //when it doesnt pass the check for any, displays the number
                        Console.WriteLine(i);
                    //Outputs the total count of each FIzz, Buzz and Fizzbuzz



                }
                Console.WriteLine("The total Fizz count is : " + fizzCount.ToString());
                Console.WriteLine("The total Buzz count is :" + buzzCount.ToString());
                Console.WriteLine("The total FizzBuzz count is :" + fizzbuzzCount.ToString());

            }


        }
       



    }
}
        



     
    


