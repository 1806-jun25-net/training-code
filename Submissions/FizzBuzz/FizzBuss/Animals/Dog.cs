using System;

namespace Animals.Library
{
    public class bird : IAnimal
    {
        public string Name { get; set; }
        public void MakeASound()
        {
            Console.WriteLine("sound");
        }

    }
    public class Dog : IAnimal
    {

        //property in C#
        public string Name { get; set; }

        public string OwnerName
        {
            get { return OwnerName; }
            set {
                if (value != null)
                {
                    OwnerName = value;
                }

            }
        }

        string IAnimal.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void MakeSound()
        {
            Console.WriteLine("Bark bark");
        }

        public void MakeSOund()
        {
            throw new NotImplementedException();
        }

        void GoToLocation(string locaiton)
        {
            Console.WriteLine($"walk to {locaiton}");
        }
    }
}
