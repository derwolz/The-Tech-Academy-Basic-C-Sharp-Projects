using System;
using System.Collections.Generic;
using System.Text;

namespace Days_of_the_week
{
    public class Days_of_Week
    {
        public enum WeekDays
        {
            monday, 
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday
        }
        public WeekDays WeekDay { get; set; }
    }
}
