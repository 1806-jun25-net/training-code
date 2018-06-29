using System;

namespace HelloWorldVSConsole
{
    class Program
    {
        
        static void PrintMoreLines()
        {
            Console.WriteLine("more print");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            PrintMoreLines();
            Console.WriteLine("Hello World!");
        }
    }
}
