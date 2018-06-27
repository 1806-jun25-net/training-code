using System;
using System.Collections.Generic;
using System.Text;

namespace Animas.Library
{
    public class Bird : IAnimal
    {
        public string Name { get ; set; }
        public string OwnerName { get ; set ; }

        public  void MakeSound()
        {
            Console.WriteLine("cawl");
            //throw new NotImplementedException();
        }


        public void goToLocation()
        {
            throw new NotImplementedException();
        }
    }
}
