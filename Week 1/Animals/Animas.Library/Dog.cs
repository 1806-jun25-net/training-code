using Animas.Library;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Library
{
    public class Dog : IAnimal
    {
        //private string name;

        //public string GetName()
        //{
        //    return name;
        //}

        //public void SetName(string newName)
        //{
        //    name = newName;
        //}

        public string Name { get; set; } //auto-implemented property


        //manully
        private string ownerName;

        public string OwnerName
        {
            get
            {
                return ownerName;
            }
            set
            {
                if(value !=null)
                {
                    ownerName = value;
                }
            }
        }

        public void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
        public void goToLocation(string location)
        {
            //string interpolation!
            Console.WriteLine($"Walk to {location.ToUpper()}" );
            //Console.WriteLine($"Walk to" + { location.ToUpper()};
        }

        public void goToLocation()
        {
            throw new NotImplementedException();
        }
    }
}
