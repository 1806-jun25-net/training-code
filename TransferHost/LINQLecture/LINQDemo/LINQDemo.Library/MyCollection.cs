using System;
using System.Collections.Generic;
using System.Text;

namespace LINQDemo.Library
{

    //public class MyItem
    //{
    //    public int Index { get; set; }
    //}

        //can specify contraints on the generic type param
    public class MyCollection<T/*or myType*/> where T:new()//means type T must have a default constructor
    {
        private readonly/*r-o is a check that
        dev wont reassign to a new list*/ List<T/*repeat myType here*/> TheList = new List<T>();

        //bool isindexOne(T item)
        //{
        //    return item.Index == 1;
        //}

        public T MakeNewItem()
        {
            return new T();
        }

        public void Add(T item)
        {
            TheList.Add(item);/*will be passing in a list of things ; and t
            hey do it through the interface of IEnumerable*/
        }

    }
}
