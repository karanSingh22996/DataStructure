//-----------------------------------------------------------------------
// <copyright file="BalancedParenthesis.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructure
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// This class will either the given expressions are balanced or not using stack
    /// </summary>
    public class BalancedParenthesis
    {
        /// <summary>
        /// The method will check either the expression is balanced after checking all the conditions
        /// </summary>
        public void BalanceCheck()
        {
            ////Try will check for the generated exception
            try
            {
                ////declaring character variable
                char charChoice;
                ////start do while loop
                do
                {
                    Console.WriteLine("type your Expresion");
                    string strExpresion = Console.ReadLine();
                    Stack<char> stack = new Stack<char>();
                    ////loop will iterate till the length of given expression
                    for (int i = 0; i < strExpresion.Length; i++)
                    {
                        ////assigning string to character one by one
                        char charCh = strExpresion[i];
                        ////here condition is to push left parenthesis in stack
                        if (charCh == '(')
                        {
                            ////push is a static method use to add or push the data in stack
                            stack.Push(charCh);
                        }
                        else if (charCh == ')')
                        {
                            ////this will execute only if length of stack is 0
                            if (stack.Count == 0)
                            {
                                ////Console.WriteLine("stack is underflow");
                                Console.WriteLine("Expresion is unbalanced");
                            }
                            ////pop is static method of stack to remove last added data to stack
                            stack.Pop();
                        }
                    }
                    ////this will execute only if length of stack is 0
                    if (stack.Count == 0)
                    {
                        Console.WriteLine(" Expression is balanced");
                    }
                    else
                    {
                        Console.WriteLine(" Excpression is not balanced");
                    }

                    Console.WriteLine(" Do you want to continue Balanced Parenthesisclass(Type y or n) ");
                    charChoice = Convert.ToChar(Console.ReadLine());
                }
                while (charChoice == 'Y' || charChoice == 'y');
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Arithmetic Expression");
                this.BalanceCheck();
            }
        }
    }
}
