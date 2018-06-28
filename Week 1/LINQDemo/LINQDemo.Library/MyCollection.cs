using System;
using System.Collections.Generic;
using System.Text;

namespace LINQDemo.Library
{
    //public class MyItem {
    //    public int Index { get; set; }
    //}

    // can specify contraints on the generic type parameter
    public class MyCollection<T> where T : new()
    {
        private readonly List<T> theList = new List<T>();
        
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
            theList.Add(item);
        }
    }
}
