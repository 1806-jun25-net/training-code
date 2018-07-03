using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Library
{
    public abstract class AAnimals:IAnimal
    {
        public abstract string Name { get; set; }
        public abstract string GoAction { get; set; }
        public void GoToLocation(string Location)
        {
            Console.WriteLine($"{GoAction} to {Location}");
        }

        public abstract void MakeSound();
    }
}
