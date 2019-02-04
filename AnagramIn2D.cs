//-----------------------------------------------------------------------
// <copyright file="AnagramIn2D.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructure
{
    using System;
    using System.Collections;

    /// <summary>
    /// This class will print the numbers which are anagram and prime 
    /// and also which are prime but not anagram
    /// </summary>
    public class AnagramIn2D
    {
        /// <summary>
        /// Results method is use to count and print the number
        /// which are anagram and prime but not anagram.
        /// </summary>
        public void Results()
        {
            try
            {                              
                int anagramIndex = 0;
                int notAnagramIndex = 0;
                int anagramCount = 0;
                int notAAnagramCount = 0;
                ////Arraylist is use to store the data from the method list of prime which is static
                ArrayList primenumbers = Utility.ListOfPrimes();
                ////array is declared equal to the size of arraylist
                string[] anagrams = new string[primenumbers.Count];
                ////array is declared equal to the size of arraylist
                string[] notAnagram = new string[primenumbers.Count];
                ////this for loop is used for taking one by one element from the array list
                for (int i = 0; i < primenumbers.Count; i++)
                {
                    ////converting number int to string
                    string number1 = primenumbers[i] + string.Empty;
                    ////converting string number in to character array
                    char[] numberInArray1 = number1.ToCharArray();
                    Array.Sort(numberInArray1);
                    ////converting character array in to string
                    string original1 = new string(numberInArray1);
                    bool found = true;
                    for (int j = i + 1; j < primenumbers.Count; j++)
                    {
                        ////converting number int to string
                        string number2 = primenumbers[j] + string.Empty;
                        ////converting string number in to character array
                        char[] numberInArray2 = number2.ToCharArray();
                        Array.Sort(numberInArray2);
                        ////converting character array in to string
                        string original2 = new string(numberInArray2);
                        if (original1.Equals(original2))
                        {
                            found = false;
                            anagrams[anagramIndex++] = number1;
                            anagrams[anagramIndex++] = number2;
                            anagramCount = anagramCount + 2;
                        }
                    }

                    if (found)
                    {
                        notAnagram[notAnagramIndex++] = number1;
                        notAAnagramCount++;
                    }
                }

                for (int i = 0; i <= anagramCount; i++)
                {
                    Console.Write(anagrams[i] + "\t");
                }

                Console.WriteLine();
                Console.WriteLine("Prime but not anagrams");
                for (int j = 0; j <= notAAnagramCount; j++)
                {
                    Console.Write(notAnagram[j] + "\t");
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
