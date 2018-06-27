using System;
using System.Collections.Generic;
using System.Text;

namespace Animas.Library
{
    public abstract class AAnimal : IAnimal
    {
        public string Name { get; set; }
        public string OwnerName { get ; set ; }
        public abstract string GoAction { get; set;}

        public  void goToLocation(string location)
        {
            Console.WriteLine($"{GoAction} to {location}");
        }

        public void goToLocation()
        {
            throw new NotImplementedException();
        }

        public  void MakeSound()
        {
            throw new NotImplementedException();
        }
    }
}
