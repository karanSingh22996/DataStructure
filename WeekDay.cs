using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class WeekDay
    {
       public void CalenderQueue()
       {
            Queue queue = new Queue();
            Console.WriteLine("Enter month");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter year");
            int y = Convert.ToInt32(Console.ReadLine());
            string[] weekDay = { "", "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            int[] month = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            int[,] calender = new int[6, 7];
            int day = Utility.Day(m, y);
            if ((m == 2) && (y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
            {
                month[2] = 29;
            }
        }
    }
}
