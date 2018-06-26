using System;

namespace agocs
{
    class Program
    {
        public static void Main(string[] args)
        {
            FizzFunc();         
        }

        public static void FizzFunc()
        {

            int fizz = 0;
            int buzz = 0;
            int fizzbuzz = 0;

            for (int x = 1; x < 1001; x++)
            {
                if (x % 3 == 0 && 
                    x % 5 == 0)
                {
                    fizzbuzz++;
                    Console.WriteLine("Fizzbuzz");
                }

                else if (x % 3 == 0)
                {
                    fizz++;
                    Console.WriteLine("Fizz");
                }

                else if (x % 5 == 0)
                {
                    buzz++;
                    Console.WriteLine("Buzz");
                }
            }

                Console.WriteLine("Fizz: " + fizz + "\n" +
                                  "Buzz: " + buzz + "\n" +
                                  "Fizzbuzz " + fizzbuzz + "\n");
            }
        }
    }

