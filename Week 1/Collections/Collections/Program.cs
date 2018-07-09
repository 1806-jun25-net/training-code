using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            
        }

        static void List()
=======

        }

        static void Lists()
>>>>>>> origin/master
        {
            List<string> stringList = new List<string>();
            stringList.Add("Fred");
            stringList[0] = "Nick";

<<<<<<< HEAD
            List<string> stringList2 = new List<string> { "Fred", "Nick" };

            foreach(var item in stringList)
=======
            IEnumerable<string> stringList2 = new List<string> { "Fred", "Nick" };

            foreach (var item in stringList2)
>>>>>>> origin/master
            {
                Console.WriteLine(item);
            }
        }

        static void Sets()
        {
<<<<<<< HEAD
            HashSet<int> set = new HashSet<int> { 1, 2, 3, 4, 1}; //duplicates are allowed but not counted
=======
            HashSet<int> set = new HashSet<int> { 1, 2, 3, 4, 4, 4, 4 };
            // duplicates ignored
            // fast to check for membership in a set
>>>>>>> origin/master
        }

        static void Dictionaries()
        {
            var wordDict = new Dictionary<string, string>();
<<<<<<< HEAD
            wordDict.Add("apple", "round red fruit");

            var addressBook = new Dictionary<string, string>();
            addressBook.Add("Wayne", "Herndon, VA");
            addressBook["Wayne"] = "Reynonlds, ND";
=======

            wordDict.Add("apple", "round red fruit");

            var addressBook = new Dictionary<string, string>
            {
                { "Nick", "Sterling, VA" }
            };
            addressBook["Nick"] = "Reston, VA";
>>>>>>> origin/master
        }

        static void Arrays()
        {
<<<<<<< HEAD
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
=======
            int[] intArray = new int[30]; // all default to 0
            intArray[0] = 1;

            // we can have 2d arrays
            // two ways: #1, array of array (jagged array)
            int[][] arrayOfArray = new int[10][];
            arrayOfArray[0] = new int[] { 1, 2, 3 };
            arrayOfArray[0] = new int[6];

            // #2, multi-dimensional array
            int[,] multiArray = new int[10, 10];
            multiArray[0, 5] = 3;

            // array initialization
            multiArray = new int[,] { { 1, 2, 3}, { 4, 5, 6 } };
>>>>>>> origin/master
        }
    }
}
