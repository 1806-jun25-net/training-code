using System;
using FizzFuss.Library;

namespace FizzFuss.UI
{
    class Program
    {
        Ifizzy Fizzy = new BuzzFuzz();
        Ifizzy Cout = new BuzzFuzz();

        static string fizzbuzz( float i, String fizzBuss)
        {
            if (i % 3 == 0 && i % 5== 0 )
            {
                fizzBuss = "Fizzbuzz";         
            }
            else if  (i % 5 == 0 )
            {
                fizzBuss = "Fizz";
            }
            else if (i % 3 == 0)
            {
                fizzBuss = "Buss";
            }
            else
            {
                fizzBuss = ""+i;
            }
            Console.WriteLine(fizzBuss);
            return fizzBuss;
        }
        static String Counting_Par_NotPar(int Input, string fizzBuss_Count, string fizzBuss)
        {
            int X= 0;
            int Y = 0;
            int Z = 0;
            for (int i = Input; i < 1000; i++)
            {
                String result = fizzbuzz(i, fizzBuss);
                if (result == "Fizzbuzz" )
                {
                    X++;
                    fizzBuss_Count = "Fizz: "+Y+"\nBuss: "+Z+"\nFizzbuss: "+X;

                }
                else if (result == "Fizz")
                {
                    Y++;
                    fizzBuss_Count = "Fizz: " + Y + "\nBuss: " + Z + "\nFizzbuss: " + X;
                }
                else if (result == "Buss")
                {
                    Z++;
                    fizzBuss_Count = "Fizz: " + Y + "\nBuss: " + Z + "\nFizzbuss: " + X;

                }
                else
                {
                    //do Nothing
                }
            }

            return fizzBuss_Count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Counting_Par_NotPar(1,"",""));
            Console.Read();
        }
    }
}
