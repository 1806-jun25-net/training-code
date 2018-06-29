using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Library
{
    public class TimeProvider
    {
        public virtual DateTime CurrentTime => DateTime.Now; //Shorthand way of writing a getter. A property with just a getter
                                                     //equivalent to public static DateTime CurrentTime2 {get {return DateTime.Now; } }

        protected static TimeProvider s_instance;

        public static TimeProvider Instance
        {
            get
            {
                if (s_instance == null)
                {
                    s_instance = new TimeProvider();
                }
                return s_instance;
            }
            set
            {
                if (value != null)
                {
                    s_instance = value;
                }
            }
        }

        protected TimeProvider() { }

    }
}
