using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Library
{
    public class Dog: IAnimal
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

        public string Name { get; set; }

        public string ownerName;//backing field

        public string OwnerName
        {
            get { return ownerName; }
            set { ownerName = value; }
        }

        public void MakeSound()
        {
            Console.WriteLine("wulf");
        }
         public void GoToLocation(string location)
        {
            //string interpolation
            Console.WriteLine("Walk to {location}");
            Console.WriteLine($"Walk to  +{location.ToUpper()}");
        }

    }

}
