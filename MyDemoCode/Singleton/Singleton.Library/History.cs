using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Library
{
    class History
    {
        private readonly Stack<DateTime> records = new Stack<DateTime>();
        /// <summary>
        /// XML doccumentation by using /*3  for auto documentaion generation
        /// 
        /// make a new record at current time
        /// </summary>
        public void Record()
        {
            records.Push(TimeProvider.Instance.CurrentTime);
        }
        /// <summary>
        /// Check if most recent is older than 1 hour
        /// </summary>
        /// <returns>true if newest record is too old, otherwise false</returns>
        public bool IsOutdated()
        {
            DateTime newestRecord = records.Peek();
            DateTime currentTime = TimeProvider.Instance.CurrentTime;
            TimeSpan diff = currentTime - newestRecord;
            return diff >= TimeSpan.FromHours(1);  // >= as greater than or equal to
        }
    }
}
