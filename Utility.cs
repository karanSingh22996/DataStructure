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
            string path = null;
            try
            {
                path = @"C:\Users\admin\Desktop\Files\karan.txt";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return path;
        }

        /// <summary>
        /// return file path of ordered file
        /// </summary>
        /// <returns>string return type</returns>
        public static string FilePathOrdered()
        {
            string path = null;
            try
            {
                path = @"C:\Users\admin\Desktop\Files\ordered.txt";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return path;
        }

        /// <summary>
        /// bubble sort is use to sort the integer data
        /// </summary>
        /// <param name="arr">array of integer</param>
        public static void BubbleSortInt(int[] arr)
        {
            try
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// IsPrime method will check either given number is prime or not
        /// </summary>
        /// <param name="n"> integer </param>
        /// <returns> boolean </returns>
        public static bool IsPrime(int n)
        {
            try
            {
                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return true;
        }

        /// <summary>
        /// List of prime method will print the total prime numbers in a range
        /// </summary>
        /// <returns> ArrayList </returns>
        public static ArrayList ListOfPrimes()
        {
            ////Creating arrayList class
            ArrayList list = new ArrayList();
            try
            {
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
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            ////returning the arraylist as list
            return list;
        }

        /// <summary>
        /// this is storing prime number Linked List
        /// </summary>
        /// <returns> Linked List </returns>
        public static LinkedList<int> ListOfPrimesLinked()
        {
            LinkedList<int> list = new LinkedList<int>();
            try
            {
                for (int i = 1; i <= 1000; i++)
                {
                    if (IsPrime(i))
                    {
                        list.AddFirst(i);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
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
            int d = 0;
            try
            {
                int y0 = year - ((14 - month) / 12);
                int x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
                int m0 = month + (12 * ((14 - month) / 12)) - 2;
                int d0 = (01 + x + (31 * m0 / 12)) % 7;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return d;
        }
    }
}
