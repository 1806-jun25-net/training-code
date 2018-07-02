using System;
using System.Linq;

namespace Palidrone.Library
{
    public static class Palidrone
    {
        public static Boolean IsPalidrone(String s) 
        {
            String original = s;
            String isPalidrone = reverseString(original);
            return (original == isPalidrone);
        }

        public static string reverseString(String s) {
            return new string(s.Reverse().ToArray());
        }
    }
}
