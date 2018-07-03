using System;
using Animals.Library;

namespace Animals.UI
{
    class Program
    {
        static void InteractWithAnimal(IAnimal animal)
        {
            Dog dog = new Dog();//upcasting [STUDY]
            dog.Name = "Foley";
            var hisName = dog.Name;
            Console.WriteLine(hisName);
            Console.WriteLine("Hello World!");

            //Dog doge = (Dog)Animals;//downcasting explicitly
            dog.GoToLocation("hello");

            dog.MakeSound();
            dog.OwnerName = "Fred";
        }
        static void Main(string[] args)
        {
            IAnimal animal = new Dog();//upcasting implicitly
            InteractWithAnimal(animal);






        }
    }


        
    
}
