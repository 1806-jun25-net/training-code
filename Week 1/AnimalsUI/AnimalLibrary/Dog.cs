using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Library
{
    public class Dog : AAnimal
    {
        private string ownerName;

        public string OwnerName
        {
            get{ return ownerName;  }
            set
            {
                if (value  != null)
                {
                    ownerName = value;
                }   
            }
        }

        public override string Name { get; set; }
        public override object GoAction { get; set; } = "Run";

        public override void MakeSound()
        {
            Console.WriteLine("bark");
        }
    }
}
