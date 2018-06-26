using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Library
{
    public class bird : IAnimal
    {
        public string Name { get; set; }
        public string OwnerName { get; set; }

        public void GoToLocation(string location)
        {
            Console.WriteLine("walk to {location}");
        }

        public void MakeSound()
        {
            Console.WriteLine("kaakaaa");
        }
       
        
    }
}
