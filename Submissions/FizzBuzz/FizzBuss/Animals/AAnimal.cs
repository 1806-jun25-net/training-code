using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Library
{
    abstract class AAnimal
    {
       public abstract string Name { get; set; }
        public object GoToAction { get; private set; }

        public void GoToLocation(string location)
        {
            Console.WriteLine($"{GoToAction} to {location}");
        }

        public abstract void MakeSoud();
    }
}
