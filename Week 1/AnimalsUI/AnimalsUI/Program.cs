using System;
using Animals.Library;

namespace Animals.UI
{
    class Program
    {
        static void InteractWithAnimal(IAnimal animal)
        {
            animal.Name = "Fido";
            var hisName = animal.Name;
            Console.WriteLine(hisName);

            animal.MakeSound();

            // error: can't access what isn't defined on IAnimal
            //animal.OwnerName = "Fred";

            Dog dog = (Dog)animal; // downcasting (explicitly)
            dog.OwnerName = "Fred";
        }

        static void Main(string[] args)
        {
            IAnimal animal = new Dog();
            InteractWithAnimal(animal);
        }
    }
}
