using System;
using System.Collections.Generic;
using System.Text;

namespace LINQDemo.Library
{
    public class MyCollection<T> where T : new()
    {
        private readonly List<T> theList = new List<T>();

         T MakeNewItem()
        {
            return new T();
        }
    }
}
