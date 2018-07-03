using Singleton.Library;
using System;

namespace Singleton.Test
{
    public class TwoHoursAgoProvider: TimeProvider
    {
        public override DateTime CurrentTime => 
            base.CurrentTime - TimeSpan.FromHours(2);
    }
}
