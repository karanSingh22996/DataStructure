
namespace DataStructure
{
    using System;
    class BinarySearchTree
    {
        public long Factorial(int n)
        {
            long res = 1;
            while (n > 0)
            {
                res = res * n;
                n--;
            }
            return res;
        }
        public void CountBst(int n)
        {
           long count = Factorial(2 * n) / (Factorial(n + 1)*Factorial(n));
            Console.WriteLine("Number of binary search = " + count);
            //Console.WriteLine("Enter number of test case");
            //int testCase = Convert.ToInt32(Console.ReadLine());
            //int[] test = new int[testCase];
            //Console.WriteLine("Enter " + testCase + " Number");
            //for(int i = 0; i < test.Length; i++)
            //{
            //    test[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int j = 0; j < test.Length; j++)
            //{
            //    int count = 0;
            //    count = Factorial(test[2 * j+1]) / (Factorial(test[(j+1) + 1]) * Factorial(test[j+1]));
            //    Console.WriteLine("Number of binary search Tree for " + j + " = " + count);
            //}
        }
       
    }
}
