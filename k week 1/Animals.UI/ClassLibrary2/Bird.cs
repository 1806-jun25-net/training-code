using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Library
{
    public class Bird : AAnimal
    {
        public Bird(double wingSpan, string name = "Bob")
        {
            WingSpan = wingSpan;
            Console.WriteLine($"Wing span is {wingSpan}");
            Name = name;
        }

        public double WingSpan { get; set; }
        public override string Name { get; set; }

        public override string GoAction { get; set; } = "Flying";


        public override void MakeSound()
        {
            Console.WriteLine("Cawww");
        }

    }
}
