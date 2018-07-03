using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Library
{
    public class Bird:AAnimals
    {
        public Bird(double Wingspan, string name = "Bob")
        {
            WingSpan = Wingspan;
            Console.WriteLine($"Wing span is {WingSpan}");
            Name = name;
        }

        //public Bird() : this(double WingSpan: 2)
        //{

        //}

        public double WingSpan { get; set; }

        public override string Name { get; set; }

        public override string GoAction { get; set; } = "Flying";

        public override void MakeSound()
        {
            Console.WriteLine("Cawww");
        }
    }
}
