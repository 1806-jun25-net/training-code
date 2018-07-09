using System;
using System.Collections.Generic;
using System.Text;

namespace LINQDemo.Library
{
<<<<<<< HEAD
    //public class MyItem
    //{
    //    public int Index { get; set; }
    //}

    //can specify constraints on the generic type parameter
    public class MyCollection<T> where T : new() //<T> declaring a type parameter
    {
        private readonly List<T> TheList = new List<T>();
=======
    //public class MyItem {
    //    public int Index { get; set; }
    //}

    // can specify contraints on the generic type parameter
    public class MyCollection<T> where T : new()
    {
        private readonly List<T> theList = new List<T>();
>>>>>>> origin/master
        
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
<<<<<<< HEAD
            TheList.Add(item);
=======
            theList.Add(item);
>>>>>>> origin/master
        }
    }
}
