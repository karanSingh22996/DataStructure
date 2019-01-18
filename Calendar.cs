//-----------------------------------------------------------------------
// <copyright file="Calendar.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructure
{
    using System;

    /// <summary>
    /// the class will print the entire month's calendar on the basis of user input
    /// </summary>
    public class Calendar
    {
        /// <summary>
        /// Given the month, day, and year, return which day
        /// of the week it falls on according to the Gregorian calendar.
        /// For month, use 1 for January, 2 for February, and so forth.
        /// Returns 0 for Sunday, 1 for Monday, and so forth.
        /// </summary>
        /// <param name="month">month</param>
        /// <param name="day">day</param>
        /// <param name="year">year</param>
        /// <returns>return integer</returns>
        public int Day(int month, int year)
        {
            int day = 1;
            int y = (year - (14 - month)) / 12;
            int x = y + (y / 4) - (y / 100) + (y / 400);
            int m = month + (12 * (14 - month) / 12) - 2;
            int d = ((day + x + (31 * m)) / 12) % 7;
            return d;
        }

        /// <summary>
        /// return true if the given year is a leap year
        /// </summary>
        /// <param name="year">year</param>
        /// <returns>true or false</returns>
        public bool IsLeapYear(int year)
        {
            if ((year % 4 == 0) && (year % 100 != 0))
            { 
                return true;
            }

            if (year % 400 == 0)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// display calendar by taking user input month and year
        /// </summary>
        public void DisplayCalender()
        {
            Console.WriteLine("Enter month");
            int month = Convert.ToInt32(Console.ReadLine()); // month (Jan = 1, Dec = 12)
            Console.WriteLine("Enter year");
            int year = Convert.ToInt32(Console.ReadLine());     // year

            //// months[i] = name of month i
            //// leave empty so that months[1] = "January"
            string[] months =
            {
            "",                               
            "January", "February", "March",
            "April", "May", "June",
            "July", "August", "September",
            "October", "November", "December"
            };
            //// days[i] = number of days in month i
            int[] days =
            {
            0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31
            };
            //// check for leap year
            if (month == 2 && this.IsLeapYear(year))
            {
                days[month] = 29;
            }
            //// print calendar header
            Console.WriteLine("   " + months[month] + "  " + year);
            Console.WriteLine(" S  M Tu  W Th  F  S");
            //// starting day
            int d = this.Day(month, year);
            //// print the calendar
            for (int i = 0; i < d; i++)
            { 
                Console.Write("  ");
            }

            for (int i = 1; i <= days[month]; i++)
            {
                Console.Write(i + " ");
                if (((i + d) % 7 == 0) || (i == days[month]))
                { 
                    Console.WriteLine();
                }
            }
        }
    }
}
