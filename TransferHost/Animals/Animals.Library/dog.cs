using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Library
{
    public class Dog : IAnimal
    {
        

        public string Name { get; set; }//auto-implemented property

        private string ownerName;

        public string OwnerName
        {
            get { return ownerName; }
            set
            {
                if(value != null)
                {
                    ownerName = value;
                }
            }
        }

        public void MakeSound()
        {
            Console.WriteLine("BowWow");
        }

        public void GoToLocation(string Location)
        {
            Console.WriteLine("we are here: "+Location);
        }
        



    }
}
