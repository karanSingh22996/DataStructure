//-----------------------------------------------------------------------
// <copyright file="MainClass.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructure
{
    using System;

    /// <summary>
    /// Main class is created to execute all the at one compilation
    /// </summary>
    public class MainClass
    {
        /// <summary>
        /// main method will start execution of all the programs by taking user choice
        /// </summary>
        /// <param name="args">string array argument</param>
        public static void Main(string[] args)
        {
            ////declaring and initializing char variable
            char ch = 'y';
            ////do while loop start iterating till the user press yes
            do
            {
                ////asking user to put there choice of program to execute
                Console.WriteLine("Enter 1 to execute Unordered List ");
                Console.WriteLine("Enter 2 to execute Ordered List ");
                Console.WriteLine("Enter 3 to execute Balanced List ");
                Console.WriteLine("Enter 4 to execute Calender Program ");
                Console.WriteLine("Enter 5 to execute prime number in 2D Program ");
                Console.WriteLine("Enter 6 to execute CashCounter Program ");
                Console.WriteLine("Enter 7 to execute PalindromeChecker Program");
                Console.WriteLine("Enter 8 to execute Hashing Program");
                int choice = Convert.ToInt32(Console.ReadLine());
                ////swich case will directly goes to that chosen program and start execution of that program
                switch (choice)
                {
                    case 1:
                        UnOrdered unOrdered = new UnOrdered();
                        unOrdered.UnOrderedOperations();
                        break;
                    case 2:
                        Ordered ordered = new Ordered();
                        ordered.OrderedList();
                        break;
                    case 3:
                        BalancedParenthesis balancedParenthesis = new BalancedParenthesis();
                        balancedParenthesis.BalanceCheck();
                        break;
                    case 4:
                        Calendar calender = new Calendar();
                        calender.DisplayCalender();
                        break;
                    case 5:
                        PrimeNumber primeNumber = new PrimeNumber();
                        Console.Write("\t\t\t\t");
                        for (int x = 1; x <= 25; x++)
                        {
                            Console.Write("col" + x + "\t");
                        }
                        Console.WriteLine("\n");

                        int[,] prime = primeNumber.Prime2DArray(1000);

                        for (int k = 0; k < 10; k++)
                        {
                            Console.WriteLine("range:" + (k * 100 + 1) + "-" + (k * 100 + 100) + "\t");
                            Console.Write(" row" + (k + 1) + "-->\t");
                            for (int l = 0; l < 25; l++)
                            {
                                Console.Write(prime[k, l] + "\t");
                            }
                            Console.WriteLine();
                        }

                        break;
                    case 6:
                        CashCounter cashCounter = new CashCounter();
                        cashCounter.BankOperations();
                        break;
                    case 7:
                        PalindromeChecker palindromeChecker = new PalindromeChecker();
                        palindromeChecker.IsPalindrome();

                        break;
                    case 8:
                        HashingFunction hashingFunction = new HashingFunction(30);
                        string[] elementsToAdd = { "1", "11", "24", "28", "37", "101", "228", "339", "448", "129" };
                        hashingFunction.HashFunction(elementsToAdd, hashingFunction.theArray);
                        hashingFunction.DisplayTheStack();
                        break;
                    default:
                        Console.WriteLine("Provide Data in Range");
                        break;
                }

                Console.WriteLine("Do you want to continue (y/n)");
                ch = Convert.ToChar(Console.ReadLine());
            }
            while (ch != 'n');
        }
    }
}
