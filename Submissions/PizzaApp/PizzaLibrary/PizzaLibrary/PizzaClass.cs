using System;

namespace PizzaLibrary
{
    public class PizzaClass
    {
        public bool stringTest(string s)
        {
            if (s is string) { return true; }
            else return false;
        }
    }
}
