//-----------------------------------------------------------------------
// <copyright file="CashCounter.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructure
{
    using System;
    using System.Collections;

    /// <summary>
    /// This class will add person in queue and ask their choice either withdrawal or deposit
    /// </summary>
    public class CashCounter
    {
        /// <summary>
        /// Creating object of queue class
        /// </summary>
        private Queue queue = new Queue();

        /// <summary>
        /// Creating and declaring total cash variable
        /// </summary>
        private int totalCash = 100000;

        /// <summary>
        /// count will count the number of customer inside the queue
        /// </summary>
        private int count = 0;

        /// <summary>
        /// BankOperation method show all the operation performed 
        /// in the class and ask to chose your operation
        /// </summary>
        public void BankOperations()
        {
            ////using try block to execute normal flow of the program
            try
            {
                ////ch variable is used inside the do while loop to stop the execution of program
                char ch = 'n';
                ////starting do while loop
                do
                {
                    ////asking user his choice of operations
                    Console.WriteLine("Enter 1 to add Customers");
                    Console.WriteLine("Enter 2 to Deposit cash");
                    Console.WriteLine("Enter 3 to Withdraw Cash");
                    Console.WriteLine("Enter 4 to check balance");
                    Console.WriteLine("Enter 5 to view Customers");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    ////using switch case to take directly to the chosen operation
                    switch (choice)
                    {
                        case 1:
                            this.AddCustomer();
                            break;
                        case 2:
                            this.DepositCash();
                            break;
                        case 3:
                            this.WithDrawCash();
                            break;
                        case 4:
                            this.CheckBalance();
                            break;
                        case 5:
                            this.ViewCustomer();
                            break;
                        default:
                            Console.WriteLine("Choose proper Operation");
                            break;
                    }

                    Console.WriteLine("Do you want to Continue");
                    ch = Convert.ToChar(Console.ReadLine());
                }
                while (ch != 'n');
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// AddCustomer method to add customer in the queue
        /// </summary>
        public void AddCustomer()
        {
            ////using try block to execute normal flow of the program
            try
            {
                Console.WriteLine("How many Customers you want to add");
                int cust = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= cust; i++)
                {
                    this.count++;
                    Console.WriteLine("Enter " + i + " name");
                    string name = Console.ReadLine();
                    this.queue.Enqueue(name);
                }
                ////using recusrsive method
                this.BankOperations();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Deposit cash method will help user to deposit cash in bank
        /// </summary>
        public void DepositCash()
        {
            ////using try block to execute normal flow of the program
            try
            {
                Console.WriteLine("How much cash you want to deposit");
                int cash = Convert.ToInt32(Console.ReadLine());
                if (cash > 0)
                {
                    this.totalCash = this.totalCash + cash;
                    Console.WriteLine(cash + "Cash added");
                    Console.WriteLine("Total Cash in Bank = " + this.totalCash);
                    this.queue.Dequeue();
                }
                else
                {
                    Console.WriteLine("Enter valid amount:");
                }
                ////using recursive method
                this.BankOperations();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// withdraw method will withdraw money from the bank
        /// </summary>
        public void WithDrawCash()
        {
             ////using try block to execute normal flow of the program
            try
            {
                Console.WriteLine("How much cash you want to withdraw");
                int withdraw = Convert.ToInt32(Console.ReadLine());
                if (withdraw > 0 && withdraw < this.totalCash)
                {
                    this.totalCash = this.totalCash - withdraw;
                    Console.WriteLine(withdraw + " cash withdrawn");
                    Console.WriteLine("Cash left is " + this.totalCash);
                    this.queue.Dequeue();
                }
                else
                {
                    Console.WriteLine("Enter valid Amount");
                }
                ////using recursive method
                this.BankOperations();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// this method will check the total balance of the bank
        /// </summary>
        public void CheckBalance()
        {
            ////using try block to execute normal flow of the program
            try
            {
                Console.WriteLine("Balance = " + this.totalCash);
                ////using recursive method
                this.BankOperations();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// the method check which all customer are in the queue
        /// </summary>
        public void ViewCustomer()
        {
            ////using try block to execute normal flow of the program
            try
            {
                if (this.queue != null)
                {
                    foreach (string cust in this.queue)
                    {
                        Console.WriteLine(cust);
                    }
                }
                else
                {
                    Console.WriteLine("No one is in queue");
                }
                ////using recursive method
                this.BankOperations();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
