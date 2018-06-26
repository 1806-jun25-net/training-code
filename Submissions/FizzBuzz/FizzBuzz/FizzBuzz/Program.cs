using System;

namespace FizzBuzz
{
    class Program
    {
        public static void Main(string[] args)
        {
            FizzBuzz App = new FizzBuzz();
            App.runFizzBuzz(1, 1000);
        }
    }

    class FizzBuzz
    {
        // Counter when number is divisble by 3 & not by 5
        private int fizzCounter = 0;
        // Counter when number is divisble by 5 & not by 3
        private int buzzCounter = 0;
        // Counter when number is divisble by 3 & 5
        private int fizzBuzzCounter = 0;


        // Check if number (n) is divisible by another number (d) provided
        // n = numerator 
        // d = dividend

        private Boolean IsDivisible( int n, int d ) 
        {
            // If result is equal 0, then numerator is divisble by dividend
            return n % d == 0;
        }

        // Main method 
        // start = the number to begin the count
        // end = the last number to count
        public void runFizzBuzz(int start, int end) {
            for (;start <= end ; start ++)
            {
                int current = start;
                fizzBuzz(current);
            }
            // Print statistics result after loop end
            pritnCountersValue();
        }

        // Evaluate if number is fizz, buzz or fizzBuzz
        private void fizzBuzz(int n)
        {
            // True when divisible by both
            if( IsDivisible(n, 3) && IsDivisible(n,5) )
            {
                fizzBuzzCounter += 1;
                fizzBuzzMsg(n, "FizzBuzz");
            } 
            // True when divisible by 3
            else if( IsDivisible(n,3) )
            {
                fizzCounter += 1;
                fizzBuzzMsg(n, "Fizz");
            } 
            // True when divisible by 5
            else if( IsDivisible(n,5) )
            {
                buzzCounter += 1;
                fizzBuzzMsg(n, "Buzz");
            }
            else {
                
                Console.WriteLine(n);
            }
        }

        // Show number with the corresponding fizz, buzz, fizzBuzz type
        private void fizzBuzzMsg(int n, string type)
        {
            Console.WriteLine($"{type}: {n}");
        }

        // Print the value of fizz, buzz & fizzBuzz
        public void pritnCountersValue() 
        {
            string msg = $"Result:\n"
            + $"Total of FizzBuzz: {fizzBuzzCounter}\n"
            + $"Total of Fizz: {fizzCounter}\n"
            + $"Total of Buzz: {buzzCounter}\n";
            Console.WriteLine(msg);
        }
    }
}
