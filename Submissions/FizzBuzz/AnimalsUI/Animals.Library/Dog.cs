using System;

namespace Animals.Library
{
    public class Dog : IAnimal
    {
       

        public string Name { get; set; }

        public void MakeSound()
        {
            Console.WriteLine("WOOOOF!!");
        }

        public void GoToLocation(string location)
        {
            Console.WriteLine($"Walk to {location}");
        }


        private string ownerName;

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
    }
}
