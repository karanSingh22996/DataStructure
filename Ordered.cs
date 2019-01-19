//-----------------------------------------------------------------------
// <copyright file="Ordered.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructure
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// ordered class will read data from file and check if input data is available or not if data
    /// is available it will remove and if not available it will add that data to the list
    /// </summary>
    public class Ordered
    {
        /// <summary>
        /// ordered list is will perform all the operation
        /// </summary>
        public void OrderedList()
        {
            try
            {
                ////creating object of linked list class with int as generic
                LinkedList<int> linkedList = new LinkedList<int>();
                ////assigning path of file using FileOrdered method
                string path = Utility.FilePathOrdered();
                ////printing the data of the file 
                Console.WriteLine("List Contains");
                ////streamreader is used to read the data from file 
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = " ";
                    ////loop will iterate till the the last data in file
                    while ((s = sr.ReadLine()) != null)
                    {
                        ////using parse method to convert string into number
                        s.Split(',');
                        int number = int.Parse(s);
                        ////adding file data to linked list
                        linkedList.AddFirst(number);
                        Console.WriteLine(s);
                    }
                }

                ArrayList list = new ArrayList(linkedList);
                list.Sort();
                Console.WriteLine("Sorted data is:");
                foreach (int i in list)
                {
                    Console.WriteLine(i + " ");
                }
                ////searching data if present remove if not add to the list
                Console.WriteLine("Enter an item to search");
                int search = Convert.ToInt32(Console.ReadLine());
                if (list.Contains(search))
                {
                    Console.WriteLine(search + " is int the list");
                    Console.WriteLine("So removing " + search);
                    list.Remove(search);
                }
                else
                {
                    Console.WriteLine(search + " is not in the list");
                    Console.WriteLine("So adding " + search + " in list");
                    list.Add(search);
                }

                list.Sort();
                LinkedList<int> linkedlist = new LinkedList<int>();
                Console.WriteLine("Updated data of list is:");
                foreach (int j in list)
                {
                    linkedlist.AddFirst(j);
                    Console.WriteLine(j + " ");
                }

                string joinedData = string.Join(" ", linkedlist);
                ////Console.WriteLine("New updated File is:");
                ////again writing updated list to the file using streamwriter class
                for (int i = 0; i < list.Count; i++)
                {
                    using (StreamWriter sw = new StreamWriter(Utility.FilePathOrdered()))
                    {
                        sw.WriteLine(joinedData + " ");
                        sw.Close();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
