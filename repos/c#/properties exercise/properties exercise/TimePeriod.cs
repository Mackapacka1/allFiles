using System;
using System.Collections.Generic;
using System.Text;

namespace properties_exercise
{
    class TimePeriod
    {
    
        private int seconds;

        public int Seconds
        {
            get
            {
                return seconds;
            }
            set { seconds = value; }

        }

        public float Minutes
        {
            get
            {
                return seconds / 60;
            }

        }

        public float Hours
        {
            get
            {
                return seconds / 3600;
            }

        }

        public float Days
        {
            get
            {
                return seconds / 86400;
            }
            
        }
        public float Weeks
        {
            get
            {
                return seconds / 604800;
            }

        }
        public float Months
        {
            get
            {
                return seconds / 2628000;
            }

        }
    }

   
}
