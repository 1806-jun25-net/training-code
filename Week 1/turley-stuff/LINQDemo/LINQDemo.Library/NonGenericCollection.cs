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
                    longest = item;
                    longestLength = item.Length;
                }
            }
            return longest;
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
                s.Count(c=> 
                    "aeiouAEIOU".Contains(c)
                )
            );
        }

        public string ThirdAlphabetical()
        {
            var query = list.OrderBy(x => x).Skip(2);
            return query.First();
        }

        public bool Contains(string s)
        {
            foreach(string i in list){
                if (i.Equals(s)) return true;
            }
            return false;
        }
    }
}
