using System;
using Animals.Library;

namespace Animals.UI
{
    class Program
    {

        static void InteractWithAnimal(IAnimal animal)
        {
            // get and set through property
            animal.Name = "Fido";
            var hisName = animal.Name;
            Console.WriteLine(hisName);
            animal.MakeSound();


            // error: can't access what isn't define on IAnimal
            //animal.OwnerName = "Fred";

            Dog dog = (Dog)animal; // downcasting (explicitly)
            dog.OwnerName = "Fred";
        }

        static void Main(string[] args)
        {
            IAnimal animal = new Dog(); // upcasting (implicitly)

            InteractWithAnimal(new Dog()); // upcasting
            InteractWithAnimal(new Dog());
            InteractWithAnimal(new Dog());


            Console.ReadLine();
        }
    }
}
