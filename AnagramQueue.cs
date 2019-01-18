using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class AnagramQueue
    {
        public void QueueAnagram()
        {
            Queue queue = new Queue();
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
