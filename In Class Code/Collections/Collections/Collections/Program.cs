using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        static void Lists()
        {
            List<string> stringList = new List<string>();

            stringList.Add("Fred");
            stringList[0] = "Rick";

            foreach ( var item in stringList)
            {



            }
        }
        static void set()
        {
            HashSet<int> set = new HashSet<int> { 1, 2, 3, 4 };
        }
        static void Dictionarias()
        {
            var varDict = new Dictionary<String, string>();

            varDict.Add("apple", "round red fruit");

        }
        static void Array()
        {
            int[] intArry = new int[10];//default 0  
            intArry[0] = 1;

            // we can have 2 arrays 
            // two ways array of array 1# jagged array 
            int[][] arrayOfArray = new int[10][];
            arrayOfArray[0] = new int[3];

            //#2 multi-dimentinal array
            int[,] multiArray = new int[10, 10];// [X,Y]

        }
    }
}
