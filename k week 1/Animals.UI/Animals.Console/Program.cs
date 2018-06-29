using System;
using Animals.Library;

namespace Animals.UI
{
    class Program
    {
        static void InteractWithAnimal(IAnimal animal)
        {
            //get and set through property
            IAnimal dog = new Dog(); //upcasting
            animal.Name = "Fido";
            var hisName = animal.Name;
            Console.WriteLine(hisName);

            animal.MakeSound();

            //error: can't access what isn't defined on IAnimal
            //animal.OwnerName = "Fred";

            Dog dog = (Dog)animal; //Downcasting explicitly
            dog.OwnerName = "Fred";
        }

        static void Main(string[] args)
        {
            //get and set through property
            IAnimal animal = new Dog(); //upcasting

            InteractWithAnimal(new Dog());
            InteractWithAnimal(new Bird());
        }
    }
}