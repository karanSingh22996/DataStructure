//-----------------------------------------------------------------------
// <copyright file="AnagramOfPrimes.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructure
{
    using System;
    using System.Collections;

    /// <summary>
    /// the class is storing all the prime number which are anagrams
    /// </summary>
    public class AnagramOfPrimes
    {
        /// <summary>
        /// anagram method will add all prime number which are anagram in stack
        /// </summary>
        public void Anagram()
        {
            ////creating stack object
            Stack stack = new Stack();
            ////assignig the primenumber in arraylist
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
                        stack.Push(number1);
                        stack.Push(number2);
                    }
                }
            }

            Console.WriteLine("List of anagram in range 0-1000 which are prime:");
            ////enhanced for loop for printing till the last element of the run
            foreach (string ana in stack)
            {
                Console.Write(ana + " ");
            }

            Console.ReadLine();
        }
    }
}
