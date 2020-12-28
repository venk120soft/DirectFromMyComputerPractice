using System;
using System.Collections.Generic;

/*
 * By looping throw each character of the string, checking for the existance 
 */
namespace ProblemSolving
{
    /// <summary>
    /// Checking for valid parathesis in given string
    /// </summary>
    class BalancedParentheses
    {
        public bool isBalanced(string givenString)
        {
            // HashMap is not there in C#
            Dictionary<char, char> hashMap = new Dictionary<char, char>();
            hashMap.Add('}', '{');
            hashMap.Add(')', '(');
            hashMap.Add(']', '[');

            Stack<char> stack = new Stack<char>();

            // looping throw each element
            for (int i = 0; i < givenString.Length; i++)
            {
                char c = givenString[i];
                // if the current character (closed paranthesis) is preesnt as key in the dictionary then
                if (hashMap.ContainsKey(c))
                {
                    char temp = stack.Pop();
                    // if (temp != hashMap.GetValueOrDefault(c))
                    if (temp != hashMap[c])
                    {
                        return false;
                    }
                }
                else
                {
                    // if the character is not in the key it may be open paranthesis 
                    stack.Push(c);
                }
            }

            return stack.Count == 0;
        }

        //public static void Main(string[] args)
        //{
        //    string input = "({[]})";
        //    BalancedParentheses balancedParentheses = new BalancedParentheses();
        //    bool isBalanced= balancedParentheses.isBalanced(input);
        //    Console.WriteLine("isBalanced: ", isBalanced);
        //}
    }
}
