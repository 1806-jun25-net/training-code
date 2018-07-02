using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Library
{
    public class History
    {
        //Stack is a more restricted version of List
        private readonly Stack<DateTime> records = new Stack<DateTime>();

        /// <summary>
        /// make a new record at the current time
        /// </summary>

        public void Record()
        {
            records.Push(TimeProvider.Current.CurrentTime); //gives you the only allowed instance of that class
        }

        /// <summary>
        /// Check if the most recent record is older than one hour.
        /// </summary>
        /// <returns>true if the newest record is too old</returns>

        public bool IsOutdated()
        {
            DateTime newestRecord = records.Peek();
            DateTime currentTime = TimeProvider.Current.CurrentTime;
            TimeSpan diff = currentTime - newestRecord; //returns a timespan strut
            return diff >= TimeSpan.FromHours(1);
        }
    }
}
