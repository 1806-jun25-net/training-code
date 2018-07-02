using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Library
{
    class AAnimal : IAnimal
    {
        public string Name { get; set; }

        public abstract string GoAction { get; set; }

        public void GoToLocation(string location)
        {
            Console.WriteLine($"{GoAction} to {location}");
        }

        public void MakeSound()
        {
            throw new NotImplementedException();
        }
    }
}
