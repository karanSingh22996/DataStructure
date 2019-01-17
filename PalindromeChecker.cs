//-----------------------------------------------------------------------
// <copyright file="PalindromeChecker.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructure
{
    using System;
    using System.Collections;

    /// <summary>
    /// This class will check the string is palindrome or not
    /// </summary>
    public class PalindromeChecker
    {
        /// <summary>
        /// The method check the input string is Palindrome or not
        /// </summary>
        public void IsPalindrome()
        {
            ////creating two queue to compare from starting index and last index
            Queue queue1 = new Queue();
            Queue queue2 = new Queue();
            ////taking user input 
            Console.WriteLine("Enter string to check either it is Palindrome or not");
            string word = Console.ReadLine();
            int flag = 0;
            ////converting given string to char array
            char[] ch = word.ToCharArray();
            ////this itertaion will be in forward direction
            for (int i = 0; i < ch.Length; i++)
            {
                queue1.Enqueue(ch[i]);
            }
            ////this iteration is in reverse direction
            for (int j = ch.Length - 1; j >= 0; j--)
            {
                queue2.Enqueue(ch[j]);
            }
            ////checking if queue is not equal to zero
            while ((queue1.Count != 0) && (queue2.Count != 0))
            {
                ////here deque both and check if both are equal or not
                if ((char)queue1.Dequeue() != (char)queue2.Dequeue())
                {
                    flag++;
                }
            }

            if (flag > 0)
            {
                Console.WriteLine(word + " not is Palindrome");
            }
            else
            {
                Console.WriteLine(word + " is  Palindrome");
            }
        }
    }
}
