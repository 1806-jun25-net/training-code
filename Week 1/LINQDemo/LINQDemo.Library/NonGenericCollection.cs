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
<<<<<<< HEAD

            list.AddRange(strings);

            //same thing as AddRange
            //foreach (var item in strings)
            //{
            //    list.Add(item);
            //}
=======
            list.AddRange(strings);
>>>>>>> origin/master
        }

        public string Longest()
        {
<<<<<<< HEAD
            //same as the lambda function below
            //var example = new { s = "abc", l = "abc".Length };
            
            //method syntax
            List<int> listOfIntegers = list.Select(s => s.Length).ToList();

            //query syntax
=======
            //var example = new { s = "abc", l = "abc".Length };
            // method syntax
            List<int> listOfLengths = list.Select(s => s.Length).ToList();
            // query syntax
>>>>>>> origin/master
            List<int> listWithAwfulSyntax = (from item in list
                                             where item.Length > 2
                                             select item.Length).ToList();

<<<<<<< HEAD
            var length = SmartLongest();
=======
            var length = LongestLength();
>>>>>>> origin/master
            return list.First(s => s.Length == length);
        }

        public string DumbLongest()
        {
            int longestLength = 0;
            string longest = null;

            foreach (var item in list)
            {
<<<<<<< HEAD
                if(item.Length > longestLength)
=======
                if (item.Length > longestLength)
>>>>>>> origin/master
                {
                    longestLength = item.Length;
                    longest = item;
                }
            }

            return longest;
        }

<<<<<<< HEAD
        public int SmartLongest()
        {
            return list.Max(s => s.Length);
=======
        public int LongestLength()
        {
            return list.Max(x => x.Length);
>>>>>>> origin/master
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
<<<<<<< HEAD
            //linq deferred execution
=======
            // linq deferred execution
>>>>>>> origin/master
            IEnumerable<string> query = list.OrderBy(x => x).Skip(2);
            return query.First();
        }

        public bool Contains(string item)
        {
<<<<<<< HEAD
            //null check code
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

=======
            // null check code
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
>>>>>>> origin/master
            return list.Contains(item);
        }
    }
}
