//-----------------------------------------------------------------------
// <copyright file="PalindromeChecker.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructure
{
    using System;

    /// <summary>
    /// This class will check the string is palindrome or not
    /// </summary>
   public class PalindromeChecker
   {
        /// <summary>
        /// The method check the input string is Palindrome or not
        /// </summary>
        /// <param name="st"> string </param>
        /// <returns> boolean </returns>
        public bool IsPalindrome(string st)
        {
          
            ////Declaring char array and storing inside that
            char[] ch = st.ToCharArray();
            ////i is first index of our array
            int i = 0;
            ////l is the last index of our array
            int l = ch.Length - 1;
            ////here while loop check by comparing first and last element either they are same or not
            ////if same it will return true else return false
            while (i < l && ch[i++] == ch[l--]);  
            return i >= l;
        }
    }
}
