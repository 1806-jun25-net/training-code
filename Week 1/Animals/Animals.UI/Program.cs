using System;
using Animals.Library;
using Animas.Library;

namespace Animals.UI
{
    class Program
    {
        static void InteractWithAnimal(IAnimal animal)
        {
           

            Dog dog = new Dog();
            animal.Name = "Fido";
            var hisName = animal.Name;
            Console.WriteLine(hisName);

            animal.MakeSound();

            animal.OwnerName = "Fred";
            dog = (Dog)animal;//downcasting (explicitly)

            
        }

        static void Main(string[] args)
        {
            IAnimal animal = new Dog(); //upcasting
            InteractWithAnimal(new Dog());
            InteractWithAnimal(new Bird());
            Console.ReadLine();
        }
    }
}
