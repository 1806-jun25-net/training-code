using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Library
{
    public class Dog : AAnimal
    {
        /*
        //field with getter and setter

        private string name;

        public string GetName()
        {
            return name;
        }

        public void SetName(string newName)
        {
            name = newName;
        }
        */

        public string Name { get; set; } //auto-implemented property

        private string ownerName; //backing field

        public string OwnerName
        {
            get { return ownerName; }
            set
            {
                if (value != null)
                {
                    ownerName = value;
                }
            }
        }

        public void MakeSound()
        {
            Console.WriteLine("Woof!");
        }

        public void GoToLocation(string location)
        {
            //string interpolation
            //Console.WriteLine("Walk to " + location);
            Console.WriteLine($"Walk to {location.ToUpper()}");
        }
    }
}
