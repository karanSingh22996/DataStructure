//-----------------------------------------------------------------------
// <copyright file="HashingFunction.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructure
{
    using System;

    /// <summary>
    /// Hashing class store the array on the basis of their mod
    /// </summary>
    public class HashingFunction
    {
        /// <summary>
        /// declaring instance of array
        /// </summary>
        private int[] arr;

        /// <summary>
        /// hashing constructor will initialize instance array
        /// </summary>
        public HashingFunction()
        {
            ////initiliazing array
            this.arr = new int[10];
        }

        /// <summary>
        /// integer Hashkey method calculate the element by dividing them 11
        /// </summary>
        /// <param name="key"> integer key </param>
        /// <returns> integer </returns>
        public int HashKey(int key)
        {
            return key % 11;
        }

        /// <summary>
        /// put method is defined here the put data inside for hashing using key value pair
        /// </summary>
        /// <param name="key"> key </param>
        /// <param name="value"> value </param>
        public void Put(int key, int value)
        {
            ////calling the method hashedkey and storing inside integer variable
            int hashedKey = this.HashKey(key);
            ////checking condition if array is occupied or not
            if (this.arr[hashedKey] != 0)
            {
                Console.WriteLine("There already an at position " + hashedKey);
            }
            else
            {
                ////assingning the valu in array
                this.arr[hashedKey] = value;
            }
        }

        /// <summary>
        /// get key will return unique key value
        /// </summary>
        /// <param name="key">integer key</param>
        /// <returns>integer</returns>
        public int Get(int key)
        {
            ////assigning the return value of hashkey method in hashed key variable
            int hashedKey = this.HashKey(key);
            ////returning the array of hashed key but value returning in one at a time
            return this.arr[hashedKey];
        }

        /// <summary>
        /// print hash method will print the arrange data sorted on the basis of their module
        /// </summary>
        public void PrintHash()
        {
            for (int i = 0; i < this.arr.Length; i++)
            {
                Console.WriteLine(this.arr[i] + " ");
            }
        }
    }
}