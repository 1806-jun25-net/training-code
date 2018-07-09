using System;
using System.Collections.Generic;
using System.Text;

namespace LINQDemo.Library
{
    public static class ExtensionMethods
    {
<<<<<<< HEAD
        //Extension Methods allow you to add any method you want to any other class
        //private members are still off limits

=======
>>>>>>> origin/master
        public static bool IsEmpty(this NonGenericCollection col)
        {
            return col.DumbLongest() == null;
        }
    }
}
