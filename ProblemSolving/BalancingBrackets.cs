using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class BalancingBrackets
    {
        // Ex: {(}}
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

        //static void Main(string[] args)
        //{
        //    var watch = new System.Diagnostics.Stopwatch();
        //    watch.Start();
        //    BalancingBrackets balancingBrackets = new BalancingBrackets();
        //    var flag = balancingBrackets.isBalanced("{()}");
        //    Console.WriteLine("Is Balanced: {0}", flag);
        //    Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
        //    watch.Stop();

        //    Console.ReadLine();
        //}

    }
}