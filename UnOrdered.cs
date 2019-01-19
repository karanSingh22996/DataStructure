//-----------------------------------------------------------------------
// <copyright file="UnOrdered.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// This class will read string data from file and check if input data is in file or not
    /// if is present it will remove that data if not present it will add the data to the file
    /// </summary>
    public class UnOrdered
    {
        /// <summary>
        /// the method will check for all the operation 
        /// </summary>
        public void UnOrderedOperations()
        {
            try
            {
                ////creating object of linked list with string generic
                LinkedList<string> list = new LinkedList<string>();
                ////Assigning path to the variable
                string path = Utility.FilePathUnordered();
                ////streamreader class will read all the data from the file
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = " ";
                    while ((s = sr.ReadLine()) != null)
                    {
                        list.AddFirst(s);
                        ////Console.WriteLine(s);
                    }
                }

                ////printing all the data present inside the file
                Console.WriteLine("List Contains:");
                ////foreach loop iterate in forward direction
                foreach (string s in list)
                {
                    Console.WriteLine(s + " ");
                }
                ////asking user to search for the number
                Console.WriteLine("Enter the word to search");
                string search = Console.ReadLine();
                if (list.Contains(search))
                {
                    Console.WriteLine(search + " word is in the list");
                    Console.WriteLine("So removing " + search);
                    list.Remove(search);
                }
                else
                {
                    Console.WriteLine(search + " is not in the list");
                    Console.WriteLine("so adding into the list " + search);
                    list.AddLast(search);
                }

                string joinedData = string.Join(" ", list);
                ////Console.WriteLine("New updated File is:");
                for (int i = 0; i < list.Count; i++)
                {
                    ////streamwriter class will write the data inside the file
                    using (StreamWriter sw = new StreamWriter(Utility.FilePathUnordered()))
                    {
                        sw.WriteLine(joinedData + " ");
                        sw.Close();
                    }
                }
                ////again printing the updated list
                Console.WriteLine("New List:");
                foreach (string s in list)
                {
                    Console.WriteLine(s + " ");
                }

                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}