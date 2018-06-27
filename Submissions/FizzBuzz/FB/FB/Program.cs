using System;

namespace FB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int x = 0, y = 0, z = 0;

            for (int i = 1; i <= 1000; i++)
            {

                if (i % 3 == 0 && !(i % 5 == 0))
                {
                    Console.WriteLine("Fizz");
                    x++;
                }

                else if (i % 5 == 0 && !(i % 3 == 0))
                {
                    Console.WriteLine("Buzz");
                    y++;
                }

                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Fizzbuzz");
                    z++;
                }
                else
                {
                    Console.WriteLine(i);
                }

            }

            Console.WriteLine("Number of Fizzes   " + x );
            Console.WriteLine("Number of Buzzes   " + y );
            Console.WriteLine("Number of Fizzbuzzes   " + z );

        }
    }
}
