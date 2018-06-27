using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Library
{
    public class Dog : AnimalInterface
    {

        // getter and setter methods? we don't do that? C SHARP IS BETTER
        //private string name;

        //public string getName()
        //{
        //return name;
        //}

        //public void SetName(string newName)
        //{
        //name = newName;

        //}


        //USE PROPERTIES INSTEAD. Same code as above but shortened and nicer. 

        public string Name { get; set; }
        public string ownerName;


        public string getSetOwnerName
        {
        get { return ownerName; }
        set
            {
                if(value != null)
                ownerName = value;

            }

        }

        public void MakeSound()
        {
            Console.WriteLine("bork");

        }

        public void move (string location)
        {
            //string interpolation?!
            //console.writeline("walk to" + location);

            Console.WriteLine($"Walk to {location.ToUpper()}");
        }

    }
}
