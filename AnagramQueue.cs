//-----------------------------------------------------------------------
// <copyright file="AnagramQueue.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructure
{
    using System;
    using System.Collections;

        /// <summary>
        /// Anagram queue class will store all the prime number which are anagram
        /// </summary>
    public class AnagramQueue
    {
        /// <summary>
        /// queueAnagram method stores all the prime numbers which are prime and also anagram in queue
        /// </summary>
        public void QueueAnagram()
        {
            ////creating object of queue
            Queue queue = new Queue();
            ////assigning the list of number return by listOfPrimes method into an arraylist
            ArrayList list = Utility.ListOfPrimes();
            Console.WriteLine("printing the prime numbers that are anagram");
            ////nested for loop is used for taking the prime numbers from the array list
            for (int i = 0; i < list.Count; i++)
            {
                ////converting number int to string
                string number1 = list[i] + string.Empty;
                ////converting string number in to character array
                char[] numberInArray1 = number1.ToCharArray();
                Array.Sort(numberInArray1);
                ////converting character array in to string
                string original1 = new string(numberInArray1);
                for (int j = i + 1; j < list.Count; j++)
                {
                    ////converting number int to string
                    string number2 = list[j] + string.Empty;
                    ////converting string number in to character array
                    char[] numberInArray2 = number2.ToCharArray();
                    Array.Sort(numberInArray2);
                    ////converting character array in to string
                    string original2 = new string(numberInArray2);
                    if (original1.Equals(original2))
                    {
                        queue.Enqueue(number1);
                        queue.Enqueue(number2);
                    }
                }
            }

            Console.WriteLine("List of anagram in range 0-1000 which are prime:");
            foreach (string ana in queue)
            {
                Console.Write(ana + " ");
            }

            Console.ReadLine();
        }
    }
}
