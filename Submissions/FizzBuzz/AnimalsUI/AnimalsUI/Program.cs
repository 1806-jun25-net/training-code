using Animals.Library;
using System;

namespace AnimalsUI
{
    class Program
    {

        static void InteractWithAnimal(IAnimal animal)
        {
            
            //get and set throug property
            animal.Name = "Belito";
            var hisName = animal.Name;
            Console.WriteLine(hisName);

            animal.MakeSound();
                //Dog dog = (Dog)animal; // downcasting (explicit)
        }

        static void Main(string[] args)
        {
            IAnimal animal = new Dog();

            // error cant acces whats not define on Ianmal
            //Dog.ownername = "fred";
            InteractWithAnimal(new Dog());

            
        }
    }
}
