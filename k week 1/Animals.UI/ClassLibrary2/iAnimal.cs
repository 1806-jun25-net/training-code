using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Library
{
    public interface IAnimal
    {
        string Name { get; set; }
        void GoToLocation(string location);
        void MakeSound();

    }
}
