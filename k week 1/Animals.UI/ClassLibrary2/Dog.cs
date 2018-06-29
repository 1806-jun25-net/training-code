using System;

namespace Animals.Library
{
    public class Dog : IAnimal
    {
        //Field with getters and setter

        private string name;

        public string GetName()
        {
            return name;
        }

        public void SetName(string newName)
        {
            if (newName != null)
            {
                name = newName;
            }
        }

        public string Name { get; set; } //auto-implemented property

        private string ownerName;

        public string OwnerName()
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
            Console.WriteLine($"Walk to {location}");
        }
    }
}
