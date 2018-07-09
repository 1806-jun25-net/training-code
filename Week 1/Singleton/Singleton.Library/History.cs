using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Library
{
    public class History
    {
<<<<<<< HEAD
        //Stack is a more restricted version of List
        private readonly Stack<DateTime> records = new Stack<DateTime>();

        /// <summary>
        /// make a new record at the current time
        /// </summary>

        public void Record()
        {
            records.Push(TimeProvider.Current.CurrentTime); //gives you the only allowed instance of that class
=======
        private readonly Stack<DateTime> records = new Stack<DateTime>();

        /// <summary>
        /// Make a new record at the current time.
        /// </summary>
        public void Record()
        {
            records.Push(TimeProvider.Current.CurrentTime);
>>>>>>> origin/master
        }

        /// <summary>
        /// Check if the most recent record is older than one hour.
        /// </summary>
        /// <returns>true if the newest record is too old</returns>
<<<<<<< HEAD

=======
>>>>>>> origin/master
        public bool IsOutdated()
        {
            DateTime newestRecord = records.Peek();
            DateTime currentTime = TimeProvider.Current.CurrentTime;
<<<<<<< HEAD
            TimeSpan diff = currentTime - newestRecord; //returns a timespan strut
=======
            TimeSpan diff = currentTime - newestRecord;
>>>>>>> origin/master
            return diff >= TimeSpan.FromHours(1);
        }
    }
}
