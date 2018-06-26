using System;
using System.Collections.Generic;
using System.Text;

namespace FizzFuss
{
    interface Ifizzy
    {
        int Getcount();
        void Setcount(int value);

        string Sound { get; set; }

    }
}
