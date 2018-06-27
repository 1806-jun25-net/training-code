using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Day3Collection
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static void List()
        {
            List<string> stringList = new List<string> { "Freed", "Nick" };//Grouped Initialization.


            List<string> stringList2 = new List<string>();

            stringList2.Add("Freed");
            stringList2[0] = "Nick";


            foreach (var item in stringList)
            {
                Console.WriteLine(item);
            }


        }


        static void Sets()
        {
            HashSet<int> set = new HashSet<int> { 1, 2, 3, 4, 5 };//{ 1,2,3,4,,4,4,4, 5} all those extra duplicate are gonna be ignored.
            //Also is fast to check in a membership in a set.



        }


        static void Dictionaries ()
        {
            var wordDic = new Dictionary<string, string>();

            wordDic.Add("Apple" , "round red fruit");
            //(Key , value)


        }


        static void Array()
        {


            int[] intArray = new int[30];//always default to 0
            intArray[0] = 1;
            // we can have 2d arrays md arrays.
            // 2 ways arrays of arrays (jagged arrays)
            int[][] arrayOfArrays = new int[10][];
            arrayOfArrays[0] = new int[] { 1,2,3};
            arrayOfArrays[0] = new int[6];
            //Multy array
            int[,] multiArray = new int[10, 10];
            multiArray[0, 5] = 3;

            multiArray = new int[,] { { 1,2,3}, {4,5,6 } };

            Console.WriteLine(multiArray[0,5].ToString());


        }
    }
}
