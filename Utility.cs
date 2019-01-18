﻿//-----------------------------------------------------------------------
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
        public static bool IsPrime(int n)
        {
           for(int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static ArrayList ListOfPrimes()
        {
            ArrayList list = new ArrayList();
            for(int i = 1; i <= 1000; i++)
            {
                if (IsPrime(i))
                {
                    list.Add(i);
                }
            }
            return list;
        }
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
    }
}
