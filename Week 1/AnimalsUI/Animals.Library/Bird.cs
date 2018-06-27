using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Library
{
    class Bird : AnimalInterface
    {
        public string Name { get; set; }

        public void MakeSound()
        {
            Console.WriteLine("CAW");
        }

        public void move(string location)
        {
            Console.WriteLine($"Flying to {location}");
        }
    }
}
