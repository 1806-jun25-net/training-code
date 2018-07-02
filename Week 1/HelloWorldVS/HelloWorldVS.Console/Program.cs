namespace HelloWorldVS.Console
{
    class Program
    {
        static void PrintMoreLines()
        {
            System.Console.WriteLine("more print");
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            System.Console.WriteLine("Hello World!");
            PrintMoreLines();
            System.Console.WriteLine("Hello World!");
        }
    }
}
