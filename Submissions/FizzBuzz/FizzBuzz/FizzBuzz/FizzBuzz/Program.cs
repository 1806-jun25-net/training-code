using System;

namespace FizzBuzz
{
    public class Class1
    {
        public const string  FIZZ = "Fizz";
        public const string BUZZ = "Buzz";
        public const int FIZZBUZZ = "FizzBuzz";
        public static void Main(string[] args)
        {
        
            //Textbook Fizzbuzz
            for ( int i = 0; i <= 1000; i++)

                //if i is divisible by 3 say Fizz
              
                if (i % 3 == 0 && i % 5 != 0)
                    {
                    i = FIZZ; 
                        Console.WriteLine("Fizz");
                   
                    }
                
                //else if its divisible by 5 its Buzz
                else if (i % 3 != 0 && i % 5 == 0)
                {
                    i = BUZZ;
                    Console.WriteLine("Buzz");

                }
                //if i is divisible by 3 and 5 write Fizzbuzz
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    i = FIZZBUZZ;
                    Console.WriteLine("FizzBuzz");
                    
                }//Make the program return the number of Fizz and Buzz and Fizzbuzz there are in total
            Console.WriteLine("There is a total of :" + FIZZ);
            Console.WriteLine("There is a total of :" + BUZZ);
            Console.WriteLine("There is a total of :" + FIZZBUZZ);

        }
            }
        }
    


