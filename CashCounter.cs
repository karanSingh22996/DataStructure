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
        /// Method to perform all the operation performed inside the bank
        /// </summary>
        public void MaintainBank()
        {
            ////using try block to continue the normal flow of execution
            try
            {
                ////Asking user how many cash bank have
                Console.WriteLine("How much cash bank have?");
                int totalCash = Convert.ToInt32(Console.ReadLine());
                ////creating queue class object
                Queue queue = new Queue();
                ////asking user how many customer are in queue
                Console.WriteLine("How many Persons are in queue");
                int num = Convert.ToInt32(Console.ReadLine());
                ////iteration will continue till all the members give their name
                for (int i = 1; i <= num; i++)
                {
                    ////asking user to write their name
                    Console.WriteLine("Enter " + i + "Name:");
                    string name = Console.ReadLine();
                    ////using enqueue method to add them in queue
                    queue.Enqueue(name);
                }
                ////this loops will iterate till every added customer perform their task
                while (num > 0)
                {
                    ////Asking user their choice either withdrawal or deposit
                    Console.WriteLine("Press 1.For Withdrawal and \n Press 2.To Deposit");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    ////switch case will take them directly to their chosen operation
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("How much cash You want to withdraw ?");
                            int withdrawalAmount = Convert.ToInt32(Console.ReadLine());
                            ////Validation to check if money is availabe or not and withrawal amount is greater than zero
                            if (withdrawalAmount < totalCash && withdrawalAmount > 0)
                            {
                                ////withdrawal amount will be subtracted from total cash
                                totalCash = totalCash - withdrawalAmount;
                                Console.WriteLine("Cash withdrawn: " + withdrawalAmount);
                                ////dequeue method will remove last added user from the queue
                                queue.Dequeue();
                            }
                            else
                            {
                                Console.WriteLine("Enter amount less than " + totalCash);
                            }

                            break;
                        case 2:
                            Console.WriteLine("How much money you want to deposit ?");
                            int depositAmount = Convert.ToInt32(Console.ReadLine());
                            ////validation to check whether given amount is greater than zero or not
                            if (depositAmount > 0)
                            {
                                ////deposit cash will be added in total cash
                                totalCash = totalCash + depositAmount;
                                ////Dequeque method will remove the last added user
                                queue.Dequeue();
                            }
                            else
                            {
                                Console.WriteLine("Enter valid Amount");
                            }

                            break;
                        default:
                            Console.WriteLine("Please choose valid option!");
                            break;
                    }

                    num--;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }   
    }
}
