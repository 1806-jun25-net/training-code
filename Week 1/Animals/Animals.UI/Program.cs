using System;
using Animals.Library;
<<<<<<< HEAD
using Animas.Library;
=======
>>>>>>> master

namespace Animals.UI
{
    class Program
    {
        static void InteractWithAnimal(IAnimal animal)
        {
<<<<<<< HEAD
           

            Dog dog = new Dog();
=======
            // get and set through property
>>>>>>> master
            animal.Name = "Fido";
            var hisName = animal.Name;
            Console.WriteLine(hisName);

            animal.MakeSound();

<<<<<<< HEAD
            animal.OwnerName = "Fred";
            dog = (Dog)animal;//downcasting (explicitly)

            
=======
            // error: can't access what isn't defined on IAnimal
            //animal.OwnerName = "Fred";

            //animal = new Bird();

            //Dog dog = (Dog)animal; // downcasting (explicitly)
            //dog.OwnerName = "Fred";
>>>>>>> master
        }

        static void Main(string[] args)
        {
<<<<<<< HEAD
            IAnimal animal = new Dog(); //upcasting
            InteractWithAnimal(new Dog());
            InteractWithAnimal(new Bird());
            Console.ReadLine();
=======
            IAnimal animal = new Dog(); // upcasting (implicitly)

            InteractWithAnimal(new Dog());
            InteractWithAnimal(new Bird());
>>>>>>> master
        }
    }
}
