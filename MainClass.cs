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
            try
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
                    Console.WriteLine("Enter 9 to execute Number of Binary search Program");
                    Console.WriteLine("Enter 10 to execute anagram using stack Program");
                    Console.WriteLine("Enter 11 to execute anagram using Queue Program");
                    Console.WriteLine("Enter 12 to execute weekday in Queue Program");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    ////swich case will directly goes to that chosen program and start execution of that program
                    switch (choice)
                    {
                        case 1:
                            UnOrdered unordered = new UnOrdered();
                            unordered.UnOrderedOperations();
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
                            ////for (int x = 1; x <= 25; x++)
                            ////{
                            ////    Console.Write("col" + x + "\t");
                            ////}

                            Console.WriteLine("\n");

                            int[,] prime = primeNumber.Prime2DArray(1000);

                            for (int k = 0; k < 10; k++)
                            {
                                Console.WriteLine("range:" + ((k * 100) + 1) + "-" + ((k * 100) + 100) + "\t");
                                Console.Write(" row" + (k + 1) + "-->\t");
                                for (int l = 0; l < 25; l++)
                                {
                                    if (prime[k, l] > 0)
                                    {
                                        Console.Write(prime[k, l] + "\t");
                                    }
                                    else
                                    {
                                        Console.Write(" " + "\t");
                                    }
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
                            HashingFunction hashingFunction = new HashingFunction();
                            int[] hash = { 31, 45, 87, 90, 220, 555, 121, 190, 196 };
                            for (int i = 0; i < hash.Length; i++)
                            {
                                hashingFunction.Put(hash[i], i);
                            }

                            hashingFunction.PrintHash();
                            Console.WriteLine(hashingFunction.Get(3));
                            break;
                        case 9:
                            BinarySearchTree bst = new BinarySearchTree();
                            Console.WriteLine("Enter number");
                            int binary = Convert.ToInt32(Console.ReadLine());
                            bst.CountBst(binary);
                            break;
                        case 10:
                            AnagramOfPrimes anp = new AnagramOfPrimes();
                            anp.Anagram();
                            break;
                        case 11:
                            AnagramQueue anagramQueue = new AnagramQueue();
                            anagramQueue.QueueAnagram();
                            break;
                        case 12:
                            CalenderQueue weekDay = new CalenderQueue();
                            weekDay.CalenderPrinting();
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }        
    }
}
