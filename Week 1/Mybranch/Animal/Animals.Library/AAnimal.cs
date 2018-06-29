using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Library
{
    public abstract class AAnimal : IAnimal
    {
        public abstract string Name { get; set; }

        public abstract string GoAction { get; set; }

        public void GoToLocation(string location)
        {
            Console.WriteLine($"{GoAction} to {location}");
        }

        public abstract void MakeSound();
    }
}
