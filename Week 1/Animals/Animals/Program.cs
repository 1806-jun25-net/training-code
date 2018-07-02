using System;
using Animals.Library;
using AnimalsLibrary;

namespace Animals
{
    class Program
    {
        static void InteractWithAnimal(AAnimal animals)
        {

        }
        static void Main(string[] args)
        {
            IAnimals animal = new Puppy(); //upcasting

            animal.Name = "Ruff";
            var hisName = animal.Name;
            string location = "Home";

            Console.WriteLine(hisName);

            animal.MakeSound();
            animal.GoToLocation(location);

            //OwnerName isn't defined yet so next line will not work
            //animal.OwnerName = "Bill";

            Puppy puppy = (Puppy)animal; //downcasting

        }
    }
}
