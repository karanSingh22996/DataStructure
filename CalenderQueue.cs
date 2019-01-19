//-----------------------------------------------------------------------
// <copyright file="CalenderQueue.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructure
{
    using System;
    using System.Collections;

    /// <summary>
    /// This class is use to store the day of the week in queue
    /// </summary>
    public class CalenderQueue
    {
        /// <summary>
        /// Calendar printing method in adding day of the week in queue
        /// </summary>
        public void CalenderPrinting()
        {
            try
            {
                ////creating the object of a queue
                Queue queue1 = new Queue();
                ////creating the object of a queue
                Queue queue2 = new Queue();
                Console.WriteLine("enter Month");
                ////taking the user input  month of his choice
                int month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter year");
                ////taking the user input year of his choice
                int year = Convert.ToInt32(Console.ReadLine());
                ////Initilizing and declaring the array of days which contains number of days in a month       
                int[] days = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                ////calling the day method from utility class
                int startDate = Utility.Day(year, month);
                ////this condition is used for checking wheter the given year is a leap year, if it is a leap year we will replace 28 days with 29 days
                if ((month == 2) && (year % 4 == 0))
                {
                    days[2] = 29;
                }

                int date = 1;
                ////this loop is used for storing the dates in to a queue
                for (int i = startDate; i < 7; i++)
                {
                    queue2.Enqueue(date);
                    date++;
                }
                ////this is used for storing the queue in to a queue2 that is created at starting of the program
                queue1.Enqueue(queue2);
                ////creating new object of queue2
                queue2 = new Queue();
                ////this loop will continue until the days in a month is equal to the days that we are storing in to the queue
                while (days[month] >= date)
                {
                    ////this is used for storing the number of day in a week to a queue
                    for (int i = 0; i < 7; i++)
                    {
                        ////this condition is used to check whether the date that we are incrumenting is equal to the number of days in a month
                        if (date <= days[month])
                        {
                            ////adding date into the queue
                            queue2.Enqueue(date);
                            ////incrementing the date values
                            date++;
                        }
                    }
                    ////adding queue2 in queue1
                    queue1.Enqueue(queue2);
                    ////creating in object of queue
                    queue2 = new Queue();
                }

                Console.WriteLine("sun \tmon \ttue \twed \tthr \tfri \tsat");
                ////this loop is used for printing the spaces before the start date i.e before 1st
                for (int i = 1; i <= startDate; i++)
                {
                    Console.Write("\t");
                }
                ////this loop is used for checking whether the quequ is empty are not
                while (queue1.Count != 0)
                {
                    ////dequeue the queue
                    Queue queue = (Queue)queue1.Dequeue();
                    ////this for loop is used to print the values in a quequ
                    foreach (int obj in queue)
                    {
                        Console.Write(obj + "\t");
                    }

                    Console.WriteLine();
                }

                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
