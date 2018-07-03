using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Library
{
    public class History
    {
        private readonly Stack<DateTime> records = new Stack<DateTime>();
        
        /// <summary>
        /// make a new record at the current time: "///"
        /// </summary>
        public void Record()
        {
            records.Push(TimeProvider.Current.CurrentTime);//[Stack]cannot index, can only add subtract from top
            //pushes current time to records
        }
        /// <summary>
        /// Check if the most recent record is older than one hour
        /// </summary>
        /// <returns>returns true if newest record is too old</returns>
        public bool IsOutdated()
        {
            DateTime newestRecord = records.Peek();
            DateTime currentTime = TimeProvider.Current.CurrentTime;
            TimeSpan diff = currentTime - newestRecord;
            return diff >= TimeSpan.FromHours(1);//FromHours is a factory 
            //method that does job of a constructor
            //return basically checks if diff
            //is older than an hour
        }
    }
}
