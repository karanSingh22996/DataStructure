using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class HashingFunction
    {
        int[] arr;
        public HashingFunction()
        {
            arr = new int[10];
        }
        public int HashKey(int key)
        {
            return key % arr.Length;
        }
        public void Put(int key,int value)
        {
            int hashedKey = HashKey(key);
            if (arr[hashedKey] != 0)
            {
                Console.WriteLine("There already an at position " + hashedKey);
            }
            else
            {
                arr[hashedKey] = value;
            }
        }
        public int get(int key)
        {
            int hashedKey = HashKey(key);
            return arr[hashedKey];
        }
        public void PrintHash()
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]+" ");
            }
        }
    }
}