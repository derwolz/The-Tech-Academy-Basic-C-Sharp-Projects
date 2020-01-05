using System;
using System.Collections.Generic;

namespace Days_of_the_week
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the day of the week");
                Days_of_Week day = new Days_of_Week();
                string getDay = Console.ReadLine().ToLower();

                
                
                switch (Enum.Parse(typeof(Days_of_Week.WeekDays), getDay)) // checks value and assigns variable according to user input
                {
                    case Days_of_Week.WeekDays.sunday:
                        day.WeekDay = (Days_of_Week.WeekDays)6;
                        break;
                    case Days_of_Week.WeekDays.saturday:
                        day.WeekDay = (Days_of_Week.WeekDays)5;
                        break;
                    case Days_of_Week.WeekDays.friday:
                        day.WeekDay = (Days_of_Week.WeekDays)4;
                        break;
                    case Days_of_Week.WeekDays.thursday:
                        day.WeekDay = (Days_of_Week.WeekDays)3;
                        break;
                    case Days_of_Week.WeekDays.wednesday:
                        day.WeekDay = (Days_of_Week.WeekDays)2;
                        break;
                    case Days_of_Week.WeekDays.tuesday:
                        day.WeekDay = (Days_of_Week.WeekDays)1;
                        break;
                    case Days_of_Week.WeekDays.monday:
                        day.WeekDay = 0;
                        break;
                    default:
                        throw new ArgumentException();

                }

                Console.WriteLine(day.WeekDay.ToString()); // Check to see if worked
            }
            catch (FormatException)
            {
                Console.WriteLine("That is not a day");
            }
            catch (ArgumentException) // This informs the user that they need to enter an actual day
            {
                Console.WriteLine("Please enter an actual day");
            }
            
        }
    }
}
