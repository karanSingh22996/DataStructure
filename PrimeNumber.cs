//-----------------------------------------------------------------------
// <copyright file="PrimeNumber.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructure
{
    using System;
    using System.Collections;

    /// <summary>
    /// The class will generate row by row prime number
    /// </summary>
    public class PrimeNumber
    {
        /// <summary>
        /// This class will check for the prime numbers and add them inside 2d array
        /// </summary>
        /// <param name="n">integer Parameter</param>
        /// <returns>2d array</returns>
        public int[,] Prime2DArray(int n)
        {
            ////declaring and initialiazing two D array
            int[,] prime = new int[10, 25];
            try
            {
                ////declaring variable equal to total row number
                int first = 0, second = 0, third = 0, fourth = 0;
                int fifth = 0, sixth = 0, seventh = 0, eight = 0, nineth = 0, ten = 0;
                ////Iteration will continue till the given range of the
                ////number and check how many numbers are prime in that range
                for (int i = 2; i < n; i++)
                {
                    int flag = 0;
                    ////iteration is use to check number is prime or not
                    for (int j = 2; j < i; j++)
                    {
                        ////if this satify then number is not prime
                        if (i % j == 0)
                        {
                            flag = 1;
                        }
                    }
                    ////if value of flag is zero then number is prime 
                    ////Console.WriteLine("Enter your range");

                    if (flag == 0)
                    {
                        switch (i)
                        {
                            case var expression when i > 0 && i <= 100:
                                prime[0, first++] = i;
                                break;
                            case var expression when i > 100 && i <= 200:
                                prime[1, second++] = i;
                                break;
                            case var expression when i > 200 && i <= 300:
                                prime[2, third++] = i;
                                break;
                            case var expression when i > 300 && i <= 400:
                                prime[3, fourth++] = i;
                                break;
                            case var expression when i > 400 && i <= 500:
                                prime[4, fifth++] = i;
                                break;
                            case var expression when i > 500 && i <= 600:
                                prime[5, sixth++] = i;
                                break;
                            case var expression when i > 600 && i <= 700:
                                prime[6, seventh++] = i;
                                break;
                            case var expression when i > 700 && i <= 800:
                                prime[7, eight++] = i;
                                break;
                            case var expression when i > 800 && i <= 900:
                                prime[8, nineth++] = i;
                                break;
                            case var expression when i > 900 && i <= 1000:
                                prime[9, ten++] = i;
                                break;
                            default:
                                ////some code
                                break;
                        }
                        ////////store prime in range 0-100
                        ////if ((i > 0) && (i <= 100))
                        ////{
                        ////    prime[0, first++] = i;
                        ////}
                        ////else if ((i > 100) && (i <= 200))
                        ////{
                        ////    prime[1, second++] = i;
                        ////}
                        ////else if ((i > 200) && (i <= 300))
                        ////{
                        ////    prime[2, third++] = i;
                        ////}
                        ////else if ((i > 300) && (i <= 400))
                        ////{
                        ////    prime[3, fourth++] = i;
                        ////}
                        ////else if ((i > 400) && (i <= 500))
                        ////{
                        ////    prime[4, fifth++] = i;
                        ////}
                        ////else if ((i > 500) && (i <= 600))
                        ////{
                        ////    prime[5, sixth++] = i;
                        ////}
                        ////else if ((i > 600) && (i <= 700))
                        ////{
                        ////    prime[6, seventh++] = i;
                        ////}
                        ////else if ((i > 700) && (i <= 800))
                        ////{
                        ////    prime[7, eight++] = i;
                        ////}
                        ////else if ((i > 800) && (i <= 900))
                        ////{
                        ////    prime[8, nineth++] = i;
                        ////}
                        ////else if ((i > 900) && (i <= 1000))
                        ////{
                        ////    prime[9, ten++] = i;
                        ////}
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return prime;
        }

        /// <summary>
        /// Results method will give all prime numbers in 2d.
        /// </summary>
        public void Results()
        {
            PrimeNumber primeNumber = new PrimeNumber();
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
        }
    }    
}
