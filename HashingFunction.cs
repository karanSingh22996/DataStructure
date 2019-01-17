using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class HashingFunction
    {
        public string[] theArray;
        int arraySize;
        int itemsInArray = 0;
        public HashingFunction(int size)
        {
            arraySize = size;
            theArray = new string[size];
            for (int i = 0; i < theArray.Length; i++)
            {
                theArray[0] = "-1";

            }
        }
        public void DisplayTheStack()
        {
            int increment = 0;
            for (int m = 0; m < 3; m++)
            {

                increment += 10;

                for (int n = 0; n < 71; n++)

                    Console.Write("-");

                Console.WriteLine();

                for (int n = increment - 10; n < increment; n++)
                {


                    Console.WriteLine("| %3s " + " ", n);

                }

                Console.WriteLine("|");

                for (int n = 0; n < 71; n++)

                    Console.Write("-");

                Console.WriteLine();


                for (int n = increment - 10; n < increment; n++)
                {

                    if (theArray[n].Equals("-1"))

                        Console.Write("|      ");

                    else

                        Console.Write(String.Format("| %3s " + " ", theArray[n]));
                }



                Console.Write("|");



                for (int n = 0; n < 71; n++)
                    Console.Write("-");



                Console.Write("");

            }
            }
            public void HashFunction(string[] stringForArray, string[] theArray)
            {
                for (int n = 0; n < stringForArray.Length; n++)
                {
                    string newElementVal = stringForArray[n];
                    theArray[int.Parse(newElementVal)] = newElementVal;
                }
            }
    }
}