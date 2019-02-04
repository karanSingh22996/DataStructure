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
                    Console.WriteLine("Enter 8 to execute Anagram in 2d Program");
                    Console.WriteLine("Enter 9 to execute Number of Binary search Program");
                    Console.WriteLine("Enter 10 to execute anagram using stack Program");
                    Console.WriteLine("Enter 11 to execute anagram using Queue Program");
                    Console.WriteLine("Enter 12 to execute Calendar in Queue Program");
                    Console.WriteLine("Enter 13 to execute Calendar in Stack Program");
                    Console.WriteLine("Enter 14 to execute Hashing Program");
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
                             primeNumber.Results();
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
                            AnagramIn2D anagramIn2D = new AnagramIn2D();
                            anagramIn2D.Results();
                            break;
                        case 9:
                            BinarySearchTree bst = new BinarySearchTree();
                            bst.Binary();
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
                        case 13:
                            CalendarStack calendarStack = new CalendarStack();
                            calendarStack.CalenderUsingStack();
                            break;
                        case 14:
                            HashingFunction hashingFunction = new HashingFunction();
                            hashingFunction.StoringAndRetrievingNumbers();
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
