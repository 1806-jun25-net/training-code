using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Library
{
    public class Dog : AAnimal
    {
        // field with getter and setter

        //private string name;

        //public string GetName()
        //{
        //    return name;
        //}

        //public void SetName(string newName)
        //{
        //    if (newName != null)
        //    {
        //        name = newName;
        //    }
        //}

        public override string Name { get; set; } // auto-implemented property

        // manually implemented property

        private string ownerName; // backing field

        public string OwnerName
        {
            get
            {
                return "Nick";
            }
            set
            {
                if (value != null)
                {
                    ownerName = value;
                }
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }

        public override string GoAction { get; set; } = "Walking";
    }
}
