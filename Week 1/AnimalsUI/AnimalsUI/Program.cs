using System;
using Animals.Library;

namespace AnimalsUI
{
    class Program
    {

        static void InteractWithAnimal(AnimalInterface animal)
        {


        }
        static void Main(string[] args)
        {
            AnimalInterface doggo = new Dog();  //upcasting (implicitly)
            doggo.Name = "Rex";
            var dogName = doggo.Name;

            Console.WriteLine(dogName);

            doggo.MakeSound();

            //downcasting is not implciit, must explicitly cast as below

            //Dog dog = (Dog)doggo;
            //now can use dog specific stuff

            //dog.ownerName = "Phil";
        }
    }
}
