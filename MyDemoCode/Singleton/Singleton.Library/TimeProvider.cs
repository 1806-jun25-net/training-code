using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Library
{
    public class TimeProvider
    {
        public virtual DateTime CurrentTime => DateTime.Now;
        //property with getter no setter, looks like lambda but not one
        // 'expression body syntax'

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

    }
}
