using System;
using System.Collections.Generic;

namespace list_quickstart
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkingWithStrings();
            WorkingWithNumbers();
        }

        public static void WorkingWithStrings()
        {
                        //LIST EXAMPLE + FOREACH
            var names = new List<string>{"John","Ana","Felipe"};
            names.Add("Maria");
            names.Add("Joseph");
            names.Remove("Ana");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }//USING  '$' allows you to embed c# code into the string

            //LIST INDEXING EXAMPLE
            Console.WriteLine($"\nMy name is {names[0]}");
            Console.WriteLine($"I've added {names[2]} and {names[3]} to the list");

            //FINDING COUNT OF ITEMS IN LIST
            Console.WriteLine($"The list has {names.Count} people in it");

            //USING INDEXOF TO SEARCH FOR ITEMS IN LIST
                    var index = names.IndexOf("Felipe");
                    if (index == -1)
                    {
                    Console.WriteLine($"When an item is not found, IndexOf returns {index}");
                    }
                    else
                    {
                    Console.WriteLine($"The name {names[index]} is at index {index}");
                    }
                    
                    index=names.IndexOf("Not Found");
                    if (index == -1)
                    {
                    Console.WriteLine($"When an item is not found, IndexOf returns {index}");
                    }
                    else
                    {
                    Console.WriteLine($"The name {names[index]} is at index {index}");
                    }

                    //USING SORT TO ORDER ITEMS IN LIST
                    names.Sort();
                    foreach (var name in names)
                    {
                    Console.WriteLine($"Hello {name.ToUpper()}");
                    }
        }

        public static void WorkingWithNumbers()
        {
            var fibonacciNumbers = new List<int> {1,1};
            Console.WriteLine("\n"+fibonacciNumbers.Count+"\n");
            var previous  = fibonacciNumbers[fibonacciNumbers.Count -1];
            var previous2 = fibonacciNumbers[fibonacciNumbers.Count -2];

            fibonacciNumbers.Add(previous+ previous2);

            foreach(var item in fibonacciNumbers)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
