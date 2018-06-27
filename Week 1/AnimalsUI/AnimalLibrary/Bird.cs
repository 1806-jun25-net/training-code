using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Library
{
    public class Bird : AAnimal
    {
        public override string Name { get; set; }

        public override object GoAction { get; set; } = "Flying";

        public override void MakeSound()
        {
            Console.WriteLine("sing");
        }
    }
}
