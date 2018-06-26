using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    interface IAnimal
    {
         String Name { get; set; }
        void MakeSOund();
        void GoToLocation();
    }
}
