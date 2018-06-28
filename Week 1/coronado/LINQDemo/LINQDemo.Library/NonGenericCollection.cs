using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQDemo.Library
{
    public class NonGenericCollection
    {
        private readonly List<string> list = new List<string>();

        public void Add(string s)
        {
            list.Add(s);
        }

        public void AddMany(IEnumerable<string> strings)
        {
            list.AddRange(strings);       
        }

        public string Longest()
        {
            //var example = new { s = "abc", l = "abc".Length }; // anonymous types


            // method syntax
            List<int> listOfLengths = list.Select(s => s.Length).ToList(); //ToList() forces the iteration

            // query syntax
            List<int> listOfWithAwfulSyntax =   ( 
                                                from item in list
                                                where item.Length > 2
                                                select item.Length
                                                ).ToList();
                                        
            //var itemLengthPairs = list.Select(s => new { s, l = s.Length }); // Select() takes every element in the list and maps it to something new
            //var maxLengthPair = itemLengthPairs.Max(a => a.l, );

            var length = LongestLength();
            return list.First(s => s.Length == length);
            
        }

        public string DumbLongest()
        {
            int longestLength = 0;
            string longest = null;

            foreach (var item in list)
            {
                if (item.Length > longestLength)
                {
                    longestLength = item.Length;
                    longest = item;
                }
            }

            return longest;
        }

        public int LongestLength()
        {
            return list.Max(x => x.Length);
        }

        public double AverageLength()
        {
            return list.Average(x => x.Length);
        }

        public int TotalVowelCount()
        {
            return list.Sum(s =>
                s.Count(c =>
                    "aeiouAEIOU".Contains(c)
                )
            );
        }

        public string ThirdAlphabetical()
        {
            // LINQ deferred execution
            IEnumerable<string> query = list.OrderBy(x => x).Skip(2); // Skip() cuts out the first 2 elements of a list
            return query.First(); // Because we skipped the first 2 elements, First() will give us what would have been the third in alphabetical order of the whole list
        }

       
        public bool Contains(string item)
        {
            // null check code
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            return list.Contains(item);
        }

    }
}
