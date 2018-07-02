using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Library
{
    public interface IAnimals
    {
        string Name { get; set; }
        void MakeSound();
        void GoToLocation(string location);
    }
}
