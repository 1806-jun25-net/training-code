using System;
using System.Collections.Generic;
using System.Text;

namespace FizzFuss.Library
{
    class BuzzFuzz : Ifizzy
    {
        private string _sound;
        private int count1;

        public int Getcount() => count1;

        public void Setcount(int value) => count1 = value;

        public string Sound { get => _sound; set => _sound = value; }


    }
}
