//-----------------------------------------------------------------------
// <copyright file="BinarySearchTree.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructure
{
    using System;

    /// <summary>
    /// this class will how many binary tree are possible with the n nodes
    /// </summary>
    public class BinarySearchTree
    {
        /// <summary>
        /// Factorial method calculate the factorial of a number
        /// </summary>
        /// <param name="n"> integer number </param>
        /// <returns> long return type </returns>
        public long Factorial(int n)
        {
            ////declaring res variable to store the factorial results
            long res = 1;
            try
            {
                ////iterating while loop till number is greater than zero
                while (n > 0)
                {
                    ////multiplying and storing factorial value in res variable
                    res = res * n;
                    ////on every iterating decrementing value of n to n-1
                    n--;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            ////returning res
            return res;
        }

        /// <summary>
        /// count binary search tree method will calculate the number of binary search tree
        /// </summary>
        /// <param name="n"> integer number </param>
        public void CountBst(int n)
        {
            try
            {
                long count = this.Factorial(2 * n) / (this.Factorial(n + 1) * this.Factorial(n));
                Console.WriteLine("Number of binary search = " + count);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Binary method will take input from user and print the number of binary tree.
        /// </summary>
        public void Binary()
        {
            BinarySearchTree bst = new BinarySearchTree();
            Console.WriteLine("Enter number");
            int binary = Convert.ToInt32(Console.ReadLine());
            bst.CountBst(binary);
        }
    }
}
