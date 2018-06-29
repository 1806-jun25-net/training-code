using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Library
{
<<<<<<< HEAD
    class BlueRobin : Bird
    {
        public BlueRobin() : base (wingSpan: 3)
        {

=======
    public class BlueRobin : Bird
    {
        public BlueRobin() : base(wingSpan: 3)
        {
        }

        public override void MakeSound()
        {
            // add extra behavior before
            base.MakeSound();
            // add extra behavior after
>>>>>>> master
        }
    }
}
