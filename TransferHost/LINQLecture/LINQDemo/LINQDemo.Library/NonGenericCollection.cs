using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQDemo.Library
{
   public class NonGenericCollection
    {
        public void MakeSound(string s)
        {
            Console.WriteLine("Bowow, {0}",s);
            list.Add(s);
        }
        /*private readonly*/
        public List<string> list = new List<string>();
        
        public void Add(string s)
        {
            list.Add(s);
        }

        public void AddMany(IEnumerable<string> strings)//IE needed for foreach
        {
            //foreach (var item in strings)
           // {
                list.AddRange(strings);//THIS INJECTS LIST TO END OF PARENT LIST
            /*will be passing in a list of things ; and t
            hey do it through the interface of IEnumerable*/
           // }
        }

        public string Longest()
        {
            int longestLength = 0;
            string longest = null;
            foreach (var item in list)
            {
                if (item.Length > longestLength)//COMPARISON OPERATOR WRONG TO SHOW FAILED UNIT TEST
                {
                    longestLength = item.Length;
                    longest = item;
                }
            }
            return longest;
        }

        public string NicksLongest()
        {
            ///var example = new { s = "abc", a = "abc".Length };
            var ListOflengths = list.Select(s => s.Length).ToList();//
            var itemLengthPairs = list.Select(s => new { s, l = s.Length });//

            //var maxLengthPair = itemLengthPairs.Max(a => a.l,);
            var length= LongestLength();
            return list.First(s => s.Length == length);
        }

        public List<int> LinqOwnSyntax()//this method type must be the same as return value type
        {
            List<int> listWithAwfulSyntax = (from
                                      item in list
                                      where item.Length > 2
                                    select item.Length).ToList();
            return listWithAwfulSyntax;
        }

        public int LongestLength()
        {
            return list.Max(s => s.Length);
        }

        public double AverageLength()
        {
            return list.Average(s => s.Length);
        }

        public int TotalVowelCount()
        {

            return list.Sum(s =>
                s.Count(c =>
                        "aeiouAEIOU".Contains(c)
                  )
              );//way to sum up vowels in list(string)
        }

        //OF DAY 2
        public String ThirdAlphabetical()
        {
            //LINq DEFERRED EXECUTION
            var query= list.OrderBy(x =>x).Skip(2);//sorts;then discard first two after sort
            //var can be replaced by IEnumerable<string>;
            return query.First();//First returns first element in a sequence

        }

        public bool Contains(string item)
        {
            if(item == null)//this is best  practice to make sure your
                //items dont encounter nulls randomly
                //catches it
            {
                throw new ArgumentNullException("item");//or nameof(item)
            }
            return list.Contains(item);
        }
    }





    }
