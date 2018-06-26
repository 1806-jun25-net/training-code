using System;
using Animals.Library;

namespace AnimalsConsole
{
    class Program
    {

        static void InteractWithAnimal (IAnimal animal)
        {
            //Console.WriteLine("Hello World!");

            animal.Name = "Fido";
            var hisName = animal.Name;
            Console.WriteLine(hisName);

            animal.MakeSound();

            Dog dog = (Dog)animal;// explicit downcasting

            animal.OwnerName = "Fred";



            Console.ReadLine();



        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            IAnimal animal = new Dog();

            InteractWithAnimal(new Dog());
            InteractWithAnimal(new bird());




            Console.ReadLine();

        }
    }
}
