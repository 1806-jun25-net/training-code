using LINQDemo.Library;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ReferalEx
{
    class ActuallyUsingGCclass
    {
        public static void Main()
        {
            NonGenericCollection r = new NonGenericCollection();
            //MakeSound() method
            r.MakeSound("String");
            string[] arrbol = new string[] {"hello","how","you","is","?"};
            //ADD() METHOD
            
            r.Add("BA");
            //ITERATING WITH ADD() METHOD
            //for(int i=0;i<arrbol.Length;i++)
            //{
            //    r.Add(arrbol[i]);
            //}

            r.AddMany(arrbol);

            Console.WriteLine
                ("\n"+r.Longest()+//USING LONGEST() TO find the item with longes char length and printing it
                  "\n"+
                  +r.LongestLength()+"\n" //USING LONGEST LENGTH TO print the number of chars in the longest item
                );

            foreach(var p in r.list)//using **r.list** to access list directly
            {
                Console.WriteLine(p);//printing list of... list
            }

            Console.WriteLine("\nThissun shows average length, babe: "+r.AverageLength() );

            Console.WriteLine("\nNow listen closely! Thissun shows us the Total VOWEL count from all" +
                "the items in the array: {0} ",r.TotalVowelCount());

            //#################################
            //UNIT TEST
            //[Fact]
            //public void DumbLongestSHouldReturnLongest()
            //{
            //    // Arrange
            //    var col = new NonGenericCollection();
            //    var items = new List<string>
            //    {
            //        "a", "ab", "abc", "Nick Escalona", "12345"
            //    };
            //    var expected = "Nick Escalona";
            //    col.AddMany(items);

            //    // Act
            //    var actual = col.Longest();

            //    // Assert
            //    Assert.Equal(expected, actual);
            //}

            Console.ReadKey();

        }


    }
}
