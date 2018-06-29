using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Library
{
    public class BlueRobin : Bird
    {
        public BlueRobin() : base(wingSpan: 3) // calls the constructor of the base class explicitly; not needed because a subclass will normally do this anyway
        {

        }

        public override void MakeSound()
        {
            // add extra behavior before
            base.MakeSound();
            // add extra behavior after
        }
    }
}
