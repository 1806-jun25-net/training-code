using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Library
{
    public interface AnimalInterface
    {
        string Name { get; set; }
        void MakeSound();
        void move(string location);
    }
}
