using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void Arrays()
        {
            // Arrays
            int[] intArray = new int[30]; // all default to 0
            intArray[0] = 1;

            // we can have 2D arrays
            // two ways: #1, array of array (jagged array)
            int[][] arrayOfArray = new int[10][];
            arrayOfArray[0] = new int[3];
            arrayOfArray[0] = new int[6];

            //#2, multi-dimensional array
            int[,] multiArray2D = new int[10, 10];
            multiArray2D[0, 5] = 3;

            int[,,] multiArray3D = new int[10, 10, 10];
            multiArray3D[0, 0, 5] = 3;

            multiArray2D = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
        }

        static void Lists()
        {
            // Lists
            List<string> stringList = new List<string>();
            stringList.Add("Fred");
            stringList[0] = "Nick";

            IEnumerable<string> stringList2 = new List<string> { "Fred", "Nick" };

            foreach (var item in stringList2) // foreach will execute code on each element in a collection (must implement IEnumerable)
            {
                Console.WriteLine(item);
            }

        }

        static void Sets()
        {
            // Sets
            HashSet<int> Sets = new HashSet<int> { 1, 2, 3, 4, 4, 4, 4};
            // duplicates ignored
            // fast to check for membership in a set

        }

        static void Dictionaries()
        {
            var wordDict = new Dictionary<string, string>();
            wordDict.Add("apple", "round red fruit"); // "apple" acts as a key that points to the string "round red fruit"

            // can do an address book, but good OOP practice to put this information in a person object
            var addressBook = new Dictionary<string, string>
            {
                { "Nick", "Sterling, VA" }
            };
            addressBook["Nick"] = "Reston, VA";


        }

    }
}
