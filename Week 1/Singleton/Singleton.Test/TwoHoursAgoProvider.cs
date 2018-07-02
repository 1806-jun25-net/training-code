using Singleton.Library;
using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Test
{
    public class TwoHoursAgoProvider : TimeProvider
    {
        //base reffers to the base class
        public override DateTime CurrentTime => base.CurrentTime - TimeSpan.FromHours(2);
    }
}
