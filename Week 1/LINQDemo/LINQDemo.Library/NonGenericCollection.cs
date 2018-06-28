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
            return list.Average(s => s.Length);
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
            // linq deferred execution
            IEnumerable<string> query = list.OrderBy(x => x).Skip(2);
            return query.First();
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
