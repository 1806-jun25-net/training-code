using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Library
{
    class BlueRobin : Bird
    {
        public BlueRobin() : base(wingSpan: 4)
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
