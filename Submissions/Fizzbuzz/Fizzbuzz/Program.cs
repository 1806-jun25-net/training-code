using System;

namespace Fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Program f = new Program();
            f.Fizz(1000);
        }


        public void Fizz(int x)
        {
            int fizzcounter = 0;
            int buzzcounter = 0;
            int fizzbuzzcounter = 0;
            for (int i = 1; i <= x; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Fizzbuzz");
                    fizzbuzzcounter++;
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    fizzcounter++;
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    buzzcounter++;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("{0} Fizz", fizzcounter);
            Console.WriteLine("{0} Buzz", buzzcounter);
            Console.WriteLine("{0} Fizzbuzz", fizzbuzzcounter);
        }
    }
}
