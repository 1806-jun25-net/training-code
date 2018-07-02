using System;

namespace PizzaLibrary
{
    public class Pizza
    {
        public static bool stringTest(string s)
        {
            if (s is string) { return true; }
            else return false;
        }
    }
}
