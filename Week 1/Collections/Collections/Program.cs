using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void List()
        {
            List<string> stringList = new List<string>();
            stringList.Add("Fred");
            stringList[0] = "Nick";

            List<string> stringList2 = new List<string> { "Fred", "Nick" };

            foreach(var item in stringList)
            {
                Console.WriteLine(item);
            }
        }

        static void Sets()
        {
            HashSet<int> set = new HashSet<int> { 1, 2, 3, 4, 1}; //duplicates are allowed but not counted
        }

        static void Dictionaries()
        {
            var wordDict = new Dictionary<string, string>();
            wordDict.Add("apple", "round red fruit");

            var addressBook = new Dictionary<string, string>();
            addressBook.Add("Wayne", "Herndon, VA");
            addressBook["Wayne"] = "Reynonlds, ND";
        }

        static void Arrays()
        {
            int[] intArray = new int[30];
            intArray[0] = 1;

            //these arrays are not required to be squares
            int[][] arrayOfArray = new int[10][];
            arrayOfArray[0] = new int[10];
            arrayOfArray[1] = new int[5];

            int[,] multiArray = new int[10, 10];
            multiArray[0, 5] = 3;

            //these arrays are required to be square
            multiArray = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
        }
    }
}
