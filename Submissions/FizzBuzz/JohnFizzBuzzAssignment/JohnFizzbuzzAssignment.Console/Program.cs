using System;

namespace JohnFizzbuzzAssignment.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello VWorld!");
            FizzBuzz();
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();

        }

        public static void FizzBuzz()
        {
            int Fizzes = 0;
            int Buzzes = 0;
            int FizzBuzzes = 0;
            for(int i=1;i<=1000;i++)
            {
                if((i%3==0)&&(i%5==0))
                {
                    System.Console.WriteLine("FIZZBUZZ");
                    FizzBuzzes++;
                }
                else if(i%3==0)
                {
                    System.Console.WriteLine("Fizz");
                    Fizzes++;
                }
                else if(i%5==0)
                {
                    System.Console.WriteLine("Buzz");
                    Buzzes++;
                }
                
                else
                {
                    System.Console.WriteLine(i);
                }
            }
            System.Console.WriteLine("\nThere are "+Fizzes+" Fizzes.\n");
            System.Console.WriteLine("There are "+Buzzes+" Buzzes.\n");
            System.Console.WriteLine("There are "+FizzBuzzes+" FizzBuzzes.\n");
        }
    }
}
