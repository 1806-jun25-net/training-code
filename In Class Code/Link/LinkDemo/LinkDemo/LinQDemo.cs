using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkDemo
{
   

    public class LinQDemo
    {
        private readonly List<String> list = new List<string>();

        public void Add(string s)
        {
            list.Add(s);
        }
        public void Addmany(IEnumerable<string> strings)
        {
            list.AddRange(strings);
        }
        public string Longest()
        {
            int lenLongest = 0;
            string Longest = null;
            foreach (var item in list)
            {
                if (item.Length > lenLongest)
                {
                    lenLongest = item.Length;
                    Longest = item; 
                }
            }
            return Longest;
        }
        public int  Longests()
        {
            return list.Max(s => s.Length);

        }
        public double Avarage()
        {
            return list.Average(s => s.Length);

        }
        public int TotalVowelCout()
        {
            return list.Sum(s => 
                        s.Count(c =>
                        "aeiou".Contains(c)
                        )
                        );

        }
    }
}
