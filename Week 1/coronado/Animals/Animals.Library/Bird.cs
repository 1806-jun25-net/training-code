using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Library
{
    public class Bird : AAnimal
    {
        public Bird(double wingSpan, string name = "Bob", int value = 4)
        {
            WingSpan = wingSpan;
            Console.WriteLine($"Wing span is {wingSpan}");
            Name = name;
        }

        public Bird() : this(wingSpan: 2, value: 8) // one constructor can call another
        {

        }

        public double WingSpan { get; set; }

        public override string Name { get; set; } = "Chirpy";

        public override String GoAction { get; set; } = "Flying";

        public override void MakeSound()
        {
            Console.WriteLine("Chirp!");
        }
    }
}
