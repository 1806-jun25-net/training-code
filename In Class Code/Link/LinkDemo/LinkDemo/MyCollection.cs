using System;
using System.Collections.Generic;

namespace LinkDemo
{
    //public class MyItem
    //{
    //    public int index { get; set; }
    //}
    public class MyCollection<T> where T : new()
    {
        private List <T> TheList = new List<T>();

        //bool IsIndexOne(T item)
        //{
        //    return item.index == 1;
        //}

        public T MakeNewItem()
        {
            return new T();
        }
        public void Add (T item)
        {
            TheList.Add(item);
        }
    }
}
