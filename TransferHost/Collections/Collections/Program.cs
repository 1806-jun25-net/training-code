using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nLists!");
            Lists();
            Console.WriteLine("\nSets!");
            Sets();
            Console.WriteLine("\nArrays");
            Arrays();
            Console.WriteLine("\nDictionaries");
            Dictionaries();
            Console.WriteLine("hello");
            Console.ReadKey();
        }

        //######################### COLLECTIONS ########################

            //############ DICTS ###############
        static void Dictionaries()
        {
            Dictionary<string, string> wordDict = new Dictionary<string, string>();//could use var instead for less wording
            //var wordDict = new Dictionary<string, string>();//EXAMPLE


            wordDict.Add("apple", "round red fruit");

            //RETURNS GEY AND VALUE(PRINTED OUT IN CONSOLE)
            foreach(/*KeyValuePair<string,string>*/var pair in wordDict)
            {
               
                Console.WriteLine($"{pair.Key} is a {pair.Value}");
            }
           
            //VAR INFERS TYPE AND CREATES DICT FASTER
            var addressBook = new Dictionary<string, string>
            {
                {"Nick", "Sterling,VA"}
            };
            addressBook["Nick"] = ("Reston,VA");

            foreach (var p in addressBook)
            {
                Console.WriteLine($"{p.Key} is a {p.Value} as well!LOL");
            }

            
        }

        //###################### SETS ####################
        static void Sets()
        {
            HashSet<int> set = new HashSet<int> { 1, 2, 3, 4, 4, 4, 4 };
            //duplicates ignored
            //fast check for membership in a set
            foreach(var item in set)
            {
                Console.WriteLine(item);
            }

            SortedSet<string> wordString= new SortedSet<string> {"chim","chimm","chirrooo" };
            foreach(var t in wordString)
            {
                Console.WriteLine(t);
            }
        }

        //################# LISTS ####################
        static void Lists()
        {
            List<string> stringList = new List<string>();
            stringList.Add("fred");
            //stringList[1] = "Nick";

            List<string> stringList2 = new List<string>();
            stringList2.Add("Fred");//same as above but different setup
            stringList2.Add("Nick");

            

            foreach(var item in stringList2)
            {
                Console.WriteLine(item);
            }


        }

        //############## ARRAYS #####################
        static void Arrays()
        {
            int[] intArray = new int[30];//all default to 0
            intArray[0]=1;

            //we can have 2D arrays
            //two ways: #1, array of array(jagged array)
            int[][] arrayOfArray = new int[10][];
            arrayOfArray[0] = new int[3] { 1, 2, 3 };//array initialization
            arrayOfArray[1] = new int[4] {1,2,3,4};/*each new array object has
            to have both the size plitted out and the ints that will occupy that space*/
            arrayOfArray[2] = new int[5] { 1,2,3,4,5};
            arrayOfArray[3] = new int[6];/*either be explicit with
            number of ints or not at all*/
            for (var i=0;i<arrayOfArray[0].Length;i++)
            {
                Console.WriteLine("something {0},", arrayOfArray[0][i]);
            }
            Console.WriteLine(arrayOfArray[0][1]);
            Console.WriteLine(arrayOfArray[1][2]);
            Console.WriteLine(arrayOfArray[2][4]);

            // #2, MULTI-DIMENTIONAL ARRAYS
            string[,] multiArray = new string[3, 2] { { "one", "two" }, { "three", "four" },
                                        { "five", "six" } };//three indexes,2 entries per index 
           // multiArray[0, 5] = 3;
           /*assigning 3 to the first index in the array and the
            fifth index in the array within that array*/
            Console.WriteLine("\n"+multiArray[1,0]);//three
            Console.WriteLine( multiArray[2, 1]);//six

            // array initialization
            //  multiArray = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };//this would be (2,3)


            //Console.ReadKey();
        }
    }
}
