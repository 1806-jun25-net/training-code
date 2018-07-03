using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Library
{
    class BlueRobin: Bird
    {
        public BlueRobin(): base(4)//subclass will always call a costructor
                                   //of you dont explicitly call one
        {

        }

        public override void MakeSound()
        {
            //add extra behavior before
            base.MakeSound();
            //add extra behavior after
        }
            
       
    }
    
}
