using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Library
{
    // Singleton class pattern
    public class TimeProvider
    {
        // a property with just a getter, no setter
        public virtual DateTime CurrentTime => DateTime.Now;

        private static TimeProvider s_instance;
        private static TimeProvider s_current;

        public static void ResetToDefaultInstance()
        {
            Current = s_instance;
        }

        public static TimeProvider Current
        {
            get
            {
                // s_instance is only instantiated once
                if (s_instance != null)
                {
                    s_instance = new TimeProvider();
                }
                if (s_current == null)
                {
                    s_current = s_instance;
                }
                return s_current;
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
