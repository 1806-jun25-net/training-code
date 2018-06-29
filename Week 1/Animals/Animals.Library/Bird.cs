using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Library
{
    public class Bird : AAnimal
    {
        public Bird(double wingSpan, String name = "Tweety") {
            WingSpan = wingSpan;
            Console.WriteLine($"wig span id {wingSpan}");
            Name = name;
        }
        public Bird():this(2)//one constrctor can call another 
        {

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
