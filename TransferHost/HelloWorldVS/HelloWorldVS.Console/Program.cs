using System;

namespace HelloWorldVS.Console
{
    class Program
    {
        static void PrintMoreLines()
        {
            System.Console.WriteLine("print somethin els");
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            System.Console.WriteLine("Hello World!");
            PrintMoreLines();
            System.Console.WriteLine("Hello Worls");
        }
    }
}
