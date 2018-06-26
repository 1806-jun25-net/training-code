using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Library
{
    public abstract class AAnimal : IAnimal
    {
        public string Name { get; set; }

        public abstract GoAction { get; set; }

        public void GoToLocation(string location)
        {
            Console.WriteLine($"{GoAction} to {location}");
        }

        public abstract void MakeSound();
    }
}
