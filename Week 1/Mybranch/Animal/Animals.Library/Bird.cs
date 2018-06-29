using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Library
{
    public class Bird : AAnimal
    {
<<<<<<< HEAD
        public Bird(double wingSpan, String name = "Tweety") {
            WingSpan = wingSpan;
            Console.WriteLine($"wig span id {wingSpan}");
            Name = name;
        }
        public Bird():this(2)//one constrctor can call another 
        {
=======
        public Bird(double wingSpan, string name = "Bob", int value = 4)
        {
            WingSpan = wingSpan;
            Console.WriteLine($"Wing span is {wingSpan}");
            Name = name;
        }

        //// one constructor can call another
        //public Bird() : this(wingSpan: 2, value: 8)
        //{

        //}

        public double WingSpan { get; set; }

        public override string Name { get; set; }
>>>>>>> master

        }
        public double WingSpan { get; set; }
        public override string Name { get; set; }
      
        public override string GoAction { get; set; } = "Flying";

        public override void MakeSound()
        {
            Console.WriteLine(value: "Cawww");
        }
    }
}
