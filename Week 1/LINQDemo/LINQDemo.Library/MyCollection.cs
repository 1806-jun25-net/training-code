using System;
using System.Collections.Generic;
using System.Text;

namespace LINQDemo.Library
{
    //public class MyItem
    //{
    //    public int Index { get; set; }
    //}

    //can specify constraints on the generic type parameter
    public class MyCollection<T> where T : new() //<T> declaring a type parameter
    {
        private readonly List<T> TheList = new List<T>();
        
        //bool IsIndexOne(T item)
        //{
        //    return item.Index == 1;
        //}

        public T MakeNewItem()
        {
            return new T();
        }

        public void Add(T item)
        {
            TheList.Add(item);
        }
    }
}
