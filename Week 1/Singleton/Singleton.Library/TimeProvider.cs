using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Library
{
    public class TimeProvider
    {
<<<<<<< HEAD
        //property with just a getter, no setter
        public virtual DateTime CurrentTime => DateTime.Now;

        //equivilent to this code
        //public static DateTime CurrentTime { get { return DateTime.Now; } }

=======
        // a property with just a getter, no setter
        public virtual DateTime CurrentTime => DateTime.Now;

>>>>>>> origin/master
        protected static TimeProvider s_instance;
        protected static TimeProvider s_current;

        public static void ResetToDefaultInstance()
        {
            Current = s_instance;
        }

        public static TimeProvider Current
        {
            get
            {
                if (s_instance == null)
                {
                    s_instance = new TimeProvider();
                }
<<<<<<< HEAD

=======
>>>>>>> origin/master
                if (s_current == null)
                {
                    s_current = s_instance;
                }
                return s_current;
            }
            set
            {
<<<<<<< HEAD
                if(value != null)
                    s_current = value;
            }
        }

        //only allowed to make one instance of a Singleton class
        //must use private or protected when creating class
=======
                if (value != null)
                {
                    s_current = value;
                }
            }
        }

>>>>>>> origin/master
        protected TimeProvider() { }
    }
}
