//-----------------------------------------------------------------------
// <copyright file="Utility.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructure
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// utility class contains all the reusable methods
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// return file path of unordered file
        /// </summary>
        /// <returns>string return type</returns>
        public static string FilePathUnordered()
        {
            string path = @"C:\Users\admin\Desktop\Files\karan.txt";
            return path;
        }

        /// <summary>
        /// return file path of ordered file
        /// </summary>
        /// <returns>string return type</returns>
        public static string FilePathOrdered()
        {
            string path = @"C:\Users\admin\Desktop\Files\ordered.txt";
            return path;
        }
        
        /// <summary>
        /// bubble sort is use to sort the integer data
        /// </summary>
        /// <param name="arr">array of integer</param>
        public static void BubbleSortInt(int[] arr)
        {
            for (int i = 0; i < arr.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < arr.GetLength(0) - i; j++)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted Array is:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
        }

        /// <summary>
        /// IsPrime method will check either given number is prime or not
        /// </summary>
        /// <param name="n"> integer </param>
        /// <returns> boolean </returns>
        public static bool IsPrime(int n)
        {
           for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// List of prime method will print the total prime numbers in a range
        /// </summary>
        /// <returns>ArrayList</returns>
        public static ArrayList ListOfPrimes()
        {
            ////Creating arrayList class
            ArrayList list = new ArrayList();
            ////iterating loop till the length of arraylist
            for (int i = 1; i <= 1000; i++)
            {
                ////condition is checked if number is prime or not
                if (IsPrime(i))
                {
                    ////adding all prime number into arraylist
                    list.Add(i);
                }
            }
            ////returning the arraylist as list
            return list;
        }

        /// <summary>
        /// this is storing prime number in linkedlist
        /// </summary>
        /// <returns> linkedlist </returns>
        public static LinkedList<int> ListOfPrimesLinked()
        {
            LinkedList<int> list = new LinkedList<int>();
            for (int i = 1; i <= 1000; i++)
            {
                if (IsPrime(i))
                {
                    list.AddFirst(i);
                }
            }

            return list;
        }

        /// <summary>
        /// here we are calculating which day falls on the given day date and month
        /// </summary>
        /// <param name="month"> month </param>
        /// <param name="year"> year </param>
        /// <returns> integer </returns>
        public static int Day(int month, int year)
        {
            
            int y = (year - (14 - month)) / 12;
            int x = y + (y / 4) - (y / 100) + (y / 400);
            int m = month + (12 * (14 - month) / 12) - 2;
            int d = ((1 + x + (31 * m)) / 12) % 7;
            return d;
        }
    }
}
