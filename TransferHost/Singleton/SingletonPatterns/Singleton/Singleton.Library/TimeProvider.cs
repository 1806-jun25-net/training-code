using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Library
{
   public class TimeProvider
    {
        public virtual DateTime CurrentTime => DateTime.Now;//another way to write a getter
       //now CurrentTime returns DateTime.Now
        //public static DateTime CurrentTime2;
       

        protected static TimeProvider s_instance;//instance of
                                                 //this here class
                                                 //has none of the info that
                                                 //comes in Constructor

        protected static TimeProvider s_current;//same
        //as above

        public static void ResetToDefaultInstance()
        {
            Current = s_instance;//Current property 
                                 //takes in s_instance and then puts it 
                                 //through Singleton pattern
                                 //of safety
        }

        public static TimeProvider Current
        {
            get//SINGLETON EXAMPLE!!!!!!!
            {
                if (s_instance== null)
                {
                    s_instance = new TimeProvider();
                }
                if(s_current == null)
                {
                    s_current = s_instance;
                }
                return s_current; ;
            }
            set
            {
                if(value != null)
                {
                    s_current = value;//Singleton measures
                                      // to make sure no null
                }
                
            }
         }

        protected TimeProvider() { }
        
    }
}
