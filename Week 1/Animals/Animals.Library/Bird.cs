using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Library
{
    class Bird : AAnimal
    {
        public override string Name { get; set; }

        public override String GoAction { get; set; } = "Flying";

        public override void MakeSound()
        {
            Console.WriteLine("Chirp!");
        }
    }
}
