using System;

namespace GitTestSln
{
    class Program
    {
        


        static void Main(string[] args)
        {


           


            Console.WriteLine("Hello World!");
            Console.WriteLine("This is my branch lets see if it syncs.");

            int number = 10;
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(i);


                if (i == 9)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                }
            }

            







        }


       


    }
}
